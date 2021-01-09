using System;
using UisApp.Components.Profile.Interfaces;

namespace UisApp.Components.Profile
{
    internal class ProfileModel : IProfileModel
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName
        {
            get;
            set;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Patronymic
        {
            get;
            set;
        }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime DateOfBirth
        {
            get;
            set;
        }

        /// <summary>
        /// Ссылка на фото
        /// </summary>
        public string Photo
        {
            get;
            set;
        }

        /// <summary>
        /// Биография
        /// </summary>
        public string Biography
        {
            get;
            set;
        }

        /// <summary>
        /// Имя кафедры
        /// </summary>
        public string DepartmentName
        {
            get;
            set;
        }

        /// <summary>
        /// Имя факультета
        /// </summary>
        public string FacultyName
        {
            get;
            set;
        }

        public ProfileModel()
        {
        }

        /// <summary>
        /// Событие обновления модели
        /// </summary>
        public event EventHandler Updated;
    }
}