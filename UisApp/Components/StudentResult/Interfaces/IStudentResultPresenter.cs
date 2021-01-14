using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models;
using UisApp.MVP.Core;

namespace UisApp.Components.StudentResult.Interfaces
{
    public interface IStudentResultPresenter : IPresenter<IStudentResultPresenter, IStudentResultView>
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
        /// Установить студентов
        /// </summary>
        /// <param name="students"></param>
        void SetStudents(IList<StudentResultModel> students);

        /// <summary>
        /// Установить оценку студенту
        /// </summary>
        /// <param name="student"></param>
        void StudentSetGrade(StudentResultModel student);
    }
}
