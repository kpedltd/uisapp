using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Components.Attendance;
using UisApp.Models;

namespace UisApp.API.Providers
{
    static class AttendanceProvider
    {
        /// <summary>
        /// Получить посещаемость
        /// </summary>
        /// <param name="scheduleId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static IList<StudentAttendanceModel> GetAttendance(int scheduleId, DateTime date)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("scheduleId", scheduleId.ToString());
            nvc.Add("date", date.ToString("yyyy-MM-dd"));

            var api = ApiProviderBase.GetInstance();
            IApiResponse<IList<StudentAttendanceModel>> response = 
                api.GetRequest<IList<StudentAttendanceModel>>(UriResource.student_attendance, nvc);

            var result = response.data as IList<StudentAttendanceModel>;
            return result;
        }

        /// <summary>
        /// Создать записи посещаемости
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="scheduleId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public static IList<StudentAttendanceModel> CreateEntries(int groupId, int scheduleId, DateTime date)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("groupId", groupId.ToString());
            nvc.Add("scheduleId", scheduleId.ToString());
            nvc.Add("date", date.ToString("yyyy-MM-dd"));

            var api = ApiProviderBase.GetInstance();
            IApiResponse<IList<StudentAttendanceModel>> response = 
                api.PostRequest<IList<StudentAttendanceModel>>(UriResource.create_attendance_entries, nvc);
            var result = response.data as IList<StudentAttendanceModel>;
            return result;
        }

        /// <summary>
        /// Установить отметку о посещении занятия студентом
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="scheduleId"></param>
        /// <param name="date"></param>
        /// <param name="state"></param>
        public static void ChangeState(int studentId, int scheduleId, DateTime date, AttendanceLogState state)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("studentId", studentId.ToString());
            nvc.Add("scheduleId", scheduleId.ToString());
            nvc.Add("date", date.ToString("yyyy-MM-dd"));
            nvc.Add("state", state.ToString());

            var api = ApiProviderBase.GetInstance();
            IApiResponse<object> response = api.PostRequest<object>(UriResource.student_check, nvc);
        }
    }
}