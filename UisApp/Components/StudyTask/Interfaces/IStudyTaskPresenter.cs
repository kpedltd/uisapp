using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models;
using UisApp.MVP.Core;

namespace UisApp.Components.StudyTask.Interfaces
{
    public interface IStudyTaskPresenter : IPresenter<IStudyTaskPresenter, IStudyTaskView>
    {
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
    }
}
