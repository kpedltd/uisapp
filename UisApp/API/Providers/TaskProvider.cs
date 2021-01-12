using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Models;

namespace UisApp.API.Providers
{
    static class TaskProvider
    {
        public static void UploadImage(int taskId, string path)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("photo_ext", Path.GetExtension(path));
            param.Add("taskId", taskId.ToString());

            var api = ApiProviderBase.GetInstance();
            api.SendFile(UriResource.task_photo, param, File.ReadAllBytes(path));
        }

        public static int CreateTask(TaskExtModel model, int subjectId, int groupId)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("title", model.Title);
            param.Add("descirption", model.Descirption);
            param.Add("begin", model.Begin.ToString("yyyy-MM-dd"));
            param.Add("deadline", model.Deadline.ToString("yyyy-MM-dd"));
            param.Add("subjectId", subjectId.ToString());
            param.Add("groupId", groupId.ToString());

            var api = ApiProviderBase.GetInstance();
            IApiResponse<int> response = api.PostRequest<int>(UriResource.task_create, param);

            return response.data;
        }

        public static IList<TaskExtModel> Get(int subjectId, int groupId)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("subjectId", subjectId.ToString());
            param.Add("groupId", groupId.ToString());

            var api = ApiProviderBase.GetInstance();
            IApiResponse<IList<TaskExtModel>> response = api.GetRequest<IList<TaskExtModel>>(UriResource.task_get, param);

            return response.data;
        }
    }
}
