using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.Models;

namespace UisApp.Components.Profile.Interfaces
{
    interface IProfileModel : ILecturerModel
    {
        /// <summary>
        /// Событие обновления данных
        /// </summary>
        event EventHandler Updated;
    }
}
