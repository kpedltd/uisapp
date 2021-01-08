using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UisApp.Components
{
    interface IUisComponent
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
