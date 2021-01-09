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

        /// <summary>
        /// Установить фото
        /// </summary>
        /// <param name="fileName"></param>
        void SetPhoto(string fileName);
    }
}