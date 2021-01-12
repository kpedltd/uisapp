using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.StudyTask.Interfaces;
using UisApp.Models;

namespace UisApp.Components.StudyTask
{
    class StudyTaskModel : IStudyTaskModel
    {
        /// <summary>
        /// Предмет
        /// </summary>
        public SubjectExtModel Subject
        {
            get;
            private set;
        }

        /// <summary>
        /// Группа
        /// </summary>
        public GroupExtModel Group
        {
            get;
            private set;
        }

        /// <summary>
        /// Задачи
        /// </summary>
        public IList<TaskExtModel> Tasks
        {
            get;
            private set;
        }

        /// <summary>
        /// Событие обновления задач
        /// </summary>
        public event EventHandler TasksUpdated;

        /// <summary>
        /// Установить предмет
        /// </summary>
        /// <param name="model"></param>
        public void SetSubject(SubjectExtModel model)
        {
            Subject = model;
        }

        /// <summary>
        /// Установить группу
        /// </summary>
        /// <param name="model"></param>
        public void SetGroup(GroupExtModel model)
        {
            Group = model;
        }

        /// <summary>
        /// Установить задачи
        /// </summary>
        /// <param name="tasks"></param>
        public void SetTasks(IList<TaskExtModel> tasks)
        {
            Tasks = tasks;

            TasksUpdated?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Добавить задачу
        /// </summary>
        /// <param name="model"></param>
        public void AddTask(TaskExtModel model)
        {
            Tasks.Add(model);
        }
    }
}
