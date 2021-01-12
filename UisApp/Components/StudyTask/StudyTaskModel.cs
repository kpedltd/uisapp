using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Providers;
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

            /// Ленивая реализация - по-хорошему нужен отдельный event
            TasksUpdated?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Изменить задачу
        /// </summary>
        /// <param name="model"></param>
        public void EditTask(TaskExtModel model)
        {
            for(int i = 0;i < Tasks.Count;i++)
            {
                if(Tasks[i].Id == model.Id)
                {
                    Tasks[i].Title = model.Title;
                    Tasks[i].Description = model.Description;
                    Tasks[i].Begin = model.Begin;
                    Tasks[i].Deadline = model.Deadline;
                    Tasks[i].Photo = model.Photo;
                    Tasks[i].Test = model.Test;

                    break;
                }
            }

            /// Ленивая реализация - по-хорошему нужен отдельный event
            TasksUpdated?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Удалить модель
        /// </summary>
        /// <param name="model"></param>
        public void DeleteTask(TaskExtModel model)
        {
            Tasks.Remove(model);

            /// Ленивая реализация - по-хорошему нужен отдельный event
            TasksUpdated?.Invoke(this, EventArgs.Empty);

            TaskProvider.Delete(model.Id);
        }
    }
}
