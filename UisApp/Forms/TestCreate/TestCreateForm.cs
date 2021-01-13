using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UisApp.Helpers;

namespace UisApp.Forms.TestCreate
{
    public partial class TestCreateForm : Form
    {
        public TestCreateForm()
        {
            InitializeComponent();

            var view = new QuestionBlockView();
            questionPanel.Controls.Add(view);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpperBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormDragLogic.Move(Handle);
            }
        }
    }
}
