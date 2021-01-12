using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UisApp.API.Providers;
using UisApp.Models;
using UisApp.Components.Attendance;
using UisApp.Components.Rating.Interfaces;

namespace UisApp.Components.Rating
{
    public partial class RatingView : UserControl, IUisComponent, IRatingView
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
        public IList<StudentRatingModel> StudentsRating
        {
            get;
            set;
        }

        /// <summary>
        /// Презентер
        /// </summary>
        public IRatingPresenter Presenter
        {
            get;
            set;
        }

        public RatingView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Привязать презентер
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="requiresInitialState"></param>
        public void AttachToPresenter(IRatingPresenter presenter, bool requiresInitialState)
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
        public void Update(IRatingModel model)
        {
            if(model.Group.Id == Groups[groupComboBox.SelectedIndex].Id &&
                model.Subject.Id == Subjects[subjectComboBox.SelectedIndex].Id)
            {
                StudentsRating = model.Students;

                DisposeRatingPanel();
                FillRating();
            }
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
                Presenter.SetSubject(Subjects[subjectComboBox.SelectedIndex]);
            }
        }

        private void SubjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            DisposeRatingPanel();

            groupComboBox.Items.Clear();

            Presenter.SetSubject(Subjects[comboBox.SelectedIndex]);

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
        }

        private void FillRating()
        {
            for (int i = 0; i < StudentsRating.Count; i++)
            {
                var item = new RatingItemView();
                item.Tag = StudentsRating[i];
                item.StateChanged += Item_StateChanged;
                item.Visible = true;

                item.SetStudentRating(StudentsRating[i]);

                ratingPanel.Controls.Add(item);
            }
        }

        private void DisposeRatingPanel()
        {
            for(int i = 0;i < ratingPanel.Controls.Count;i++)
            {
                ratingPanel.Controls[i].Dispose();
            }
            ratingPanel.Controls.Clear();
        }

        private void Item_StateChanged(object sender, EventArgs e)
        {
            Presenter.StudentSetGrade(sender as StudentRatingModel);
        }
    }
}