using RestSharp;
using SpikoDesktop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.Services
{
    class LoginWebService
    {
        private static LoginWebService Service { get; set; }
        private LoginWebService() { }

        public static LoginWebService GetService()
        {
            if (Service == null) { Service = new LoginWebService(); }
            return Service;
        }
        public string Token { get; set; }
        public async Task<ResponseStatusViewModel> LoginUser(string email, string password)
        {
            Logger.log.Info("Sending Request for login service");
            ResponseStatusViewModel res = new ResponseStatusViewModel();
            var client = new RestClient(Configuration.getInstance().getValue("BaseUrl")+"token");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
            request.AddParameter("grant_type", "password");
            request.AddParameter("username", email);
            request.AddParameter("password", password);
            IRestResponse response = await client.ExecuteAsync(request);
            
            String responseStr = response.Content;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                LoginResponseViewModel tokenData = Crypto.DeserializeJsonObject<LoginResponseViewModel>(responseStr);
             
                Token = tokenData.access_token;
                File.WriteAllText("Token.txt",Token);


                res.status = true;
                res.Data = tokenData;
                Logger.log.Info("Success in caling login service");
            }
            else
            {
                LoginErrorViewModel model = Crypto.DeserializeJsonObject<LoginErrorViewModel>(responseStr);
                res.status = false;
                res.Message = model.error_description;
                Logger.log.Error("Error in calling login service");
            }
            return res;
          
        }
    }
}
