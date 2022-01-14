using RestSharp;
using SpikoDesktop.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.Services.WebServices
{
    class ExamWebService
    {
        private static ExamWebService Service { get; set; }
        private ExamWebService() { }

        public static ExamWebService GetService()
        {
            if (Service == null) { Service = new ExamWebService(); }
            return Service;
        }
        public String GetAllExams(string username)
        {
            Logger.log.Info("Calling Exam web Service");
            var client = new RestClient(Configuration.getInstance().getValue("BaseUrl") + "api/Exam/IndexDesktop/");
            //var client = new RestClient(Configuration.getInstance().getValue("BaseUrl") + "api/Exam/Index");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
			request.AddParameter("username",username);
            //request.AddHeader("Content-Type", "application/json");
            IRestResponse response = client.Execute(request);
            //MessageBox.Show("Response Content \n" + response.Content);
            List<Exam> e = Crypto.DeserializeJsonObject<List<Exam>>(response.Content);
            //MessageBox.Show("List Count"+e.Count);
            File.Delete(@Configuration.getInstance().getValue("UsersBasePath") + @"\" + @username + @"\Exam.txt");
            for (int i = 0; i < e.Count; i++)
            {
                //MessageBox.Show("Object of exam : \nExam ID : " + e[i].Id + "\nExam Name : " + e[i].ExamName + "\nExam Code : " + e[i].ExamCode + "\nExam Status : " + e[i].Status);
                //File.WriteAllText(@Configuration.getInstance().getValue("UsersBasePath") + @"\" + @username + @"\Exam.txt", e[i].Id + "," + e[i].ExamName + "," + e[i].ExamCode + "," + e[i].Status);
                File.AppendAllText(@Configuration.getInstance().getValue("UsersBasePath") + @"\" + @username + @"\Exam.txt", e[i].Id + "," + e[i].ExamName + "," + e[i].ExamCode + "," + e[i].Status + "\n");
            }
            if (!String.IsNullOrEmpty(response.Content))
            {
                Logger.log.Info("Successfully called exam service");
                return response.Content;
            }
            Logger.log.Error("Web service is not called successfully");
            return null;
        }
        public String GetExamsDetailsById(int id)
        {
            Logger.log.Info("Calling exam by id");
            var client = new RestClient(Configuration.getInstance().getValue("BaseUrl") + "api/Exam/GetExam/" + id);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);

            try
            {
                ExamDetails exam = Crypto.DeserializeJsonObject<ExamDetails>(response.Content);
                Logger.log.Info("Successfully called exam by special id");
                return response.Content;
            }
            catch (Exception)
            {
                Logger.log.Error("Error in calling exam service by id");
                return null;
            }
            
        }
        public string GetExamSettingsById (int id)
        {
            Logger.log.Info("Calling exam by id to get exam settings");
            var client = new RestClient(Configuration.getInstance().getValue("BaseUrl") + "api/ExamSetting/ExamSetting");
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AddParameter("ExamId", id);
            IRestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            
            try
            {
                ExamDetails exam = Crypto.DeserializeJsonObject<ExamDetails>(response.Content);
                Logger.log.Info("Successfully get exam settings by id");
                return response.Content;
            }
            catch (Exception)
            {
                Logger.log.Error("Error in getting exam settings by id");
                return null;
            }
        }
    }
}
