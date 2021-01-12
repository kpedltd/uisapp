using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.StudyTask.Interfaces;
using UisApp.Models;
using UisApp.MVP.Support;

namespace UisApp.Components.StudyTask
{
    class StudyTaskPresenter : PresenterBase<IStudyTaskPresenter, IStudyTaskView>, IStudyTaskPresenter
    {
        IStudyTaskModel Model;

        public StudyTaskPresenter(IStudyTaskModel model)
        {
            Model = model;

            Model.TasksUpdated += Model_TasksUpdated;
        }

        protected override void RefreshView(IStudyTaskView viewInstance)
        {
            if (viewInstance == null)
            {
                throw new ArgumentNullException(nameof(viewInstance));
            }
        }

        protected override IStudyTaskPresenter GetPresenterEndpoint()
        {
            return this;
        }

        /// <summary>
        /// Установить предмет
        /// </summary>
        /// <param name="model"></param>
        public void SetSubject(SubjectExtModel model)
        {
            Model.SetSubject(model);
        }

        /// <summary>
        /// Установить группу
        /// </summary>
        /// <param name="model"></param>
        public void SetGroup(GroupExtModel model)
        {
            Model.SetGroup(model);
        }

        /// <summary>
        /// Установить задачи
        /// </summary>
        /// <param name="tasks"></param>
        public void SetTasks(IList<TaskExtModel> tasks)
        {
            Model.SetTasks(tasks);
        }

        /// <summary>
        /// Добавить задачу
        /// </summary>
        /// <param name="model"></param>
        public void AddTask(TaskExtModel model)
        {
            Model.AddTask(model);
        }

        private void Model_TasksUpdated(object sender, EventArgs e)
        {
            Model = sender as IStudyTaskModel;
            lock (views)
            {
                views
                .ToList()
                .ForEach((x) =>
                {
                    x.Update(Model);
                });
            }
        }
    }
}
