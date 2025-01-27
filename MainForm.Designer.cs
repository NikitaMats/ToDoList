namespace ToDoList
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            tabControl = new TabControl();
            TaskList = new TabPage();
            DeleteButton = new Button();
            AddButton = new Button();
            StatusComboBox = new ComboBox();
            label4 = new Label();
            DescriptionTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ExecutorTextBox = new TextBox();
            NameTextBox = new TextBox();
            label1 = new Label();
            TaskListBox = new ListBox();
            tabPage2 = new TabPage();
            tabControl.SuspendLayout();
            TaskList.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(TaskList);
            tabControl.Controls.Add(tabPage2);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(784, 461);
            tabControl.TabIndex = 1;
            // 
            // TaskList
            // 
            TaskList.Controls.Add(DeleteButton);
            TaskList.Controls.Add(AddButton);
            TaskList.Controls.Add(StatusComboBox);
            TaskList.Controls.Add(label4);
            TaskList.Controls.Add(DescriptionTextBox);
            TaskList.Controls.Add(label3);
            TaskList.Controls.Add(label2);
            TaskList.Controls.Add(ExecutorTextBox);
            TaskList.Controls.Add(NameTextBox);
            TaskList.Controls.Add(label1);
            TaskList.Controls.Add(TaskListBox);
            TaskList.Location = new Point(4, 24);
            TaskList.Name = "TaskList";
            TaskList.Padding = new Padding(3);
            TaskList.Size = new Size(776, 433);
            TaskList.TabIndex = 0;
            TaskList.Text = "Tasks";
            TaskList.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(535, 381);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(161, 38);
            DeleteButton.TabIndex = 10;
            DeleteButton.Text = "button2";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(364, 381);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(161, 38);
            AddButton.TabIndex = 9;
            AddButton.Text = "button1";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(222, 396);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(130, 23);
            StatusComboBox.TabIndex = 8;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 381);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Task Status:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(220, 75);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(476, 294);
            DescriptionTextBox.TabIndex = 6;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 60);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 5;
            label3.Text = "Description:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(466, 10);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Executor:";
            // 
            // ExecutorTextBox
            // 
            ExecutorTextBox.Location = new Point(466, 25);
            ExecutorTextBox.Name = "ExecutorTextBox";
            ExecutorTextBox.Size = new Size(230, 23);
            ExecutorTextBox.TabIndex = 3;
            ExecutorTextBox.TextChanged += ExecutorTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(220, 25);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(230, 23);
            NameTextBox.TabIndex = 2;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 10);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // TaskListBox
            // 
            TaskListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            TaskListBox.FormattingEnabled = true;
            TaskListBox.ItemHeight = 15;
            TaskListBox.Location = new Point(10, 10);
            TaskListBox.Name = "TaskListBox";
            TaskListBox.Size = new Size(200, 409);
            TaskListBox.TabIndex = 0;
            TaskListBox.SelectedIndexChanged += TaskListBox_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(776, 433);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "About Us";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(tabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "ToDoList";
            FormClosed += MainForm_FormClosed;
            tabControl.ResumeLayout(false);
            TaskList.ResumeLayout(false);
            TaskList.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage TaskList;
        private TabPage tabPage2;
        private ListBox TaskListBox;
        private Label label1;
        private Label label2;
        private TextBox ExecutorTextBox;
        private TextBox NameTextBox;
        private TextBox DescriptionTextBox;
        private Label label3;
        private Label label4;
        private Button AddButton;
        private ComboBox StatusComboBox;
        private Button DeleteButton;
    }
}
