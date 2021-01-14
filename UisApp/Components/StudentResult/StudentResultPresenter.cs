using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.Rating.Interfaces;
using UisApp.Components.StudentResult.Interfaces;
using UisApp.Models;
using UisApp.MVP.Support;

namespace UisApp.Components.StudentResult
{
    public class StudentResultPresenter : PresenterBase<IStudentResultPresenter, IStudentResultView>, IStudentResultPresenter
    {
        IResultModel Model;

        public StudentResultPresenter(IResultModel model)
        {
            Model = model;

            Model.StudentsUpdated += Model_StudentsUpdated;
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
        /// Установить студентов
        /// </summary>
        /// <param name="students"></param>
        public void SetStudents(IList<StudentResultModel> students)
        {
            Model.SetStudents(students);
        }

        /// <summary>
        /// Установить оценку студенту
        /// </summary>
        /// <param name="student"></param>
        public void StudentSetGrade(StudentResultModel student)
        {
            Model.StudentSetGrade(student);
        }

        protected override void RefreshView(IStudentResultView viewInstance)
        {
            if (viewInstance == null)
            {
                throw new ArgumentNullException(nameof(viewInstance));
            }
        }

        protected override IStudentResultPresenter GetPresenterEndpoint()
        {
            return this;
        }

        private void Model_StudentsUpdated(object sender, EventArgs e)
        {
            Model = sender as IResultModel;
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
