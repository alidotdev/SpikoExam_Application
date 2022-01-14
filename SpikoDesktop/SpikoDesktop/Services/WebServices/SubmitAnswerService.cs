using RestSharp;
using SpikoDesktop.Models;
using SpikoDesktop.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.Services.WebServices
{
    class SubmitAnswerService
    {
        private static SubmitAnswerService Service { get; set; }
        private SubmitAnswerService() { }

        public static SubmitAnswerService GetService()
        {
            if (Service == null) { Service = new SubmitAnswerService(); }
            return Service;
        }
        public bool UploadAnswer(string ans)
        {
            Logger.log.Info("Uploading exam answers through service");

            //var client = new RestClient(Configuration.getInstance().getValue("BaseUrl") + "api/QuestionAnswer/Send?");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.POST);
            //request.AddHeader("Content-Type", "application/json");
            //var body = ans;
            //request.AddParameter("application/json", body, ParameterType.RequestBody);
            //IRestResponse response = client.Execute(request);
            //MessageBox.Show("Answer is : "+ans);
            var client = new RestClient(Configuration.getInstance().getValue("BaseUrl")+"api/QuestionAnswer/Send?=");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            //request.AddHeader("Content-Length", "587");
            request.AddHeader("Content-Type", "application/json");
            var body = ans;
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            if (response.Content.Equals("true"))
            {
                Logger.log.Info("Successfully upladed answers data to web service");
                return true;
            }
            Logger.log.Error("Eror occured in sending answer data to web service");
            return false;
        }
    }
}
