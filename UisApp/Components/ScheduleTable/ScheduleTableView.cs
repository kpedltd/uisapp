using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UisApp.Components.ScheduleTable.Interfaces;
using UisApp.Models;

namespace UisApp.Components.ScheduleTable
{
    public partial class ScheduleTableView : UserControl, IUisComponent, IScheduleTableView
    {
        private IList<ScheduleDayModel> __records;

        public ScheduleTableView()
        {
            InitializeComponent();

            DayColumns = new Dictionary<ScheduleDayOfWeek, FlowLayoutPanel>();

            DayColumns.Add(ScheduleDayOfWeek.Monday, MondayColumn);
            DayColumns.Add(ScheduleDayOfWeek.Tuesday, TuesdayColumn);
            DayColumns.Add(ScheduleDayOfWeek.Wednesday, WednesdayColumn);
            DayColumns.Add(ScheduleDayOfWeek.Thursday, ThursdayColumn);
            DayColumns.Add(ScheduleDayOfWeek.Friday, FridayColumn);
            DayColumns.Add(ScheduleDayOfWeek.Saturday, SaturdayColumn);
        }

        static ScheduleTableView()
        {
            TimeMapping = new Dictionary<DateTime, int>();

            string TimeFormat = "HH:mm";

            TimeMapping.Add(DateTime.ParseExact("08:00", TimeFormat, null), 0);
            TimeMapping.Add(DateTime.ParseExact("09:50", TimeFormat, null), 1);
            TimeMapping.Add(DateTime.ParseExact("11:40", TimeFormat, null), 2);
            TimeMapping.Add(DateTime.ParseExact("13:45", TimeFormat, null), 3);
            TimeMapping.Add(DateTime.ParseExact("15:35", TimeFormat, null), 4);
            TimeMapping.Add(DateTime.ParseExact("17:25", TimeFormat, null), 5);
        }

        /// <summary>
        /// Презентер
        /// </summary>
        public IScheduleTablePresenter Presenter
        {
            get;
            set;
        }

        /// <summary>
        /// Записи расписания
        /// </summary>
        public IList<ScheduleDayModel> Records
        {
            get
            {
                return __records;
            }
            set
            {
                __records = value;
                RefreshTable();
            }
        }

        /// <summary>
        /// Привязать презентер
        /// </summary>
        /// <param name="presenter"></param>
        /// <param name="requiresInitialState"></param>
        public void AttachToPresenter(IScheduleTablePresenter presenter, bool requiresInitialState)
        {
            if (presenter == null)
            {
                throw new ArgumentNullException(nameof(presenter));
            }

            DetatchFromPresenter();

            Presenter = presenter;
            Presenter.ConnectView(this, requiresInitialState);
        }

        /// <summary>
        /// Отвязать презентер
        /// </summary>
        public void DetatchFromPresenter()
        {
            lock (this)
            {
                if (Presenter != null)
                {
                    Presenter.DisconnectView(this);
                    Presenter = null;
                }
            }
        }

        /// <summary>
        /// Обновить представление по модели
        /// </summary>
        /// <param name="scheduleRecords"></param>
        public void Update(IScheduleTableModel scheduleTable)
        {
            Records = scheduleTable.Records;
        }

        /// <summary>
        /// Столбцы по дням недели
        /// </summary>
        private Dictionary<ScheduleDayOfWeek, FlowLayoutPanel> DayColumns;

        /// <summary>
        /// Отображение времени в порядок
        /// </summary>
        private static Dictionary<DateTime, int> TimeMapping;

        /// <summary>
        /// Обновить таблицу представления
        /// </summary>
        private void RefreshTable()
        {
            foreach (KeyValuePair<ScheduleDayOfWeek, FlowLayoutPanel> entry in DayColumns)
            {
                entry.Value.Controls.Clear();

                for (int i = 0; i < TimeMapping.Count; i++)
                {
                    entry.Value.Controls.Add(new ScheduleTableItemView());
                }
            }

            for (int i = 0; i < __records.Count; i++)
            {
                var currentColumn = DayColumns[__records[i].DayOfWeek];
                for (int j = 0; j < __records[i].Records.Count; j++)
                {
                    ScheduleTableItemView item = currentColumn.Controls[TimeMapping[__records[i].Records[j].Time]] as ScheduleTableItemView;

                    item.groupNameLabel.Text = __records[i].Records[j].GroupName;
                    item.subjectNameLabel.Text = __records[i].Records[j].SubjectName;
                    item.locationLabel.Text = __records[i].Records[j].Location;

                    item.Take();
                }
            }
        }
    }
}