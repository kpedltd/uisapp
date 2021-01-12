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
using UisApp.Models;

namespace UisApp.Forms.TaskCreate
{
    public partial class TaskCreateForm : Form
    {
        private int SubjectId;

        private int GroupId;

        public TaskCreateForm(int subjectId, int groupId)
        {
            InitializeComponent();

            SubjectId = subjectId;
            GroupId = groupId;
        }

        public event EventHandler TaskCreated;

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if(dateTimePicker.Value.Date <= DateTime.Now)
            {
                MessageBox.Show("Срок выполнения не может быть меньше текущей даты");
                return;
            }

            if(titleTextBox.Text == "")
            {
                MessageBox.Show("Укажите название");
                return;
            }

            TaskExtModel task = new TaskExtModel();
            task.Title = titleTextBox.Text;
            task.Descirption = descriptionTextBox.Text;
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
    }
}
