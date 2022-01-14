using SpikoDesktop.Services;
using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace SpikoDesktop
{
    public partial class ExamSubmittedForm : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        private static ExamSubmittedForm _instance;
        public static ExamSubmittedForm GetInstance(int attQues, int unAttQues)
        {
            if (_instance == null)
            {
                _instance = new ExamSubmittedForm();
            }
            _instance.UnAttemptedQuesLabel.Text = "Attempted Questions: " + attQues.ToString();
            _instance.AttemptedQuesLabel.Text = "UnAttempted Questions: " + unAttQues.ToString();
            return _instance;
        }

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


        public void setQues(int attQues, int unAttQues)
        {
            _instance.UnAttemptedQuesLabel.Text = "UnAttempted Questions: " + unAttQues.ToString();
            _instance.AttemptedQuesLabel.Text = "Attempted Questions: " + attQues.ToString();

        }


        private ExamSubmittedForm()
        {
            InitializeComponent();
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler((sender, e) => AvailabilityChangedCallback(sender, e));
            this.WindowState = FormWindowState.Maximized;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void SubmitExamButton_Click(object sender, EventArgs e)
        {
            Logger.log.Info("Exam submit button clicked");
            this.Hide();
            Dashboard2.GetInstance().Show();
        }

        public void enableBackButton()
        {
            Logger.log.Info("Exam submit button enabled");
            SubmitExamButton.Enabled = true;
        }

        private void statusCheckingTimer_Tick(object sender, EventArgs e)
        {
            WifiStatusPanel.BackColor = Utility.MonitoringUtil.GetInstance().getStatusColor();
        }

        private void ExamSubmittedForm_VisibleChanged(object sender, EventArgs e)
        {
            statusCheckingTimer.Enabled = this.Visible;
        }
    }
}
