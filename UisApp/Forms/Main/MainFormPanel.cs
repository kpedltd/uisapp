using System;
using System.Windows.Forms;

namespace UisApp
{
    public partial class MainForm : Form
    {
        private bool Hidden;
        private int PanelWidth;

        private void InitializeItemsPanel()
        {
            Hidden = false;
            PanelWidth = itemsPanel.Width;
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
    }
}