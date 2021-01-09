using System.Collections.Specialized;
using System.IO;
using UisApp.API.Core;
using UisApp.API.Interfaces;
using UisApp.API.Resources;
using UisApp.Components.Profile;
using UisApp.Components.Profile.Interfaces;
using UisApp.Helpers;

namespace UisApp.API.Providers
{
    internal static class LecturerProvider
    {
        public static IProfileModel GetMe()
        {
            var api = ApiProviderBase.GetInstance();
            IApiResponse<ProfileModel> response = api.GetRequest<ProfileModel>(UriResource.getme);

            var result = response.data as ProfileModel;
            return result;
        }

        public static IProfileModel SetPhoto(string fileName)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("photo_ext", Path.GetExtension(fileName));

            var api = ApiProviderBase.GetInstance();
            api.SendFile(UriResource.update_photo, param, File.ReadAllBytes(fileName));

            return GetMe();
        }
    }
}