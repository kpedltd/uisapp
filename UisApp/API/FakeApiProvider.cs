using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Components.Profile;
using UisApp.Components.ScheduleTable;
using UisApp.Models;
using UisApp.MVP;

namespace UisApp.API
{
    internal class FakeApiProvider : ApiProviderBase, IApiProvider
    {
        /// <summary>
        /// Получить экземпляр провайдера
        /// </summary>
        /// <returns></returns>
        public static IApiProvider MakeInstance(string sHost)
        {
            if (_instance == null)
            {
                _instance = new FakeApiProvider(sHost);
            }

            return _instance;
        }

        public string Host
        {
            get;
            set;
        }

        private FakeApiProvider(string sHost)
        {
            Host = sHost;
        }

        private static Dictionary<string, object> FakeResponses;

        static FakeApiProvider()
        {
            FakeResponses = new Dictionary<string, object>();

            FakeResponses.Add(UriResource.getme, CreateFakeProfile());
            FakeResponses.Add(UriResource.lecturer_schedule, CreateFakeSchedule());
            FakeResponses.Add(UriResource.lecturer_subjects, new List<SubjectExtModel>());
        }

        public string sToken => "fake";

        public void Disconnect()
        {
            return;
        }

        public IApiResponse<IModel> Connect(string login, string password)
        {
            ApiResponse<IModel> apiResponse = new ApiResponse<IModel>();
            apiResponse.status = true;

            return apiResponse;
        }

        public IApiResponse<T> GetRequest<T>(string uri, NameValueCollection nvc)
        {
            IApiResponse<T> response = new ApiResponse<T>();
            if (FakeResponses.ContainsKey(uri))
            {
                response.data = (T)FakeResponses[uri];
            }
            else
            {
                throw new NotImplementedException();
            }

            return response;
        }

        public IApiResponse<T> PostRequest<T>(string uri, NameValueCollection nvc)
        {
            IApiResponse<T> response = new ApiResponse<T>();
            if (FakeResponses.ContainsKey(uri))
            {
                response.data = (T)FakeResponses[uri];
            }
            else
            {
                throw new NotImplementedException();
            }

            return response;
        }

        private static IModel CreateFakeProfile()
        {
            ProfileModel profile = new ProfileModel();
            profile.FirstName = "Дмитрий";
            profile.LastName = "Федеров";
            profile.Patronymic = "Алексеевич";
            profile.Photo = null;
            profile.DateOfBirth = new DateTime(1966, 11, 12);
            profile.Biography = "Родился в Мещерске";
            profile.DepartmentName = "МОиПЭВМ";
            profile.FacultyName = "ФВТ";

            return profile;
        }

        private static IModel CreateFakeSchedule()
        {
            ScheduleTableModel schedule = new ScheduleTableModel();
            schedule.Records = new List<ScheduleDayModel>();
            for (int i = 0; i < 6; i++)
            {
                ScheduleDayModel day = new ScheduleDayModel();
                day.DayOfWeek = ((ScheduleDayOfWeek)i);
                day.Records = new List<ScheduleRecordModel>();

                ScheduleRecordModel scheduleRecord = new ScheduleRecordModel();
                scheduleRecord.GroupName = "17ВП1";
                scheduleRecord.SubjectName = "Программирование";
                scheduleRecord.Time = DateTime.ParseExact("08:00", "HH:mm", null);
                scheduleRecord.Location = "7б кабинет 201";

                day.Records.Add(scheduleRecord);

                schedule.Records.Add(day);
            }

            return schedule;
        }

        public void SendFile(string uri, NameValueCollection nvc, byte[] paramFileBytes)
        {
            throw new NotImplementedException();
        }
    }
}