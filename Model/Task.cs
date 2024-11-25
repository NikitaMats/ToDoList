using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Model.Enums;

namespace ToDoList.Model
{
    /// <summary>
    /// Класс отвечающий за хранение данных о задачах.
    /// </summary>
    internal class Task
    {
        /// <summary>
        /// Id задачи.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Имя задачи.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание задачи.
        /// </summary>
        private string _description;

        /// <summary>
        /// Статус задачи.
        /// </summary>
        private Status _status;

        /// <summary>
        /// Счетчик задач.
        /// </summary>
        private static int _allTaskCount;

        /// <summary>
        /// Исполнитель задачи.
        /// </summary>
        private string _executor;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Student"/>.
        /// </summary>
        public Task()
        {
            _allTaskCount++;
            _id = _allTaskCount;
        }

        /// <summary>
        /// Возвращает и задает Id задачи.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Возвращает и задаёт статус задачи.
        /// </summary>
        public Status TaskStatus { get; set; }

        /// <summary>
        /// Возвращает и задаёт имя студента. Длинна не должна превышать 200 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(Name), 0, 20, value);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт описание задачи. Длинна не должна превышать 10 символов.
        /// </summary>
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(Description), 0, 0, value);
                _description = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт исполнителя задачи. Длинна не должна превышать 15 символов.
        /// </summary>
        public string Executor
        {
            get
            {
                return _description;
            }
            set
            {
                Validator.AssertCountSymbolsInRange(nameof(Description), 0, 15, value);
                _description = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Student"/>.
        /// </summary>
        public Task(string name, string description, Status taskStatus, string executor)
        {
            Name = name;
            Description = description;
            TaskStatus = taskStatus;
            Executor = executor;
            _allTaskCount++;
            Id = _allTaskCount;
        }
    }
}
