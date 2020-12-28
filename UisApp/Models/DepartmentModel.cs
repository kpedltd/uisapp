using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models.Interfaces;

namespace UisApp.Models
{
    class DepartmentModel : IModel
    {
        /// <summary>
        /// Название
        /// </summary>
        public string name
        {
            get;
            set;
        }

        /// <summary>
        /// Номер факультета
        /// </summary>
        public int facultyId
        {
            get;
            set;
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
