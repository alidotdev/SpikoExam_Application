using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using SpikoDesktop.Models;
using SpikoDesktop.Services;

namespace SpikoDesktop
{
    public partial class TestSettings : DrakeUI.Framework.UIMainForm
    {
        //Image img = null;
       
        private static TestSettings _instance;
        private Form f;

        public static TestSettings GetInstance (Form f)
        {
            //MessageBox.Show("I am in GetInstance function");
            Logger.log.Info("I am in test setting function");
            if (_instance == null)
            {
                _instance = new TestSettings();
            }
            _instance.f = f;
            return _instance;
        }
        private TestSettings()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            //MessageBox.Show("i AM in FORM 1");
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        //VideoCaptureDevice videoCapture;


        //NewFrameEventArgs eventArgs1 = null;
        static Bitmap img = null;
        // static Bitmap img1 = null;
        private void videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //MessageBox.Show("I ma in btn_Click event");
            img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = img;
            //  img1 = img;
            //pic.Image.Save("Screen.png");
            //img = (Bitmap)pic.Image;
            //img = pic.Image;
            //img = (Bitmap)eventArgs.Frame.Clone();
            //eventArgs1 = eventArgs;

            //pic.Image = (Bitmap)eventArgs.Frame.Clone();
            //img = (Bitmap)eventArgs.Frame.Clone();
            //pic.Image = img;

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (cboCamera.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose the camera first.");
            }
            else
            {
                ProgressBar loading = ProgressBar.GetInstance();
                loading.Show();

                Logger.log.Info("Next button clicked on camera setting form");
                videoCaptureDevice.Stop();
                QuestionsForm.videoCaptureDevice = videoCaptureDevice;

                Logger.log.Info("Selected camera name is "+filterInfoCollection[cboCamera.SelectedIndex].Name);
                StreamWriter writer = new StreamWriter(Configuration.getInstance().getValue("SavingPath") + "CameraName.txt");
                writer.WriteLine(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                writer.Close();

                this.Hide();
                Dashboard2.GetInstance().Show();
                //if (f == null)

                //else 
                //    f.Show();
                //f.WindowState = FormWindowState.Maximized;
                //this.Hide();
                //loading.Hide();

            }
        }

        private void cboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCamera.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose the camera first.");
            }
            else
            {
                if (videoCaptureDevice != null)
                {
                    videoCaptureDevice.Stop();
                }

                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += videoCaptureDevice_NewFrame;
                videoCaptureDevice.ProvideSnapshots = false;
                videoCaptureDevice.Start();
            }
        }

        private void TestSettings_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboCamera.Items.Add(filterInfo.Name);
                //cboCamera.SelectedIndex = 0;

                videoCaptureDevice = new VideoCaptureDevice();
            }
            cboCamera.SelectedIndex = -1;
        }

        private void TestSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice != null)
                videoCaptureDevice.Stop();
            Logger.log.Info("Application is closing from camera setting form");
            Application.Exit();
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Logger.log.Info("Clipboard history setting page is opened");
            Process.Start("ms-settings:clipboard");
        }

        private void TestSettings_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                cboCamera.SelectedIndex = -1;
            }
        }
    }
}