using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Components.Rating;

namespace UisApp.API.Providers
{
    static class RatingProvider
    {
        /// <summary>
        /// Получить рейтинг группы
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="subjectId"></param>
        /// <returns></returns>
        public static IList<StudentRatingModel> GetRating(int groupId, int subjectId)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("groupId", groupId.ToString());
            nvc.Add("subjectId", subjectId.ToString());

            var api = ApiProviderBase.GetInstance();
            IApiResponse<IList<StudentRatingModel>> response =
                api.GetRequest<IList<StudentRatingModel>>(UriResource.student_rating, nvc);

            var result = response.data as IList<StudentRatingModel>;
            return result;
        }

        /// <summary>
        /// Создать записи рейтинга для группы
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="subjectId"></param>
        /// <returns></returns>
        public static IList<StudentRatingModel> CreateEntries(int groupId, int subjectId)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("groupId", groupId.ToString());
            nvc.Add("subjectId", subjectId.ToString());

            var api = ApiProviderBase.GetInstance();
            IApiResponse<IList<StudentRatingModel>> response =
                api.PostRequest<IList<StudentRatingModel>>(UriResource.create_rating_entries, nvc);
            var result = response.data as IList<StudentRatingModel>;
            return result;
        }

        /// <summary>
        /// Оценить студента по предмету
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="subjectId"></param>
        /// <param name="grade"></param>
        public static void RateStudent(int studentId, int subjectId, int grade)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("studentId", studentId.ToString());
            nvc.Add("subjectId", subjectId.ToString());
            nvc.Add("grade", grade.ToString());

            var api = ApiProviderBase.GetInstance();
            IApiResponse<object> response = api.PostRequest<object>(UriResource.student_rate, nvc);
        }
    }
}
