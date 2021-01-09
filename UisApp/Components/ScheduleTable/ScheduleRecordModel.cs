using System;
using UisApp.Components.ScheduleTable.Interfaces;

namespace UisApp.Components.ScheduleTable
{
    public class ScheduleRecordModel : IScheduleRecordModel
    {
        /// <summary>
        /// Время
        /// </summary>
        public DateTime Time
        {
            get;
            set;
        }

        /// <summary>
        /// Место проведения
        /// </summary>
        public string Location
        {
            get;
            set;
        }

        /// <summary>
        /// Предмет
        /// </summary>
        public string SubjectName
        {
            get;
            set;
        }

        /// <summary>
        /// Имя группы
        /// </summary>
        public string GroupName
        {
            get;
            set;
        }
    }
}