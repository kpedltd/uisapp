using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var api = ApiProviderBase.GetInstance();
            IApiResponse<IList<GroupExtModel>> response = api.GetRequest<IList<GroupExtModel>>(UriResource.subject_groups);

            var result = response.data as IList<GroupExtModel>;
            return result;
        }
    }
}
