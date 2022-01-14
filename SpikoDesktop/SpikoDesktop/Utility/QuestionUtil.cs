using SpikoDesktop.Models;
using SpikoDesktop.Services;
using SpikoDesktop.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace SpikoDesktop
{
    class QuestionUtil
    {
        public AnswerModel answers;
        //public int AttemptedQ { get; set; }

        //public int UnAttemptedQ { get; set; }

        public int QuestionCount { get; set; }

        private List<Questions> QList;
        
        #region Singleton class
        private static QuestionUtil _instance;

        public static QuestionUtil GetInstance()
        {
            if  (_instance ==  null)
            {
                _instance = new QuestionUtil();
            }
            return _instance;
        }
        #endregion
        
        private QuestionUtil()
        {
            QList = new List<Questions>();
            LoadData();

            Profile profile = ProfileUtility.GetInstance().currentProfile;
            answers = new AnswerModel(profile.UserName, QList.Count);

            if (CheckFile() == false)
            {
                LoadAnswers();
            }
            else
            {
                WriteAnswerFile();
                LoadAnswers();
            }
            //AttemptedQ = 0;
            //UnAttemptedQ = QList.Count;
            //QuestionCount = 0;
        }

        private void WriteAnswerFile()
        {
            //FileInfo file = new FileInfo(@"..\..\..\Program Files\Answers.csv");
            //StreamWriter writer = file.CreateText();
            //for (int i=0; i<QList.Count; i++)
            //{
            //    writer.WriteLine("Question " + (i+1) + ": ," + "Answer: ");
            //}
            //writer.Close();
        }

        public void EmptyFile() // This method is public to call it from "QuestionsForm.cs" to empty
                                // "Answers.txt" file after students exam is finished.
        {
            //String path = @"..\..\..\Program Files\Answers.csv";
            //if (File.Exists(path))
            //    File.Delete(path);
            ////FileInfo file = new FileInfo(@"..\..\..\Program Files\Answers.csv");
            ////StreamWriter writer = file.CreateText();
            ////writer.Write(String.Empty);
            ////writer.Close();
        }

        private bool CheckFile()
        {
            try
            {
                String file = File.ReadAllText(Configuration.getInstance().getValue("SavingPath") + "Answers.json");
                if (file.Trim() == "")
                {
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return true;
            }

        }

        private void LoadAnswers()
        {
            //FileInfo file = new FileInfo(@"..\..\..\Program Files\Answers.csv");
            //StreamReader reader = file.OpenText();
            //string str = "";
            //int i = 0;
            //while((str = reader.ReadLine()) != null)
            //{
            //    string[] q = str.Split(',');
            //    Answer obj = new Answer();
            //    obj.Id = q[0].Trim() + " ";
            //    obj.Ans = q[1].Trim() + " ";
            //    answersList.Add(obj);
            //    i++;
            //}

            //MessageBox.Show(ProfileUtility.GetInstance().currentUserPath);
            //if (File.Exists(Configuration.getInstance().getValue("SavingPath") + "Answers.json"))
            string filename = AttemptExamUtility.GetInstance().answerJson;
            if (File.Exists(ProfileUtility.GetInstance().currentUserPath))
            {
                Logger.log.Info("Loading answers to json file");
                //string text = File.ReadAllText(ProfileUtility.GetInstance().currentUserPath + "Answers.json");
                string text = File.ReadAllText(filename);
                AnswerModel loadedAnswers = Crypto.DeserializeJsonObject<AnswerModel>(text);
                MessageBox.Show("Answres after loading from file : "+ loadedAnswers);
                if (answers.Id == loadedAnswers.Id)
                {
                    answers = loadedAnswers;
                    answers.Username = ProfileUtility.GetInstance().currentProfile.UserName;
                }
            }
        }

        public List<Questions> GetQList()
        {
            return QList;
        }

        public void LoadData()
        {
            Logger.log.Info("Question data from json file");
            //String file = File.ReadAllText(Configuration.getInstance().getValue("SavingPath") + "Questions.json");
            String file = File.ReadAllText(AttemptExamUtility.GetInstance().questionJson);
            QList = Crypto.DeserializeJsonObject<List<Questions>>(file);
            Console.WriteLine(Crypto.SerializeJsonObject<List<Questions>>(QList));
            //MessageBox.Show("Question list after loading : "+QList);
        }
        
        public Questions GetQuestion(int index)
        {
            return QList[index];
        }
        public string GetUpdatedOptions(int a, string[] options)
        {
            string str = "";
            for (int i = 0; i < options.Length; i++)
            {
                if (i != a)
                {
                    str += options[i] + " ";
                }
            }
            return str;
        }

        public void BackupAnswers()
        {
            //try
            //{
            //    FileInfo file = new FileInfo(@"..\..\..\Program Files\Answers.csv");
            //    StreamWriter writer = file.CreateText();
            //    for (int i = 0; i < answersList.Count; i++)
            //    {
            //        writer.WriteLine(answersList[i].Id + "," + answersList[i].Ans);
            //    }
            //    writer.Close();
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            //MessageBox.Show(ProfileUtility.GetInstance().currentUserPath);

            string str = Crypto.SerializeJsonObject<AnswerModel>(answers);
            string filename = AttemptExamUtility.GetInstance().answerJson;
            File.WriteAllText(filename, str);

        }

        /*public void GenerateDocxFile()
        {
            Word.Application word = new Word.Application();
            Word.Document doc = word.Documents.Add();
            Word.Paragraph paragragh = doc.Paragraphs.Add();
            string data = GetData();
            paragragh.Range.Text = data;

            string path = Path.GetFullPath(Configuration.getInstance().getValue("SavingPath") + "QuestionsDocument.doc");

            doc.SaveAs2(path);
            //doc.SaveAs(@"D:\Desktop App\SpikoDesktop\SpikoDesktop\SpikoDesktop\Program Files\QuestionsDocument.doc");
            ////doc.SaveAs(@"..\..\..\Program Files\QuestionsDocument.doc");

            doc.Close();
            word.Quit();
        }

        private string GetData()
        {
            string str = "";
            for (int i = 0; i < QList.Count; i++)
            {
                str += "Question " + (i + 1).ToString() + ": " + QList[i].Statement + "\n";
            }

            str += "\n\n\nAnswer Keys:\n";

            string subString = "";

            for (int i = 0; i < QList.Count; i++)
            {
                if (QList[i].QuestionType == 0 || QList[i].QuestionType == 1)
                {
                    if (QList[i].QuestionType == 1)
                    {
                        subString = "Single Choice Question";
                    }
                    else if (QList[i].QuestionType == 2)
                    {
                        subString = "Multiple Choice Question";
                    }
                    str += "Question " + (i + 1).ToString() + " (" + subString + "): Option " + answersList[i] + "\n";
                }
            }
            return str;
        }*/
    }
}
