using System.Windows.Forms;

namespace UisApp.Components
{
    internal interface IUisComponent
    {
        DockStyle Dock
        {
            get;
            set;
        }

        Control Parent
        {
            get;
            set;
        }

        void BringToFront();

        void Show();

        void Hide();
    }
}