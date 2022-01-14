using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpikoDesktop.Models;
using SpikoDesktop.Services;
using SpikoDesktop.Services.WebServices;

namespace SpikoDesktop.Utility
{
    class AttemptExamUtility
    {
        public List<Exam> listOfExams { get; set; }
        private static AttemptExamUtility _instance;
        public string answerJson { get; set; }
        public string questionJson { get; set; }

        private AttemptExamUtility()
        {
            listOfExams = new List<Exam>();
            LoadData();
        }
        public static AttemptExamUtility GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AttemptExamUtility();
            }
            return _instance;
        }

        public void LoadData()
        {
            Logger.log.Info("Loading data of exam");
            Profile p = ProfileUtility.GetInstance().currentProfile;
            string exams = ExamWebService.GetService().GetAllExams(p.UserName.ToLower());
            Console.WriteLine("\n\n\n\n" + exams + "\n\n\n\n");
            listOfExams = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Exam>>(exams);

            if (!String.IsNullOrEmpty(exams))
            {
                listOfExams = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Exam>>(exams);
            }
        }

        public List<Exam> GetExamsByType(int type)
        {
            List<Exam> exams = new List<Exam>();
            foreach (Exam e in listOfExams)
            {
                if (e.Status==type)
                {
                    exams.Add(e);
                }
            }
            return exams;
        }

        public void MakeReadyExam(int id)
        {
            answerJson = ProfileUtility.GetInstance().currentUserPath + "ExamId_" + id + "_Answers.json";
            //string examJson = @"..\..\..\Program Files\" + ExamName + ".json";
            questionJson = ProfileUtility.GetInstance().currentUserPath + "ExamId_" + id + "_Questions.json";

            //string qJson = Configuration.getInstance().getValue("SavingPath") + "Questions.json";

            Console.WriteLine("The file exists");
            Console.WriteLine(File.Exists(questionJson));
            Console.WriteLine("\n\n\n\n\n");
            File.WriteAllText(questionJson, QuestionsWebService.GetService().GetQuestionsByExamId(id));
            QuestionUtil.GetInstance().answers.Id = id;

            ClearClipBoard();
        }
        public void ClearClipBoard()
        {
            Clipboard.Clear();
        }

    }
}
