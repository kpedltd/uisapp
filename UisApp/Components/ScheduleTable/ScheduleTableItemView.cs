using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UisApp.Components.ScheduleTable
{
    public partial class ScheduleTableItemView : UserControl
    {
        public ScheduleTableItemView()
        {
            InitializeComponent();
            Release();
        }

        /// <summary>
        /// Принять в существующее расписание
        /// </summary>
        public void Take()
        {
            this.BackColor = Color.FromArgb(33, 33, 33);
        }

        /// <summary>
        /// Освободить от содержания записи
        /// </summary>
        public void Release()
        {
            this.BackColor = Color.DarkSlateGray;
        }
    }
}
