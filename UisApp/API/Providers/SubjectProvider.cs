using System.Collections.Generic;
using System.Collections.Specialized;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Models;

namespace UisApp.API.Providers
{
    internal static class SubjectProvider
    {
        public static IList<GroupExtModel> GetGroups(int subjectId)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("subjectId", subjectId.ToString());

            var api = ApiProviderBase.GetInstance();
            IApiResponse<IList<GroupExtModel>> response = api.GetRequest<IList<GroupExtModel>>
                (UriResource.subject_groups, nvc);

            var result = response.data as IList<GroupExtModel>;
            return result;
        }
    }
}