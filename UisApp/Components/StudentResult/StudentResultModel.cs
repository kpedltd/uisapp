using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.Rating.Interfaces;
using UisApp.Components.StudentResult.Interfaces;
using UisApp.Models;

namespace UisApp.Components.StudentResult
{
    public class StudentResultModel : IStudentResultModel
    {
        /// <summary>
        /// Студент
        /// </summary>
        public StudentExtModel Student
        {
            get;
            set;
        }

        /// <summary>
        /// Оценка
        /// </summary>
        public int Grade
        {
            get;
            set;
        }
    }
}
