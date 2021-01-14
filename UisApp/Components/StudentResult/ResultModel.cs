using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.Rating.Interfaces;
using UisApp.Models;
using UisApp.API.Providers;
using UisApp.Components.StudentResult.Interfaces;

namespace UisApp.Components.StudentResult
{
    public class ResultModel : IResultModel
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
        /// Студенты
        /// </summary>
        public IList<StudentResultModel> Students
        {
            get;
            private set;
        }


        /// <summary>
        /// Событие обновления студентов
        /// </summary>
        public event EventHandler StudentsUpdated;

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
        /// Установить студентов
        /// </summary>
        /// <param name="students"></param>
        public void SetStudents(IList<StudentResultModel> students)
        {
            Students = students;
            if (students.Count == 0)
            {

                //Students = RatingProvider.CreateEntries(Group.Id, Subject.Id);
            }

            StudentsUpdated?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Установить оценку для студента
        /// </summary>
        /// <param name="student"></param>
        public void StudentSetGrade(StudentResultModel student)
        {
            RatingProvider.RateStudent(
                student.Student.Id,
                Subject.Id,
                student.Grade);
        }
    }
}
