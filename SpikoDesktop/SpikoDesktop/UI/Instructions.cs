using AForge.Video.DirectShow;
using MaterialSkin;
using MaterialSkin.Controls;
using SpikoDesktop.Models;
using SpikoDesktop.Utility;
using System;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Speech.Synthesis;
using System.Windows.Forms;

namespace SpikoDesktop.UI
{
    public partial class Instructions : MaterialForm
    {
        private static Instructions _instance;
        SpeechSynthesizer synth = new SpeechSynthesizer();

        //[Obsolete]
        public static Instructions GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Instructions();
            }
            _instance.WifiStatusPanel.BackColor = MonitoringUtil.GetInstance().getStatusColor();
            return _instance;
        }

        //[Obsolete]
        private Instructions()
        {
            InitializeComponent();
            MaterialFormSetting();
            //instructionBox.Text = Configuration.getInstance().getValue("Instruction");
            instructionBox.Text = File.ReadAllText(Configuration.getInstance().getValue("SavingPath") + "Instruction.txt");
            instructionBox.Font = new Font(instructionBox.Font.FontFamily, 16);
            instructionBox.Multiline = true;
            instructionBox.ReadOnly = true;
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler((sender, e) => AvailabilityChangedCallback(sender, e));

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
        private void MaterialFormSetting()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme((Primary)2305844, (Primary)2305844, (Primary)2305844, (Accent)2305844, TextShade.WHITE);
        }

        //[Obsolete]
        private void startExamBtn_Click(object sender, EventArgs e)
        {
            string cameraName = MonitoringUtil.GetInstance().GetCameraName();
            try
            {
                if (String.IsNullOrEmpty(cameraName))
                {
                    throw new Exception();
                }
                else
                {
                    QuestionsForm.videoCaptureDevice = new VideoCaptureDevice(cameraName);
                }
                new QuestionsForm().Show();
                Console.WriteLine("Showing question form");
                this.Hide();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                TestSettings.GetInstance(new QuestionsForm()).Show();
                this.Hide();
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard2.GetInstance().Show();
            this.Hide();
        }

    }
}
