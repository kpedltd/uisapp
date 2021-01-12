using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models;
using UisApp.MVP;

namespace UisApp.Components.StudyTask.Interfaces
{
    public interface IStudyTaskModel : IModel
    {
        /// <summary>
        /// Предмет
        /// </summary>
        SubjectExtModel Subject
        {
            get;
        }

        /// <summary>
        /// Группа
        /// </summary>
        GroupExtModel Group
        {
            get;
        }

        /// <summary>
        /// Задачи
        /// </summary>
        IList<TaskExtModel> Tasks
        {
            get;
        }

        /// <summary>
        /// Событие обновления задач
        /// </summary>
        event EventHandler TasksUpdated;

        /// <summary>
        /// Установить предмет
        /// </summary>
        /// <param name="model"></param>
        void SetSubject(SubjectExtModel model);

        /// <summary>
        /// Установить группу
        /// </summary>
        /// <param name="model"></param>
        void SetGroup(GroupExtModel model);

        /// <summary>
        /// Установить задачи
        /// </summary>
        /// <param name="tasks"></param>
        void SetTasks(IList<TaskExtModel> tasks);

        /// <summary>
        /// Добавить задачу
        /// </summary>
        /// <param name="model"></param>
        void AddTask(TaskExtModel model);

        /// <summary>
        /// Изменить задачу
        /// </summary>
        /// <param name="model"></param>
        void EditTask(TaskExtModel model);

        /// <summary>
        /// Удалить модель
        /// </summary>
        /// <param name="model"></param>
        void DeleteTask(TaskExtModel model);
    }
}
