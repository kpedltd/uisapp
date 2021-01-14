using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.StudentResult.Interfaces;

namespace UisApp.Components.StudentResult
{
    public class StudentTaskModel : IStudentTaskModel
    {
        /// <summary>
        /// ИД
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Название
        /// </summary>
        public string Title
        {
            get;
            set;
        }
    }
}
