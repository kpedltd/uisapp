using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Components.Analytic;

namespace UisApp.API.Providers
{
    static class AnalyticProvider
    {
        public static AnalyticModel Get(int subjectId, int groupId)
        {
            NameValueCollection nvc = new NameValueCollection();
            nvc.Add("subjectId", subjectId.ToString());
            nvc.Add("groupId", groupId.ToString());

            var api = ApiProviderBase.GetInstance();
            IApiResponse<AnalyticModel> response =
                api.GetRequest<AnalyticModel> (UriResource.analytic_charts, nvc);

            var result = response.data as AnalyticModel;
            return result;
        }
    }
}
