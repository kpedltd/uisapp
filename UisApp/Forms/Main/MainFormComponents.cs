using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UisApp.API.Providers;
using UisApp.Components;
using UisApp.Components.Profile;

namespace UisApp
{
    public partial class MainForm : Form
    {
        private void InitializeInternalComponents()
        {
            InitializeProfile();
        }

        private void InitializeProfile()
        {
            var profileModel = LecturerProvider.GetMe();
            ProfilePresenter presenter = new ProfilePresenter(profileModel);

            var profileView = new ProfileView();
            compContainer.AttachView(profileView);

            profileView.AttachToPresenter(presenter, true);

            profileButton.Tag = profileView;
        }
    }
}
