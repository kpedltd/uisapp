using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Components.StudentResult;
using UisApp.Components.StudentResult.Interfaces;

namespace UisApp.API.Providers
{
    static class TaskResultProvider
    {
        public static IList<StudentResultModel> GetResults(int groupId, int subjectId)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("groupId", groupId.ToString());
            param.Add("subjectId", subjectId.ToString());

            var api = ApiProviderBase.GetInstance();
            IApiResponse<IList<StudentResultModel>> response = api.GetRequest<IList<StudentResultModel>>(UriResource.task_result_new, param);

            return response.data;
        }

        public static void GradeStudent(int studentId, int taskId, int grade)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("studentId", studentId.ToString());
            param.Add("taskId", taskId.ToString());
            param.Add("grade", grade.ToString());

            var api = ApiProviderBase.GetInstance();
            api.PostRequest<object>(UriResource.grade_student, param);
        }
    }
}
