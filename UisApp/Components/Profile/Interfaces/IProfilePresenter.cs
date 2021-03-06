﻿using UisApp.MVP.Core;

namespace UisApp.Components.Profile.Interfaces
{
    public interface IProfilePresenter : IPresenter<IProfilePresenter, IProfileView>
    {
        /// <summary>
        /// Установить фото
        /// </summary>
        /// <param name="fileName"></param>
        void SetPhoto(string fileName);
    }
}