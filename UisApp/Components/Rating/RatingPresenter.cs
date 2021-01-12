using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.Rating.Interfaces;
using UisApp.Models;
using UisApp.MVP.Support;

namespace UisApp.Components.Rating
{
    public class RatingPresenter : PresenterBase<IRatingPresenter, IRatingView>, IRatingPresenter
    {
        IRatingModel Model;

        public RatingPresenter(IRatingModel model)
        {
            Model = model;
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
        public void SetStudents(IList<StudentRatingModel> students)
        {
            Model.SetStudents(students);
        }

        /// <summary>
        /// Установить оценку студенту
        /// </summary>
        /// <param name="student"></param>
        public void StudentSetGrade(StudentRatingModel student)
        {
            Model.StudentSetGrade(student);
        }

        protected override void RefreshView(IRatingView viewInstance)
        {
            if (viewInstance == null)
            {
                throw new ArgumentNullException(nameof(viewInstance));
            }

        }

        protected override IRatingPresenter GetPresenterEndpoint()
        {
            return this;
        }
    }
}
