using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SpikoDesktop.Utility;
using SpikoDesktop.Services;
using Microsoft.Win32;
using AForge.Video.DirectShow;
using System.IO;
using AForge.Video;
using SpikoDesktop.Models;
using SpikoDesktop.Services.WebServices;
using WK.Libraries.SharpClipboardNS;
using System.Speech.Synthesis;
using System.Net.NetworkInformation;

namespace SpikoDesktop
{
    public partial class QuestionsForm : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        enum QType
        {
            SingleChoice = 1, Mcqs, SQ, LQ
        }

        TimerUtility timer = new TimerUtility();
        QuestionUtil qUtil;
        List<RadioButton> radioButton;
        DataGridViewCheckBoxColumn checkbox;

        Bitmap cameraImg;
        public static VideoCaptureDevice videoCaptureDevice;
        System.Timers.Timer t;
        public int time { get; set; }   //total time in minutes

        ////[Obsolete]
        public QuestionsForm()
        {

            Logger.log.Info("Inside question form constructor");
            InitializeComponent();

            AutoSizing();
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler((sender, e) => AvailabilityChangedCallback(sender, e));
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            checkbox = new DataGridViewCheckBoxColumn();
            radioButton = new List<RadioButton>();
            qUtil = QuestionUtil.GetInstance();
            t = new System.Timers.Timer(1000);

            //if (this.Visible)
            //{
            //Setting value to timer
            timer = new TimerUtility(3, 50, 15);
            timer.AssignForm(this);
            t.Elapsed += OnTimeEvent;
            t.Enabled = true;

            videoCaptureDevice.NewFrame += videoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();

            SystemEvents.PowerModeChanged += OnPowerChange;

            //Console.WriteLine("Before loading other accessories method");
            //}
            Clipboard.Clear();
        }

        private void AvailabilityChangedCallback(object sender, NetworkAvailabilityEventArgs e)
        {
            //synth.Speak("I am in function of network checking");
            if (e.IsAvailable)
            {
                MonitoringUtil.GetInstance().DisconnectInternet();
                if (MonitoringUtil.GetInstance().NetworkConnectionDetector())
                {
                    WifiStatusPanel.BackColor = Color.FromArgb(128, 255, 128);
                }
                else
                {
                    WifiStatusPanel.BackColor = Color.FromArgb(255, 4, 0);
                }
                //synth.Speak("Network is available");
            }
            else
            {
                WifiStatusPanel.BackColor = Color.FromArgb(255, 4, 0);
                //synth.Speak("Network is not available");
            }
        }

        private void AutoSizing()
        {
            TimeLabel.AutoSize = true;
            MarkesLabel.AutoSize = true;
            qMarks.AutoSize = true;
            txtResult.AutoSize = true;
            QuestionTypeLabel.AutoSize = true;
            QuestionCounterLabel.AutoSize = true;
            QuesInfoLabel.AutoSize = true;
            QueueLabel.AutoSize = true;
        }

        private void videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            cameraImg = (Bitmap)eventArgs.Frame.Clone();
            //cameraImg.Save("Screen.png");
        }

        private DateTime sleepTime;
        private void OnPowerChange(object s, PowerModeChangedEventArgs e)
        {

            //System.Speech.Synthesis.SpeechSynthesizer sythesizer = new System.Speech.Synthesis.SpeechSynthesizer();
            switch (e.Mode)
            {
                case PowerModes.StatusChange:
                    //sythesizer.Speak("System charging status is changing");

                    break;
                case PowerModes.Suspend:
                    Logger.log.Info("System is going to sleep");
                    sleepTime = DateTime.Now;
                    MessageBox.Show("System has been paused at " + DateTime.Now);
                    //sythesizer.Speak("System is going to sleep");
                    break;
                case PowerModes.Resume:
                    if (sleepTime != null)
                    {
                        Logger.log.Info("System is awaking from sleep");
                        TimeSpan span = DateTime.Now - sleepTime;
                        timer.Hours -= span.Hours;
                        timer.Minutes -= span.Minutes;
                        timer.Seconds -= span.Seconds;
                        txtResult.Text = string.Format("{0}:{1}:{2}", timer.Hours.ToString().PadLeft(2, '0'), timer.Minutes.ToString().PadLeft(2, '0'), timer.Seconds.ToString().PadLeft(2, '0'));

                        if (timer.Hours == 0 && timer.Minutes == 0 && timer.Seconds <= 10)
                        {
                            txtResult.ForeColor = Color.FromArgb(255, 0, 0);
                        }

                        if (timer.Hours <= 0 && timer.Minutes <= 0 && timer.Seconds <= 0)
                        {
                            Logger.log.Info("Time is elapsed during sleep of system, So exam is submitted");
                            t.Stop();
                            SubmitBtn();
                        }
                    }

                    break;
            }
        }

        public void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.IsHandleCreated)
            {
                Invoke(new Action(() =>
                {
                    if (timer.Seconds <= 0 && timer.Minutes >= 1)
                    {
                        timer.Seconds = 59;
                        timer.Minutes -= 1;
                    }
                    else
                    {
                        timer.Seconds -= 1;
                    }
                    if (timer.Minutes <= 0 && timer.Hours >= 1)
                    {
                        timer.Minutes = 59;
                        if (timer.Hours != 0)
                        {
                            timer.Hours -= 1;
                        }
                    }
                    txtResult.Text = string.Format("{0}:{1}:{2}", timer.Hours.ToString().PadLeft(2, '0'), timer.Minutes.ToString().PadLeft(2, '0'), timer.Seconds.ToString().PadLeft(2, '0'));
                    if (timer.Hours == 0 && timer.Minutes == 0 && timer.Seconds <= 10)
                    {

                        txtResult.ForeColor = Color.FromArgb(255, 0, 0);
                    }

                    if (timer.Hours <= 0 && timer.Minutes <= 0 && timer.Seconds <= 0)
                    {
                        Logger.log.Info("Exam is submitted due to end of time");
                        t.Stop();
                        SubmitBtn();
                    }
                }));
            }
        }

        ////[Obsolete]
        private void LoadOtherAccessories()
        {
            EnableOrDisableButton();
            LoadAttemptedQuestionsSummary();
            ChangeColorsIfAttemptedQuestions();
            ShowQuestion(0);
        }

        private void ChangeColorsIfAttemptedQuestions()
        {
            List<Questions> q = qUtil.GetQList();

            for (int i = 0; i < qUtil.answers.AnswerList.Count; i++)
            {
                Questions obj = q[i];
                if (obj.QuestionType == 0)  //invalid type
                {
                    //if (qUtil.answers.AnswerList[i].Ans.Trim() != "Answer:" && qUtil.answers.AnswerList[i].Ans.Trim() != "")
                    if (qUtil.answers.AnswerList[i].Ans.Count == 0)
                    {
                        ChangeColor(i);     //attempted
                    }
                    else
                    {
                        ResetColor(i);  //not attempted
                    }
                }
                //else if (qUtil.answers.AnswerList[i] != null && !String.IsNullOrEmpty(qUtil.answers.AnswerList[i].Ans) && qUtil.answers.AnswerList[i].Ans.Trim() != "Answer:")
                else if (qUtil.answers.AnswerList[i] != null && qUtil.answers.AnswerList[i].Ans.Count != 0)
                {
                    ChangeColor(i);     //attempted
                }
            }
        }
        private void LoadAttemptedQuestionsSummary()
        {
            TotalQuestionsGrid.ColumnCount = qUtil.GetQList().Count;
            //MessageBox.Show("qUtil.GetQList().Count : " + qUtil.GetQList().Count);
            //MessageBox.Show("qUtil.GetQList().Count : " + qUtil.GetQList().Count);
            TotalQuestionsGrid.Rows.Add();
            for (int i = 0; i < qUtil.GetQList().Count; i++)
            {
                TotalQuestionsGrid.Columns[i].Name = i.ToString();
                TotalQuestionsGrid.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                TotalQuestionsGrid.Rows[0].Cells[i].Value = (i + 1).ToString();
            }
        }

        ////[Obsolete]
        private void ShowQuestion(int quesInd)
        {
            Clipboard.Clear();
            MonitoringUtil m = MonitoringUtil.GetInstance();

            WifiStatusPanel.BackColor = m.getStatusColor();
            //GetIPAddress and turn off the internet
            if (m.NetworkConnectionDetector())
            {
                m.GetIPAddress();
                m.DisconnectInternet();
            }

            directQuesTextBox.Text = (quesInd + 1).ToString();
            qUtil.BackupAnswers();
            this.AcceptButton = null;
            Questions q = qUtil.GetQList()[quesInd];

            qUtil.answers.AnswerList[quesInd].Id = q.Id;

            qMarks.Text = q.Points.ToString();
            QuestionCounterLabel.Text = "Question " + (quesInd + 1).ToString() + ":";
            QuestionTypeLabel.Text = "Type: " + ((QType)q.QuestionType).ToString();
            this.txtQuestion.Size = new Size(797, 27);
            txtQuestion.Text = "Question: " + q.Statement;
            string[] s = txtQuestion.Text.Split('\n');
            if (txtQuestion.Text.Length > 162 || s.Length > 1 && txtQuestion.Size.Height < 155)
            {
                SetSizeOfTextBox(txtQuestion.Text.Length, s.Length - 1);
            }
            QuestionPicturePanel.Height = txtQuestion.Height;
            
            if (q.QuestionType == 2)    //Multiple choice
            {
                QuesInfoLabel.Text = "Multiple Choices Can be Correct";
                HideRadioButtons();
                OptionGrid.Visible = true;
                DeletePreviousDataFromGrid();
                AddOptions(q.Options);
                try
                {
                    int size = qUtil.answers.AnswerList[quesInd].Ans.Count;
                    if (size > 0 && size <= q.Options.Count)
                    {
                        foreach (string ans in qUtil.answers.AnswerList[quesInd].Ans)
                        {
                            for (int i = 0; i < q.Options.Count; i++)
                            {
                                OptionGrid.Rows[i].Cells[0].Value = String.Equals(ans, q.Options[i].Statement);
                            }
                        }
                    }
                }
                catch (Exception) { }
            }
            else if (q.QuestionType == 1)       //single choice
            {
                txtAnswer.Visible = false;
                OptionGrid.Visible = false;
                HideRadioButtons();
                radioButton = new List<RadioButton>();
                QuesInfoLabel.Text = "Select Only Single Choice";
                AddRadioButtons(q.Options);
                if (qUtil.answers.AnswerList[quesInd].Ans.Count == 1)
                {
                    for (int i = 0; i < radioButton.Count; i++)
                    {
                        string ans = qUtil.answers.AnswerList[quesInd].Ans[0];
                        radioButton[i].Checked = String.Equals(ans, q.Options[0].Statement);
                    }
                }
            }
            else if (q.QuestionType == 3 || q.QuestionType == 4)    //short or long question
            {
                HideRadioButtons();
                if (q.QuestionType == 3)
                {
                    QuesInfoLabel.Text = "Answer should be till 100 words";
                }
                else
                {
                    QuesInfoLabel.Text = "Answer should be till 250 words";
                }
                OptionGrid.Visible = false;
                if (quesInd < qUtil.answers.AnswerList.Count
                    && qUtil.answers.AnswerList[quesInd] != null && 
                    qUtil.answers.AnswerList[quesInd].Ans.Count == 1)
                {
                    txtAnswer.Text = qUtil.answers.AnswerList[quesInd].Ans[0];
                }
                else
                {
                    txtAnswer.Text = "Answer:";
                }
                txtAnswer.Visible = true;
                AnswerPanel.Controls.Add(txtAnswer);
            }
            ShowOrHideImage(q.Img);
        }
        private void HideRadioButtons()
        {
            for (int i = 0; i < radioButton.Count; i++)
            {
                radioButton[i].Visible = false;
            }
        }

        private void AddRadioButtons(List<OptionsModel> options)
        {
            int k = 0;
            for (int i = options.Count - 1; i >= 0; i--)
            {
                radioButton.Add(new RadioButton());
                SetPropertiesOfRadioButton(radioButton[k], "radiobutton " + (i + 1).ToString(), k, options[i].Statement);
                radioButton[k].CheckedChanged += new EventHandler(radioButton_CheckedChanged);
                AnswerPanel.Controls.Add(radioButton[k]);
                k++;
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton r = sender as RadioButton;

            qUtil.answers.AnswerList[qUtil.QuestionCount].Ans.Clear();
            qUtil.answers.AnswerList[qUtil.QuestionCount].Ans.Add(r.Text);
            
            ChangeColor(qUtil.QuestionCount);
            
            //qUtil.answers.AnswerList[qUtil.QuestionCount].Ans[0] = ind[1];

            //qUtil.answers.AnswerList[qUtil.QuestionCount].Ans.Add();
            //qUtil.BackupAnswers();
        }

        private void SetPropertiesOfRadioButton(RadioButton radioButton, string name, int tabInd, string text)
        {
            radioButton.Dock = DockStyle.Top;
            radioButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            radioButton.Location = new Point(0, 0);
            radioButton.Name = name;
            radioButton.Size = new Size(805, 36);
            radioButton.TabIndex = tabInd;
            radioButton.TabStop = true;
            radioButton.Text = text;
            radioButton.UseVisualStyleBackColor = true;

        }

        #region image inside question
        private void ShowOrHideImage(String image)
        {
            if (image != null)
            {
                if (QuestionPicturePanel.Height < 90)
                    QuestionPicturePanel.Height = 90;
                qPicture.Image = Crypto.GetInstance().Base64ToImage(image);
                qPicture.Show();
            }
            else
            {
                qPicture.Hide();
            }
        }

        #endregion

        private void txtAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            Questions questions = qUtil.GetQList()[qUtil.QuestionCount];
            int len = 1;
            if (questions.QuestionType == 3)
            {
                len = 100;
            }
            else if (questions.QuestionType == 4)
            {
                len = 250;
            }
            if (AnsLengthUtil.GetInstance().CheckWords(txtAnswer.Text, len))
            {
                SetAnswer(len);
            }
        }

        private void SetAnswer(int len)
        {
            if (AnsLengthUtil.GetInstance().WordsLength > len)
            {
                txtAnswer.Text = AnsLengthUtil.GetInstance().Word;
                txtAnswer.SelectionStart = txtAnswer.Text.Length;
                txtAnswer.SelectionLength = 1;
            }

            Answer answer = new Answer();
            answer.Ans.Add(txtAnswer.Text);
 
            int qNum = Convert.ToInt32(directQuesTextBox.Text) - 1;
            answer.Id = qUtil.GetQList()[qNum].Id;
            if (qUtil.answers.AnswerList.Count <= qNum)
            {
                qUtil.answers.AnswerList.Add(answer);
                //qUtil.AttemptedQ++;
                //qUtil.UnAttemptedQ--;
            }
            else
            {
                qUtil.answers.AnswerList[qNum].Ans = answer.Ans;
            }
            if (txtAnswer.Text.Trim().ToLower() != "answer:" && txtAnswer.Text.Trim().ToLower() != "answer"
                && txtAnswer.Text.Trim() != "")
            {
                ChangeColor(qUtil.QuestionCount);
            }
            else
            {
                ResetColor(qUtil.QuestionCount);
            }
            //qUtil.BackupAnswers();
        }

        private void SetSizeOfTextBox(int length, int n)
        {
            int times = length / 162;
            if (times == 0)
            {
                times = 1;
            }
            times += n;
            for (int i = 0; i < times; i++)
            {
                if (!(txtQuestion.Size.Height < 155))
                {
                    break;
                }
                txtQuestion.Size = new Size(789, txtQuestion.Size.Height + 12 * 2);
            }
        }

        private void OptionGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (row >= 0)
            {
                bool flag = (bool)OptionGrid.Rows[row].Cells[0].Value;
                if (flag != true)       //if user checks the option, add it to answer list.
                {
                    ChangeColor(qUtil.QuestionCount);
                    //if (qUtil.answers.AnswerList[qUtil.QuestionCount].Ans.Count == 0)
                    //{
                    //    qUtil.answers.AnswerList[qUtil.QuestionCount].Ans = "";
                    //}

                    OptionGrid.Rows[row].Cells[0].Value = true;
                    qUtil.answers.AnswerList[qUtil.QuestionCount].Ans.Add(OptionGrid.Rows[row].Cells[1].Value.ToString());
                    Console.WriteLine(qUtil.answers.AnswerList[qUtil.QuestionCount].Ans.Count);
                    foreach (string ans in qUtil.answers.AnswerList[qUtil.QuestionCount].Ans)
                    {
                        Console.WriteLine(ans);
                    }
                    
                    //for (int i = 0; i < OptionGrid.Rows.Count; i++)
                    //{
                    //    if (OptionGrid.Rows[i].Cells[0].Value.ToString() == "True")
                    //    {
                    //        qUtil.answers.AnswerList[qUtil.QuestionCount].Ans.Add();
                    //    }
                    //}
                    //qUtil.BackupAnswers();
                }
                else       //if user unchecks the option, remove it from the answer list
                {

                    //string[] y = qUtil.answers.AnswerList[qUtil.QuestionCount].Ans.Split(' ');
                    //int a = Array.IndexOf(y, (e.RowIndex + 1).ToString());
                    //qUtil.answers.AnswerList[qUtil.QuestionCount].Ans = qUtil.GetUpdatedOptions(a, y);
                    OptionGrid.Rows[row].Cells[0].Value = false;

                    List<string> answers = qUtil.answers.AnswerList[qUtil.QuestionCount].Ans;
                    answers.Remove(OptionGrid.Rows[row].Cells[0].Value.ToString());
                    
                    EnableOrDiableColorForGird();
                    //qUtil.BackupAnswers();
                }
            }
        }
        private void EnableOrDiableColorForGird()
        {
            bool flag = false;
            for (int i = 0; i < OptionGrid.Rows.Count; i++)
            {
                if (OptionGrid.Rows[i].Cells[0].Value.ToString() == "True")
                {
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                ResetColor(qUtil.QuestionCount);
            }
        }

        private void AddOptions(List<OptionsModel> options)
        {
            for (int i = 0; i < options.Count; i++)
            {
                int n = OptionGrid.Rows.Add();
                /*if ((qUtil.GetQList()[1]) != null)
                {
                    PictureBox picture = new PictureBox();
                    picture.Name = "pictureBox";
                    Size = new Size(16, 16);
                    Location = new Point(100, 100);
                }*/
                OptionGrid.Rows[n].Cells[0].Value = options[i].Statement;
            }

            checkbox.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            checkbox.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            OptionGrid.Columns.Insert(0, checkbox);

            for (int i = 0; i < OptionGrid.Rows.Count; i++)
            {
                OptionGrid.Rows[i].Cells[0].Value = false;
            }
        }
        ////[Obsolete]
        private void DeletePreviousDataFromGrid()
        {
            OptionGrid.Columns.Clear();
            OptionGrid.Rows.Clear();
            OptionGrid.Refresh();
            OptionGrid.Columns.Add("Column1", "Options");
        }
        private void EnableOrDisableButton()
        {
            FirstQuestionButton.Enabled = true;
            PreviousQuestionButton.Enabled = true;
            NextQuestionButton.Enabled = true;
            LastQuestionButton.Enabled = true;
            if (qUtil.QuestionCount == 0)
            {
                FirstQuestionButton.Enabled = false;
                PreviousQuestionButton.Enabled = false;
            }
            if (qUtil.QuestionCount == qUtil.GetQList().Count - 1)
            {
                NextQuestionButton.Enabled = false;
                LastQuestionButton.Enabled = false;
            }
        }
        private void Enable()
        {
            NextQuestionButton.Enabled = true;
            LastQuestionButton.Enabled = true;
            FirstQuestionButton.Enabled = true;
            PreviousQuestionButton.Enabled = true;
            if (qUtil.QuestionCount == 0)
            {
                FirstQuestionButton.Enabled = false;
                PreviousQuestionButton.Enabled = false;
            }
            if (qUtil.QuestionCount == qUtil.GetQList().Count - 1)
            {
                NextQuestionButton.Enabled = false;
                LastQuestionButton.Enabled = false;
            }
        }

        private void txtAnswer_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtAnswer.Text.Trim() == "Answer:")
            {
                txtAnswer.Text = "";
            }
        }

        ////[Obsolete]
        private void SubmitExamButton_Click_1(object sender, EventArgs e)
        {
            Logger.log.Info("Exam submit button is clicked");
            timer.ResetTimer();
            t.Stop();
            qUtil.BackupAnswers();
            SubmitBtn();
        }
        public void SubmitBtn()
        {
            int AttemptedQ = 0;
            // MonitoringUtil.GetInstance().ConnectInternet();
            for (int i = 0; i < qUtil.answers.AnswerList.Count; i++)
            {
                //if (qUtil.answers.AnswerList[i].Ans.Trim() == "Answer:")
                if (qUtil.answers.AnswerList[i].isAttempted)
                {
                    AttemptedQ++;
                }
            }

            //qUtil.AttemptedQ = qUtil.GetQList().Count - qUtil.UnAttemptedQ;
            int UnAttemptedQ = qUtil.GetQList().Count - AttemptedQ;

            ExamSubmittedForm frm = ExamSubmittedForm.GetInstance(AttemptedQ, UnAttemptedQ);
            frm.Show();
            this.Hide();

            videoCaptureDevice.Stop();
            if (!MonitoringUtil.GetInstance().NetworkConnectionDetector())
            {
                frm.bunifuButton1.Text = "Connecting to the internet";
                MonitoringUtil.GetInstance().ConnectInternet();
            }

            frm.bunifuButton1.Text = "Saving Answers";
            //qUtil.GenerateDocxFile();

            //string answerJson= Crypto.SerializeJsonObject<AnswerModel>(qUtil.answers);
            //MessageBox.Show("Internet Connection : "+ MonitoringUtil.GetInstance().NetworkConnectionDetector() );
            string answerJson = Crypto.SerializeJsonObject<List<Answer>>(qUtil.answers.AnswerList);
            //int id = Convert.ToInt32(dgPending[2, r].Value.ToString());
            //MessageBox.Show("Exam id : "+QuestionUtil.GetInstance().answers.Id);
            string answer = File.ReadAllText(Configuration.getInstance().getValue("UsersBasePath")+
                @"\"+ProfileUtility.GetInstance().currentProfile.UserName.ToLower()+
                @"\" + "ExamId_"+ QuestionUtil.GetInstance().answers.Id + "_Answers.json");
            Console.WriteLine("\n\n");
            Console.WriteLine(answerJson);
            Console.WriteLine("\n\n");
            bool upload = SubmitAnswerService.GetService().UploadAnswer(answer);

            if (upload)
            {
               // MessageBox.Show("Exam is submitted to web");
                frm.bunifuButton1.Text = "Exam Submitted Successfully !!!";
                frm.enableBackButton();
                qUtil.EmptyFile(); //Here it is temporary called. It will be called after sending data to web.
            }
            else
            {
               // MessageBox.Show("Exam is not submitted successfully");
                frm.bunifuButton1.Text = "Exam Not Submitted !!!";
                frm.enableBackButton();
            }
        }

        ////[Obsolete]
        private void DirectQuestionButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                int queNum = Convert.ToInt32(directQuesTextBox.Text);
                //MessageBox.Show("Question to call : " + queNum);
                if (queNum <= qUtil.GetQList().Count && queNum > 0)
                {
                    directQuesTextBox.Text = queNum.ToString();
                    qUtil.QuestionCount = queNum - 1;
                    Enable();
                    ShowQuestion(queNum - 1);
                }
                else
                {
                    directQuesTextBox.Text = "1";
                    MessageBox.Show("Enter value between 1 to " + qUtil.GetQList().Count.ToString());
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show("Error : " + e1.ToString());
                directQuesTextBox.Text = "1";
                MessageBox.Show("Please enter only integer value between 1 to " + qUtil.GetQList().Count.ToString());
            }
        }

        ////[Obsolete]
        private void PreviousQuestionButton_Click_1(object sender, EventArgs e)
        {
            if (qUtil.QuestionCount != 0)
            {
                ShowQuestion(--qUtil.QuestionCount);
            }
            Enable();
        }

        ////[Obsolete]
        private void NextQuestionButton_Click_1(object sender, EventArgs e)
        {
            if (qUtil.QuestionCount < qUtil.GetQList().Count - 1)
            {
                ShowQuestion(++qUtil.QuestionCount);
            }
            Enable();
        }

        //[Obsolete]
        private void LastQuestionButton_Click(object sender, EventArgs e)
        {
            qUtil.QuestionCount = qUtil.GetQList().Count - 1;
            EnableOrDisableButton();
            ShowQuestion(qUtil.GetQList().Count - 1);
        }

        //[Obsolete]
        private void TotalQuestionsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0)
            {
                qUtil.QuestionCount = e.ColumnIndex;
                Enable();
                ShowQuestion(e.ColumnIndex);
            }
        }
        private void ChangeColor(int i)
        {
            TotalQuestionsGrid.Columns[i].DefaultCellStyle.BackColor = Color.Green;
            TotalQuestionsGrid.Columns[i].DefaultCellStyle.ForeColor = Color.White;
            TotalQuestionsGrid.Columns[i].DefaultCellStyle.SelectionBackColor = Color.Green;
            TotalQuestionsGrid.Columns[i].DefaultCellStyle.SelectionForeColor = Color.White;
            qUtil.answers.AnswerList[i].isAttempted = true;
        }

        private void dirextQuesTextBox_Enter_1(object sender, EventArgs e)
        {
            this.AcceptButton = DirectQuestionButton;
        }

        private void ResetColor(int i)
        {
            TotalQuestionsGrid.Columns[i].DefaultCellStyle.BackColor = Color.White;
            TotalQuestionsGrid.Columns[i].DefaultCellStyle.ForeColor = Color.Black;
            TotalQuestionsGrid.Columns[i].DefaultCellStyle.SelectionBackColor = Color.White;
            TotalQuestionsGrid.Columns[i].DefaultCellStyle.SelectionForeColor = Color.Black;
            qUtil.answers.AnswerList[i].isAttempted = false;
        }

        //[Obsolete]
        private void FirstQuestionButton_Click(object sender, EventArgs e)
        {
            qUtil.QuestionCount = 0;
            EnableOrDisableButton();
            ShowQuestion(0);
        }

        private void QuestionsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.log.Info("Question form is closing");
            //videoCaptureDevice.Stop();
            //e.Cancel = true;
        }

        private void directQuesTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DirectQuestionButton.PerformClick();
            }
        }
        //[Obsolete]
        private void qPicture_Click(object sender, EventArgs e)
        {
            PicturePopUp popUp = PicturePopUp.GetInstance(txtQuestion.Text, qPicture.Image, this.Location);
            PicturePopUp.ShowBgForm();
            popUp.Show();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (DisableKeyCombUtil.GetInstance().GetKeys().Contains(keyData))
            {
                Logger.log.Info("Disabled key is pressed");
                return true;
            }
            return false;
        }

        private void monitoringTimer_Tick(object sender, EventArgs e)
        {
            Logger.log.Info("Security round is started");
            MonitoringUtil m = MonitoringUtil.GetInstance();
            m.embeddedCameraImg = m.embedAddresses(cameraImg);
            m.embeddedSs = m.embedAddresses(m.CaptureMyScreen());


            m.Filling();
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            //Setting value to timer
            //timer = new TimerUtility(3, 50, 15);
            //timer.AssignForm(this);
            //t.Elapsed += OnTimeEvent;
            //t.Enabled = true;
            LoadOtherAccessories();
            //ShowQuestion(0);
        }

        private void clipboard_ClipboardChanged(object sender, SharpClipboard.ClipboardChangedEventArgs e)
        {
            Logger.log.Info("CUT , Copy event occured ");
            // Is the content copied of text type?
            if (e.ContentType == SharpClipboard.ContentTypes.Text)
            {
                // Get the cut/copied text.
                Console.WriteLine(clipboard.ClipboardText);

            }

            // Is the content copied of image type?
            else if (e.ContentType == SharpClipboard.ContentTypes.Image)
            {
                // Get the cut/copied image.
                Image img = clipboard.ClipboardImage;
                Console.WriteLine(Crypto.GetInstance().ImageToBase64((Bitmap)img));
            }

            // Is the content copied of file type?
            else if (e.ContentType == SharpClipboard.ContentTypes.Files)
            {
                // Get the cut/copied file/files.
                Console.WriteLine(clipboard.ClipboardFiles.ToArray());

                // ...or use 'ClipboardFile' to get a single copied file.
                Console.WriteLine(clipboard.ClipboardFile);
            }

            // If the cut/copied content is complex, use 'Other'.
            else if (e.ContentType == SharpClipboard.ContentTypes.Other)
            {
                // Do something with 'clipboard.ClipboardObject' or 'e.Content' here...
            }
            Clipboard.Clear();

            // Gets the application's executable name.
            Console.WriteLine(e.SourceApplication.Name);
            // Gets the application's window title.
            Console.WriteLine(e.SourceApplication.Title);
            // Gets the application's process ID.
            Console.WriteLine(e.SourceApplication.ID.ToString());
            // Gets the application's executable path.
            Console.WriteLine(e.SourceApplication.Path);

            //// For texts...
            //string text = e.Content.ToString();

            //// or images...
            //Image img = (Image)e.Content;

            //// or files...
            //List<string> files = (List<string>)e.Content;

            //// or other complex types too.
            //// Person p = JsonConvert.DeserializeObject<Person>(e.Content);
            Console.WriteLine("\n\n\n\n");

        }
    }
}
