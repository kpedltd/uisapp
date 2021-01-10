using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UisApp.Components.Attendance.Interfaces;
using UisApp.API.Providers;
using UisApp.Models;

namespace UisApp.Components.Attendance
{
    public partial class AttendanceView : UserControl, IUisComponent, IAttendanceView
    {
        /// <summary>
        /// Предметы
        /// </summary>
        private IList<SubjectExtModel> __subjects;

        /// <summary>
        /// Презентер
        /// </summary>
        public IAttendancePresenter Presenter
        {
            get;
            set;
        }

        public AttendanceView()
        {
            InitializeComponent();
            GetSubjects();
        }

        /// <summary>
        /// Привязать презентер
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="requiresInitialState"></param>
        public void AttachToPresenter(IAttendancePresenter presenter, bool requiresInitialState)
        {
            if (presenter == null)
            {
                throw new ArgumentNullException(nameof(presenter));
            }

            DetatchFromPresenter();

            Presenter = presenter;
            Presenter.ConnectView(this, requiresInitialState);
        }

        /// <summary>
        /// Отвязать презентер
        /// </summary>
        public void DetatchFromPresenter()
        {
            lock (this)
            {
                if (Presenter != null)
                {
                    Presenter.DisconnectView(this);
                    Presenter = null;
                }
            }
        }

        public void Update(IAttendanceModel model)
        {
            throw new NotImplementedException();
        }

        

        private void GetSubjects()
        {
            __subjects = LecturerProvider.GetSubjects();
            for(int i = 0;i < __subjects.Count;i++)
            {
                subjectComboBox.Items.Add(__subjects[i].Name);
            }
        }
    }
}
