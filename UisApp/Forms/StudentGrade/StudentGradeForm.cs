using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UisApp.Components.StudentResult;
using UisApp.Helpers;

namespace UisApp.Forms.StudentGradeForm
{
    public partial class StudentGradeForm : Form
    {
        public event EventHandler StudentGraded;

        private StudentResultModel Model;

        public StudentGradeForm()
        {
            InitializeComponent();
        }

        public void SetModel(StudentResultModel model)
        {
            Model = model;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Model.Comment = commentBox.Text;
            Model.Grade = (int)gradeNum.Value;

            StudentGraded?.Invoke(Model, EventArgs.Empty);

            Close();
        }

        private void UpperBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormDragLogic.Move(Handle);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CanceldButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
