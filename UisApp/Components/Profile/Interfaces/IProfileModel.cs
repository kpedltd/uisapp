using System;
using UisApp.Models;

namespace UisApp.Components.Profile.Interfaces
{
    internal interface IProfileModel : ILecturerModel
    {
        /// <summary>
        /// Событие обновления данных
        /// </summary>
        event EventHandler Updated;
    }
}