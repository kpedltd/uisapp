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
        private QuestionBlockView CurrentQuestionView;

        public TestCreateForm()
        {
            InitializeComponent();

            var view = new QuestionBlockView();
            questionPanel.Controls.Add(view);

            treeView.Nodes.Add("Вопрос номер 1");
            treeView.Nodes[0].Tag = view;
            view.Tag = treeView.Nodes[0];

            view.SetTitle("Вопрос номер 1");

            CurrentQuestionView = view;
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

        private void AddQuestuion_Click(object sender, EventArgs e)
        {
            var view = new QuestionBlockView();
            questionPanel.Controls.Add(view);

            treeView.Nodes.Add("Новый вопрос");
            treeView.Nodes[treeView.Nodes.Count - 1].Tag = view;
            view.Tag = treeView.Nodes[treeView.Nodes.Count - 1];
            view.Visible = false;
        }

        private void TreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CurrentQuestionView?.Hide();

            CurrentQuestionView = treeView.SelectedNode.Tag as QuestionBlockView;
            CurrentQuestionView.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if(treeView.Nodes.Count > 1)
            {
                treeView.Nodes.Remove(treeView.SelectedNode);
            }
        }
    }
}
