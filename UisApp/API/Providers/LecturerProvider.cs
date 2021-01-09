using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Components.Profile;
using UisApp.Components.Profile.Interfaces;

namespace UisApp.API.Providers
{
    static class LecturerProvider
    {
        public static IProfileModel GetMe()
        {
            var api = ApiProviderBase.GetInstance();
            IApiResponse<ProfileModel> response = api.GetRequest<ProfileModel>(UriResource.getme);

            var result = response.data as ProfileModel;
            return result;
        }
    }
}
