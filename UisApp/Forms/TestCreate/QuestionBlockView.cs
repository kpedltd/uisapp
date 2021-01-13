using System;
using System.Windows.Forms;

namespace UisApp.Forms.TestCreate
{
    public partial class QuestionBlockView : UserControl
    {
        private int CurrentChecked;

        public QuestionBlockView()
        {
            InitializeComponent();

            var view = new AnswerBlockView();

            CurrentChecked = -1;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(answersPanel.Controls.Count <= 8)
            {
                var view = new AnswerBlockView();
                answersPanel.Controls.Add(view);
                answersPanel.Controls.SetChildIndex(view, answersPanel.Controls.Count - 2);

                view.Checked += View_Checked;
            }
        }

        private void View_Checked(object sender, EventArgs e)
        {
            for(int i = 0;i < answersPanel.Controls.Count - 1;i++)
            {
                AnswerBlockView view = answersPanel.Controls[i] as AnswerBlockView;
                if (view.GetRadioButton() != sender as RadioButton)
                {
                    view.UncheckRadioButton();
                }
                else
                {
                    CurrentChecked = i;
                }
            }
        }

        public void SetTitle(string title)
        {
            titleTextBox.Text = title;
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            var node = this.Tag as TreeNode;
            node.Text = titleTextBox.Text;
        }
    }
}
