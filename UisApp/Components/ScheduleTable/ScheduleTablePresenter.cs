using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Components.ScheduleTable.Interfaces;
using UisApp.MVP.Support;

namespace UisApp.Components.ScheduleTable
{
    public class ScheduleTablePresenter : PresenterBase<IScheduleTablePresenter, IScheduleTableView>, IScheduleTablePresenter
    {
        IScheduleTableModel Model;

        protected override IScheduleTablePresenter GetPresenterEndpoint()
        {
            return this;
        }

        protected override void RefreshView(IScheduleTableView viewInstance)
        {
            if (viewInstance == null)
            {
                throw new ArgumentNullException(nameof(viewInstance));
            }

            viewInstance.Update(Model);
        }

        public ScheduleTablePresenter(IScheduleTableModel model)
        {
            Model = model;

            Model.Updated += Model_Updated;
        }

        private void Model_Updated(object sender, EventArgs e)
        {
            Model = sender as IScheduleTableModel;
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
