using System;
using System.Collections.Generic;
using UisApp.Models;
using UisApp.API.Providers;
using UisApp.Components.StudentResult.Interfaces;

namespace UisApp.Components.StudentResult
{
    public class ResultModel : IResultModel
    {
        /// <summary>
        /// Группа
        /// </summary>
        public GroupExtModel Group
        {
            get;
            private set;
        }

        /// <summary>
        /// Студенты
        /// </summary>
        public IList<StudentResultModel> Students
        {
            get;
            private set;
        }


        /// <summary>
        /// Событие обновления студентов
        /// </summary>
        public event EventHandler StudentsUpdated;

        /// <summary>
        /// Установить группу
        /// </summary>
        /// <param name="model"></param>
        public void SetGroup(GroupExtModel model)
        {
            Group = model;
        }

        /// <summary>
        /// Установить студентов
        /// </summary>
        /// <param name="students"></param>
        public void SetStudents(IList<StudentResultModel> students)
        {
            Students = students;

            StudentsUpdated?.Invoke(this, EventArgs.Empty);
        }
    }
}