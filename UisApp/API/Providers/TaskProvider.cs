using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Forms.TestCreate;
using UisApp.Models;

namespace UisApp.API.Providers
{
    static class TaskProvider
    {
        public static TaskExtModel UploadImage(int taskId, string path)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("photo_ext", Path.GetExtension(path));
            param.Add("taskId", taskId.ToString());

            var api = ApiProviderBase.GetInstance();
            api.SendFile(UriResource.task_photo, param, File.ReadAllBytes(path));

            return GetById(taskId);
        }

        public static int CreateTask(TaskExtModel model, int subjectId, int groupId)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("title", model.Title);
            param.Add("description", model.Description);
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

        public static TaskExtModel GetById(int taskId)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("id", taskId.ToString());

            var api = ApiProviderBase.GetInstance();
            IApiResponse<TaskExtModel> response = api.GetRequest<TaskExtModel>(UriResource.task_get_by_id, param);

            return response.data;
        }

        public static void Delete(int taskId)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("taskId", taskId.ToString());

            var api = ApiProviderBase.GetInstance();
            api.PostRequest<object>(UriResource.task_delete, param);
        }

        public static void Update(TaskExtModel model)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("taskId", model.Id.ToString());
            param.Add("title", model.Title.ToString());
            param.Add("description", model.Description.ToString());
            param.Add("deadline", model.Deadline.ToString("yyyy-MM-dd"));

            if(model.Photo != null)
            {
                param.Add("photo", model.Photo.ToString());
            }
           
            var api = ApiProviderBase.GetInstance();
            api.PostRequest<object>(UriResource.task_update, param);
        }

        public static void AddTest(TaskExtModel task, TestModel test)
        {
            string json = JsonConvert.SerializeObject(test);

            NameValueCollection param = new NameValueCollection();
            param.Add("taskId", task.Id.ToString());
            param.Add("test", json);

            var api = ApiProviderBase.GetInstance();
            api.PostRequest<object>(UriResource.task_set_test, param);
        }
    }
}
