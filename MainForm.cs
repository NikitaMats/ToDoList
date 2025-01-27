using ToDoList.Model;
using ToDoList.Model.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection.Emit;
using System.CodeDom.Compiler;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ToDoList
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Коллекция задач.
        /// </summary>
        private List<Tasks> _tasks = new List<Tasks>();

        /// <summary>
        /// Выбранный задач.
        /// </summary>
        private Tasks _currentTask;

        /// <summary>
        /// Цвет ошибки.
        /// </summary>
        private readonly Color _errorColor = Color.LightPink;

        /// <summary>
        /// Цвет окна без ошибок.
        /// </summary>
        private readonly Color _normalColor = Color.White;

        public MainForm()
        {
            InitializeComponent();

            StatusComboBox.DataSource = Enum.GetValues(typeof(Status));

            try
            {
                _tasks = Serializer.LoadData();
                for (int i = 0; i <= _tasks.Count - 1; i++)
                {
                    TaskListBox.Items.Add(FormattedText(_tasks[i]));
                }
            }
            catch
            {
                Serializer.CreateFile();
                _tasks = new List<Tasks>();
            }
        }

        /// <summary>
        /// Возвращает форматированный текст для вывода в List Box. 
        /// </summary>
        /// <param name="task"> Задача для форматирования.</param>
        /// /// <returns>Возвращает форматированный текст.</returns>
        private string FormattedText(Tasks task)
        {
            return $"{task.Name} " + $": {task.TaskStatus}";
        }

        /// <summary>
        ///Очищает информацию о задаче.
        /// </summary>
        private void ClearTaskInfo()
        {
            TaskListBox.Items.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
            ExecutorTextBox.Clear();
        }

        /// <summary>
        /// Обновляет информацию о задаче.
        /// </summary>
        /// <param name="task">Задача для обновления информации.</param>
        private void UpdateTaskInfo(Tasks task)
        {
            int indexSelectedTask = TaskListBox.SelectedIndex;

            if (indexSelectedTask == -1) return;

            TaskListBox.Items[indexSelectedTask] = FormattedText(task);
        }

        /// <summary>
        /// Сортировка списка задач.
        /// </summary>
        private void TaskSort()
        {
            _tasks.Sort(delegate (Tasks task1, Tasks task2)
            { return task1.Name.CompareTo(task2.Name); });
            TaskListBox.Items.Clear();
            for (int i = 0; i <= _tasks.Count - 1; i++)
            {
                TaskListBox.Items.Add(FormattedText(_tasks[i]));
            }
            TaskListBox.SelectedIndex = _tasks.IndexOf(_currentTask);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentTask = new Tasks("Имя задачи", "Описание задачи", Status.InPlans, "Исполнитель");
            _tasks.Add(_currentTask);
            TaskListBox.Items.Add(FormattedText(_currentTask));
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int indexSelectedStudent = TaskListBox.SelectedIndex;

            if (indexSelectedStudent == -1) return;

            _tasks.RemoveAt(indexSelectedStudent);

            ClearTaskInfo();

            for (int i = 0; i <= _tasks.Count - 1; i++)
            {
                TaskListBox.Items.Add(FormattedText(_tasks[i]));
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;

            try
            {
                _currentTask.Name = NameTextBox.Text;
                UpdateTaskInfo(_currentTask);
                TaskSort();
            }
            catch
            {
                NameTextBox.BackColor = _errorColor;
                return;
            }

            NameTextBox.BackColor = _normalColor;
        }

        private void TaskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedItem == null) return;

            int indexSelectedTask = TaskListBox.SelectedIndex;
            _currentTask = _tasks[indexSelectedTask];
            NameTextBox.Text = _currentTask.Name.ToString();
            DescriptionTextBox.Text = _currentTask.Description.ToString();
            ExecutorTextBox.Text = _currentTask.Executor.ToString();
            StatusComboBox.Text = _currentTask.TaskStatus.ToString();
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;

            try
            {
                _currentTask.Description = DescriptionTextBox.Text;
                UpdateTaskInfo(_currentTask);
            }
            catch
            {
                DescriptionTextBox.BackColor = _errorColor;
                return;
            }

            DescriptionTextBox.BackColor = _normalColor;
        }

        private void ExecutorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;

            try
            {
                _currentTask.Executor = ExecutorTextBox.Text;
                UpdateTaskInfo(_currentTask);
            }
            catch
            {
                ExecutorTextBox.BackColor = _errorColor;
                return;
            }

            ExecutorTextBox.BackColor = _normalColor;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TaskListBox.SelectedIndex == -1) return;

            try
            {
                _currentTask.TaskStatus = (Status)StatusComboBox.SelectedItem;
                UpdateTaskInfo(_currentTask);
                TaskSort();
            }
            catch
            {
                StatusComboBox.BackColor = _errorColor;
                return;
            }

            StatusComboBox.BackColor = _normalColor;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Serializer.WriteData(_tasks);
        }
    }
}
