using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UisApp.Models;
using UisApp.Components.StudyTask.Interfaces;
using UisApp.API.Providers;
using UisApp.Forms.TaskCreate;

namespace UisApp.Components.StudyTask
{
    public partial class StudyTaskView : UserControl, IUisComponent, IStudyTaskView
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
        /// Задачи
        /// </summary>
        private IList<TaskExtModel> Tasks;

        /// <summary>
        /// Презентер
        /// </summary>
        public IStudyTaskPresenter Presenter
        {
            get;
            set;
        }

        public StudyTaskView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Привязать презентер
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="requiresInitialState"></param>
        public void AttachToPresenter(IStudyTaskPresenter presenter, bool requiresInitialState)
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
        public void Update(IStudyTaskModel model)
        {
            if (model.Group.Id == Groups[groupComboBox.SelectedIndex].Id &&
                model.Subject.Id == Subjects[subjectComboBox.SelectedIndex].Id)
            {
                Tasks = model.Tasks;

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
            for (int i = 0; i < Subjects.Count; i++)
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

            addTaskButton.Enabled = false;
            groupComboBox.Items.Clear();

            Presenter.SetSubject(Subjects[comboBox.SelectedIndex]);

            Groups = SubjectProvider.GetGroups(Subjects[comboBox.SelectedIndex].Id);
            for (int i = 0; i < Groups.Count; i++)
            {
                groupComboBox.Items.Add(Groups[i].Name);
            }

            if (Groups.Count > 0)
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

            Tasks = TaskProvider.Get(
                Subjects[subjectComboBox.SelectedIndex].Id,
                Groups[comboBox.SelectedIndex].Id);

            DisposeRatingPanel();

            Presenter.SetTasks(Tasks);

            addTaskButton.Enabled = true;
        }

        private void FillRating()
        {
            for (int i = 0; i < Tasks.Count; i++)
            {
                var item = new TaskItemView();
                item.Tag = Tasks[i];
                item.Visible = true;
                item.TaskDeleted += Item_TaskDeleted;
                item.TaskEdited += Item_TaskEdited;

                item.SetModel(Tasks[i]);

                taskPanel.Controls.Add(item);
            }

            taskPanel.Visible = true;
        }

        private void DisposeRatingPanel()
        {
            taskPanel.Visible = false;

            for (int i = 0; i < taskPanel.Controls.Count; i++)
            {
                taskPanel.Controls[i].Dispose();
            }
            taskPanel.Controls.Clear();
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            TaskCreateForm form = new TaskCreateForm(
                Subjects[subjectComboBox.SelectedIndex].Id,
                Groups[groupComboBox.SelectedIndex].Id);
            form.TaskCreated += Form_TaskCreated;

            form.Show();
        }

        private void Item_TaskEdited(object sender, EventArgs e)
        {
            TaskCreateForm form = new TaskCreateForm(
                sender as TaskExtModel,
                Subjects[subjectComboBox.SelectedIndex].Id,
                Groups[groupComboBox.SelectedIndex].Id);
            form.TaskEdited += Form_TaskEdited; ;

            form.Show();
        }

        private void Item_TaskDeleted(object sender, EventArgs e)
        {
            Presenter.DeleteTask(sender as TaskExtModel);
        }

        private void Form_TaskCreated(object sender, EventArgs e)
        {
            Presenter.AddTask(sender as TaskExtModel);
        }

        private void Form_TaskEdited(object sender, EventArgs e)
        {
            Presenter.EditTask(sender as TaskExtModel);
        }
    }
}
