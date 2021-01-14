using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UisApp.Forms.TestCreate
{
    public partial class AnswerBlockView : UserControl
    {
        public event EventHandler Checked;

        public AnswerBlockView()
        {
            InitializeComponent();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Parent.Controls.Remove(this);
        }

        public void UncheckRadioButton()
        {
            radioButton.Checked = false;
        }

        public RadioButton GetRadioButton()
        {
            return radioButton;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = sender as RadioButton;
            if(radioButton.Checked)
            {
                Checked?.Invoke(sender, e);
            }
        }

        public string GetAnswer()
        {
            return answerTextBox.Text;
        }
    }
}
