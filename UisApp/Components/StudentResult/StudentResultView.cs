using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UisApp.API.Providers;
using UisApp.Models;
using UisApp.Components.Attendance;
using UisApp.Components.Rating.Interfaces;
using UisApp.Components.StudentResult.Interfaces;

namespace UisApp.Components.StudentResult
{
    public partial class StudentResultView : UserControl, IUisComponent, IStudentResultView
    {
        /// <summary>
        /// Предметы
        /// </summary>
        private IList<SubjectExtModel> Subjects;

        /// <summary>
        /// Группы
        /// </summary>
        private IList<GroupExtModel> Groups;

        /// <summary>
        /// Посещаемость студентов
        /// </summary>
        public IList<StudentResultModel> StudentResults
        {
            get;
            set;
        }

        /// <summary>
        /// Презентер
        /// </summary>
        public IStudentResultPresenter Presenter
        {
            get;
            set;
        }

        public StudentResultView()
        {
            InitializeComponent();

            ratingPanel.Visible = false;
        }

        /// <summary>
        /// Привязать презентер
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="requiresInitialState"></param>
        public void AttachToPresenter(IStudentResultPresenter presenter, bool requiresInitialState)
        {
            if (presenter == null)
            {
                throw new ArgumentNullException(nameof(presenter));
            }

            DetatchFromPresenter();

            Presenter = presenter;
            Presenter.ConnectView(this, requiresInitialState);

            GetSubjects();
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

        /// <summary>
        /// Обновить
        /// </summary>
        /// <param name="model"></param>
        public void Update(IResultModel model)
        {
            StudentResults = model.Students;

            DisposeRatingPanel();
            FillRating();
        }

        
        /// <summary>
        /// Получить предметы
        /// </summary>
        private void GetSubjects()
        {
            Subjects = LecturerProvider.GetSubjects();
            for(int i = 0;i < Subjects.Count;i++)
            {
                subjectComboBox.Items.Add(Subjects[i].Name);
            }

            if (Subjects.Count > 0)
            {
                subjectComboBox.SelectedIndex = 0;
            }
        }

        private void SubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            DisposeRatingPanel();

            groupComboBox.Items.Clear();

            Groups = SubjectProvider.GetGroups(Subjects[comboBox.SelectedIndex].Id);
            for (int i = 0; i < Groups.Count; i++)
            {
                groupComboBox.Items.Add(Groups[i].Name);
            }

            if(Groups.Count > 0)
            {
                groupComboBox.Enabled = true;

                groupComboBox.SelectedIndex = 0;
                Presenter.SetGroup(Groups[groupComboBox.SelectedIndex]);
            }
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            DisposeRatingPanel();

            Presenter.SetGroup(Groups[comboBox.SelectedIndex]);

            StudentResults = TaskResultProvider.GetResults(
                Groups[comboBox.SelectedIndex].Id,
                Subjects[subjectComboBox.SelectedIndex].Id);

            DisposeRatingPanel();

            Presenter.SetStudents(StudentResults);
        }

        private void FillRating()
        {
            for (int i = 0; i < StudentResults.Count; i++)
            {
                var item = new StudentResultItemView();
                item.Tag = StudentResults[i];
                //item.StateChanged += Item_StateChanged;
                item.Visible = true;

                item.SetStudentResult(StudentResults[i]);

                ratingPanel.Controls.Add(item);
            }

            ratingPanel.Visible = true;
        }

        private void DisposeRatingPanel()
        {
            ratingPanel.Visible = false;

            for (int i = 0;i < ratingPanel.Controls.Count;i++)
            {
                ratingPanel.Controls[i].Dispose();
            }
            ratingPanel.Controls.Clear();
        }
    }
}