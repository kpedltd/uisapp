using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UisApp.API.Providers;
using UisApp.Helpers;
using UisApp.Models;

namespace UisApp.Forms.TaskCreate
{
    public partial class TaskCreateForm : Form
    {
        private TaskExtModel Model;

        private int SubjectId;

        private int GroupId;

        public TaskCreateForm(int subjectId, int groupId)
        {
            InitializeComponent();

            SubjectId = subjectId;
            GroupId = groupId;

            OkButton.Click += CreateOkButton_Click;
        }

        public TaskCreateForm(TaskExtModel model, int subjectId, int groupId)
        {
            InitializeComponent();

            SubjectId = subjectId;
            GroupId = groupId;
            Model = model;

            titleTextBox.Text = Model.Title;
            dateTimePicker.Value = Model.Deadline;
            descriptionTextBox.Text = Model.Description;

            OkButton.Click += EditOkButton_Click;
        }

        public event EventHandler TaskCreated;

        public event EventHandler TaskEdited;

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditOkButton_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                return;
            }

            string prevPath = Model.Photo;

            Model.Title = titleTextBox.Text;
            Model.Description = descriptionTextBox.Text;
            Model.Deadline = dateTimePicker.Value.Date;

            try
            {
                TaskProvider.Update(Model);

                if (picturePath.Text.Length != 0)
                {
                    Model = TaskProvider.UploadImage(Model.Id, picturePath.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            TaskEdited?.Invoke(Model, EventArgs.Empty);

            this.Close();
        }

        private void CreateOkButton_Click(object sender, EventArgs e)
        {
            if(!Validate())
            {
                return;
            }

            TaskExtModel task = new TaskExtModel();
            task.Title = titleTextBox.Text;
            task.Description = descriptionTextBox.Text;
            task.Begin = DateTime.Now;
            task.Deadline = dateTimePicker.Value.Date;

            try
            {
                task.Id = TaskProvider.CreateTask(
                    task, SubjectId, GroupId);

                if (picturePath.Text != "")
                {
                    TaskProvider.UploadImage(task.Id, picturePath.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            TaskCreated?.Invoke(task, EventArgs.Empty);

            this.Close();
        }

        private void ImageButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            picturePath.Text = openFileDialog.FileName;
        }

        private void UpperBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormDragLogic.Move(Handle);
            }
        }

        private bool Validate()
        {
            if (dateTimePicker.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("Срок выполнения не может быть меньше текущей даты");
                return false;
            }

            if (titleTextBox.Text == "")
            {
                MessageBox.Show("Укажите название");
                return false;
            }

            return true;
        }
    }
}