using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.Profile.Interfaces;
using UisApp.MVP.Core;
using UisApp.MVP.Support;

namespace UisApp.Components.Profile
{
    class ProfilePresenter : PresenterBase<IProfilePresenter, IProfileView>, IProfilePresenter
    {
        IProfileModel Model;

        public ProfilePresenter(IProfileModel model)
        {
            this.Model = model;

            this.Model.Updated += Model_Updated;
        }

        protected override IProfilePresenter GetPresenterEndpoint()
        {
            return this;
        }

        protected override void RefreshView(IProfileView viewInstance)
        {
            if (viewInstance == null)
            {
                throw new ArgumentNullException(nameof(viewInstance));
            }

            viewInstance.Update(Model);
        }

        private void Model_Updated(object sender, EventArgs e)
        {
            Model = sender as IProfileModel;
            lock (views)
            {
                views
                .ToList()
                .ForEach((x) =>
                {
                    x.Update(Model);
                });
            }
        }
    }
}
