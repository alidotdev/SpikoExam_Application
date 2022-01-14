using SpikoDesktop.Utility;
using RestSharp;
using SpikoDesktop.Models;
using SpikoDesktop.Services;
using SpikoDesktop.Services.WebServices;
using SpikoDesktop.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Net.NetworkInformation;

namespace SpikoDesktop
{
    public partial class Dashboard2 : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        private Button btnActive = null;
        private UserControl mainControl = null;

        #region singleton class
        private static Dashboard2 _instance;

        public static Dashboard2 GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Dashboard2();
            }
            return _instance;
        }
#endregion

        private Dashboard2()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.GetWorkingArea(FromHandle(this.Handle));
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler((sender, e) => AvailabilityChangedCallback(sender, e));
        }

        //private void LoadTypedExam(int type)
        //{
        //    //Control ctrl = c;
        //    //bunifuPages1.TabPages[tabPaneIndex].AutoScroll = true;
        //    List<Exam> list = AttemptExamUtility.GetInstance().GetExamsByType(type);

        //    if (list.Count != 0)
        //    {
        //        //label.Visible = false;
        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            SpikoPanel p = new SpikoPanel(list[i].ExamName);
        //            //p.Location = new Point(ctrl.Location.X, ctrl.Location.Y + ctrl.Height + 5);
        //            p.GetButton().Click += new EventHandler(this.ExamLoad);
        //            //bunifuPages1.TabPages[tabPaneIndex].Controls.Add(p);
        //            //ctrl = p;
        //        }
        //    }
        //    else
        //    {
        //        //label.Visible = true;
        //    }
        //}

        private void AvailabilityChangedCallback(object sender, NetworkAvailabilityEventArgs e)
        {
            //synth.Speak("I am in function of network checking");
            if (e.IsAvailable)
            {
                WifiStatusPanel.BackColor = Color.FromArgb(128, 255, 128);
                //synth.Speak("Network is available");
            }
            else
            {
                WifiStatusPanel.BackColor = Color.FromArgb(255, 4, 0);
                //synth.Speak("Network is not available");
            }
        }

        //private void ExamLoad(object sender, EventArgs e)
        //{

        //    foreach (Exam exam in AttemptExamUtility.GetInstance().listOfExams)
        //    {
        //        if ((sender as Bunifu.UI.WinForms.BunifuButton.BunifuButton).Text.Equals("Start " + exam.ExamName + " Exam"))
        //        {
        //            /* code here*/



        //            /**/
        //            AttemptExamUtility.GetInstance().MakeReadyExam(exam.Id);
        //            Instructions.GetInstance().Show();
        //            this.Hide();
        //        }
        //    }
        //}

        private void ActivateButton(Button btn, UserControl screen)
        {
            DeactivateButton(btnActive);

            if (mainControl != null)
            {
                mainControl.Dispose();
                mainControl = null;
            }
            mainControl = screen;


            if (screen != null)
            {
                //screen.BringToFront();
                screen.Dock = DockStyle.Fill;
                screen.Visible = true;
                pnlMain.Controls.Add(screen);

            }


            btnActive = btn;
        }

        private void DeactivateButton(Button btn)
        {
            btnActive = null;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //empty the token
            LoginUtility.GetLoginUtility().LogoutUser();


            //token is emptied
            
            this.Hide();
            LoginForm.GetInstace().Show();

            Logger.log.Info("User has been logged out.");
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
            ActivateButton((Button)sender, new ProfilePanel());
            


            //ProfilePanel p = new ProfilePanel();
            //p.Dock = DockStyle.Fill;
            //p.BringToFront();
            //pnlMain.Controls.Add(p);
            ////p.SetProfile();
            
            //p.Show();
            
        }

        private void statusCheckingTimer_Tick(object sender, EventArgs e)
        {
            WifiStatusPanel.BackColor = Utility.MonitoringUtil.GetInstance().getStatusColor();
        }

        private void Dashboard2_VisibleChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("" + this.Visible);
            statusCheckingTimer.Enabled = this.Visible;
            if(this.Visible)
            {
                ActivateButton(btnProfile, new ProfilePanel());
            }
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            //pnlMain.Dispose();
            ActivateButton((Button)sender, new UserExamControl());
           // //pnlExams.Visible = !pnlExams.Visible;
           // UserExamControl ec = new UserExamControl();
           // ec.Dock = DockStyle.Fill;
           // UserExams e1 = new UserExams() { TopLevel = false, TopMost = true };
           //// e1.FormBorderStyle = FormBorderStyle.None;
           // //ec.BringToFront();
           // //ec.Visible = true;
           // //pnlMain.Controls.Add(ec);
           // //ec.Show();

        }

        private void btnCameraSettings_Click(object sender, EventArgs e)
        {
            ActivateButton((Button)sender, null);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SpikoDesktop.TestSettings.GetInstance(this).Show();
            ActivateButton((Button)sender, null);
        }

        private void Dashboard2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //if you want to do something
            Application.Exit();

        }
    }
}
