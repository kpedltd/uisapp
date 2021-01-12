using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models;

namespace UisApp.Components.Rating.Interfaces
{
    public interface IRatingModel
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
        /// Студенты
        /// </summary>
        IList<StudentRatingModel> Students
        {
            get;
        }

        /// <summary>
        /// Событие обновления студентов
        /// </summary>
        event EventHandler StudentsUpdated;

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
        /// Установить студентов
        /// </summary>
        /// <param name="students"></param>
        void SetStudents(IList<StudentRatingModel> students);

        /// <summary>
        /// Установить оценку студенту
        /// </summary>
        /// <param name="student"></param>
        void StudentSetGrade(StudentRatingModel student);
    }
}
