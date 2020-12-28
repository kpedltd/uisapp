using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UisApp.Models
{
    enum SubjectCertification
    {
        exam,
        record,
        coursework
    }

    class SubjectModel
    {
        public string name
        {
            get;
            set;
        }

        public int lecturerId
        {
            get;
            set;
        }

        public SubjectCertification certification
        {
            get;
            set;
        }
    }
}
