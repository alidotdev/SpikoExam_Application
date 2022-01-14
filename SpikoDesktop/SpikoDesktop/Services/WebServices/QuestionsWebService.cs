using RestSharp;
using SpikoDesktop.Models;
using SpikoDesktop.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpikoDesktop.Services.WebServices
{
    class QuestionsWebService
    {
        private static QuestionsWebService Service { get; set; }
        private QuestionsWebService() { }

        public static QuestionsWebService GetService()
        {
            if (Service == null) { Service = new QuestionsWebService(); }
            return Service;
        }
        public string GetQuestionsByExamId(int id)
        {
            Logger.log.Info("Sending request for getting question data for exam by id");
            var client = new RestClient(Configuration.getInstance().getValue("BaseUrl") + "api/Question/IndexDesktop/" + id);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);

            //File.WriteAllText(Configuration.getInstance().getValue("UsersBasePath") + @"\" + ProfileUtility.GetInstance().currentProfile.UserName.ToLower() + @"\Questions.json", response.Content);
            File.WriteAllText(AttemptExamUtility.GetInstance().questionJson, response.Content);

            if (!String.IsNullOrEmpty(response.Content))
            {
                Logger.log.Info("Success in calling service of question data of exam");
                return response.Content;
            }
            Logger.log.Error("Error occured in calling service for question data");
            return null;
        }
    }
}
