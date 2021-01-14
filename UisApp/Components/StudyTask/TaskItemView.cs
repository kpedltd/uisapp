using System;
using System.Windows.Forms;
using UisApp.Models;
using UisApp.Forms.ImageViewer;
using UisApp.Forms.TestCreate;
using UisApp.API.Providers;

namespace UisApp.Components.StudyTask
{
    public partial class TaskItemView : UserControl
    {
        public event EventHandler TaskDeleted;

        public event EventHandler TaskEdited;

        public TaskItemView()
        {
            InitializeComponent();

            toolTip.SetToolTip(this.editTaskButton, "Изменить задачу");
            toolTip.SetToolTip(this.deleteTaskButton, "Удалить задачу");
            toolTip.SetToolTip(this.showImageButton, "Показать изображение");
            toolTip.SetToolTip(this.addTestButton, "Добавить тест");
        }

        public void SetModel(TaskExtModel model)
        {
            titleLabel.Text = model.Title;
            dateLabel.Text = model.Deadline.ToString("dd MM yyyy");

            if(model.Photo == null)
            {
                showImageButton.Enabled = false;
                showImageButton.Visible = false;
            }
        }

        private void ShowImageButton_Click(object sender, EventArgs e)
        {
            var task = this.Tag as TaskExtModel;

            ImageViewer viewer = new ImageViewer();
            viewer.SetUrl(task.Photo);

            viewer.Show();
        }

        private void DeleteTaskButton_Click(object sender, EventArgs e)
        {
            TaskDeleted?.Invoke(this.Tag, EventArgs.Empty);
        }

        private void EditTaskButton_Click(object sender, EventArgs e)
        {
            TaskEdited?.Invoke(this.Tag, EventArgs.Empty);
        }

        private void AddTestButton_Click(object sender, EventArgs e)
        {
            TestCreateForm form = new TestCreateForm();
            form.TestCreated += Form_TestCreated;

            form.Show();
        }

        private void Form_TestCreated(object sender, EventArgs e)
        {
            TaskProvider.AddTest(
                this.Tag as TaskExtModel,
                sender as TestModel);
        }
    }
}