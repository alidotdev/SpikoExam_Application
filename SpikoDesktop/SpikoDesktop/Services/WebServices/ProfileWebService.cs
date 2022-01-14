using RestSharp;
using SpikoDesktop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikoDesktop.Services.WebServices
{
    class ProfileWebService
    {
        private static ProfileWebService Service { get; set; }
        private ProfileWebService() { }

        public static ProfileWebService GetService()
        {
            if (Service == null) { Service = new ProfileWebService(); }
            return Service;
        }
        public ResponseStatusViewModel GetProfile(string email, string password)
        {
            ResponseStatusViewModel res = new ResponseStatusViewModel();
            var client = new RestClient(Configuration.getInstance().getValue("BaseUrl")+"api/User/Profile");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", "bearer "+LoginWebService.GetService().Token);
            IRestResponse response = client.Execute(request);
            string responseStr=response.Content;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                UserProfile profileData = Crypto.DeserializeJsonObject<UserProfile>(responseStr);
                res.status = true;
                res.Data = profileData;
            }
            else
            {
                ProfileErrorMessage model = Crypto.DeserializeJsonObject<ProfileErrorMessage>(responseStr);
                res.status = false;
                res.Message = model.Message;
            }
            return res;

        }
    }
}
