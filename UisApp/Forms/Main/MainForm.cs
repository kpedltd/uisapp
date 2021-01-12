using System;
using System.Windows.Forms;
using UisApp.API.Providers;
using UisApp.Components;
using UisApp.Components.Profile;
using UisApp.Forms;
using UisApp.Helpers;

namespace UisApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeItemsPanel();
            InitializeInternalComponents();

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var targerView = (IUisComponent)button.Tag;

            compContainer.SwitchTo(targerView);
        }

        private void ScheduleButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var targerView = (IUisComponent)button.Tag;

            compContainer.SwitchTo(targerView);
        }

        private void AttendanceButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var targerView = (IUisComponent)button.Tag;

            compContainer.SwitchTo(targerView);
        }


        private void ratingButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var targerView = (IUisComponent)button.Tag;

            compContainer.SwitchTo(targerView);
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            timer.Interval = 1;
            timer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            compContainer.SwitchFirst();
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

        

        protected override void OnPaint(PaintEventArgs e)
        {
            FormSizeableLogic.OnPaintLogic(this, e);
        }

        protected override void WndProc(ref Message m)
        {
            FormSizeableLogic.WndProcLogic(this, ref m);
            base.WndProc(ref m);
        }
    }
}