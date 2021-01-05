using System;
using System.Windows.Forms;
using UisApp.Forms;
using UisApp.Helpers;

namespace UisApp
{
    public partial class MainForm : Form
    {
        bool Hidden;
        int PanelWidth;

        public MainForm()
        {
            InitializeComponent();

            Hidden = false;
            PanelWidth = itemsPanel.Width;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {

        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void UpperBorder_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormDragLogic.Move(Handle);
            }
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                itemsPanel.Width = itemsPanel.Width + 5;
                if (itemsPanel.Width >= PanelWidth)
                {
                    timer.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                itemsPanel.Width = itemsPanel.Width - 5;
                if (itemsPanel.Width <= 63)
                {
                    timer.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
