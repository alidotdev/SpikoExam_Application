using SpikoDesktop.Services;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SpikoDesktop
{
    public partial class PicturePopUp : Form
    {

        #region singleton class
        private static PicturePopUp instance = null;
        private static Form Formbg = null;

        public static PicturePopUp GetInstance()
        {
            Logger.log.Info("PicturePop form instance is called without parameter");
            return instance;
        }

        public static PicturePopUp GetInstance (String question, Image image, Point Location)
        {
            Logger.log.Info("PicturePop form instance is called with parameter");
            if (instance == null)
            {
                instance = new PicturePopUp();

                Formbg = new Form();
                Formbg.WindowState = FormWindowState.Maximized;
                Formbg.BackColor = Color.Black;
                Formbg.Enabled = false;
                Formbg.StartPosition = FormStartPosition.Manual;
                Formbg.FormBorderStyle = FormBorderStyle.None;
                Formbg.Opacity = .7d;
                Formbg.TopMost = true;
                Formbg.Location = Location;
                Formbg.ShowInTaskbar = false;
                Formbg.Click += new EventHandler(Formbg_Click);
                Formbg.DoubleClick += new EventHandler(Formbg_Click);
            }
            
            Formbg.Show();
            
            if (String.IsNullOrEmpty(question))
            {
                instance.txtQuestion.Hide();
            }
            else
            {
                instance.txtQuestion.Show();
                instance.txtQuestion.Text = question;


                string[] s = instance.txtQuestion.Text.Split('\n');
                if (instance.txtQuestion.Text.Length > 162 || s.Length > 1 && instance.txtQuestion.Size.Height < 155)
                {
                    instance.SetSizeOfTextBox(instance.txtQuestion.Text.Length, s.Length - 1);
                }
            }

            instance.CenterToScreen();
            instance.qPicture.Image = image;

            return instance;
        }


        #endregion

        #region For dragging without the title bar
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void PicturePopUp_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateDragging();
        }
        #endregion


        private PicturePopUp()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Alt|Keys.F4) )
            {
                Logger.log.Info("Alt + F4 key is pressed");
                return true;
            }
            return false;
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

                txtQuestion.Size = new Size(789, txtQuestion.Size.Height + 14 * 2);

            }
        }



        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            Logger.log.Info("Cancel button is clicked");
            DisposePicture();
            //this.Hide();
            //QuestionsForm.disposeFormbg();
            //Owner.Hide();
        }

        private void qPicture_MouseDown(object sender, MouseEventArgs e)
        {
            ActivateDragging();
        }

        private void ActivateDragging()
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private static void Formbg_Click(object sender, EventArgs e)
        {
            //PicturePopUp popUp = PicturePopUp.GetInstance();
            //if (popUp != null)
            //    popUp.BringToFront();
            Logger.log.Info("Background form has been clicked");
            DisposePicture();
        }
        public static void DisposePicture()
        {
            Formbg.Hide();
            if (PicturePopUp.GetInstance() != null)
                PicturePopUp.GetInstance().Hide();
            //Logger.log.Info("");
        }

        internal static void ShowBgForm()
        {
            Formbg.Show();
        }
    }
}
