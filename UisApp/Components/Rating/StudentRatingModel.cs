using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.Rating.Interfaces;
using UisApp.Models;

namespace UisApp.Components.Rating
{
    public class StudentRatingModel : IStudentRatingModel
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
