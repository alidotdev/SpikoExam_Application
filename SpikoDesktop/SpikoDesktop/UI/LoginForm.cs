using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SpikoDesktop.Utility;
using AForge.Video.DirectShow;
using System.IO;
using SpikoDesktop.Services;
using SpikoDesktop.Models;
using RestSharp;
using SpikoDesktop.Services.WebServices;
using System.Speech.Synthesis;
using System.Net.NetworkInformation;

namespace SpikoDesktop
{
    public partial class LoginForm : Form
    {
        private Control focused;
        private static LoginForm _instance;
        ProfileUtility p = ProfileUtility.GetInstance();
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public static LoginForm GetInstace()
        {
            
            if (_instance == null)
            {

                _instance = new LoginForm();

            }
            
            _instance.txtEmail.Focus();

            return _instance;
        }
        private LoginForm()
        {
            InitializeComponent();
            NetworkChange.NetworkAvailabilityChanged += new NetworkAvailabilityChangedEventHandler((sender, e) => AvailabilityChangedCallback(sender, e));
            ConfigurationHardCode f = new ConfigurationHardCode();
            f.BasicTemplateChecker();


            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            string baseUrl = Configuration.getInstance().getValue("BaseUrl");
            //MessageBox.Show("1...." + baseUrl);
            baseUrlLabel.Text = baseUrl;

            progressBar2.Visible = false;
            //baseUrlLabel.Text = Configuration.getInstance().getValue("BaseUrl");
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void LoginContentPanel_Click(object sender, EventArgs e)
        {
            this.LoginContentPanel.Select();
            txtEmail.BorderThickness = 1;
            txtPassword.BorderThickness = 1;
            if (txtEmail.PlaceholderText == "")
            {
                txtEmail.PlaceholderText = "Email";
            }
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PlaceholderText = "Password";
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Logger.log.Info("Application Close button clicked");
            Application.Exit();
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            TextEmailActive();
        }

        private void TextEmailActive()
        {
            CrdentialsLabel.Visible = false;
            txtEmail.BorderThickness = 2;
            EmailCredentialLabel.Visible = false;
            if (txtEmail.PlaceholderText == "Email")
            {
                txtEmail.PlaceholderText = "";
            }
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PlaceholderText = "Password";
            }
        }

        private void ClearingCredentials()
        {
            CrdentialsLabel.Visible = false;
            txtEmail.BorderThickness = 2;
            EmailCredentialLabel.Visible = false;
            txtEmail.Text = "";
            txtPassword.Text = "";
            txtEmail.Focus();
            if (txtEmail.PlaceholderText == "Email")
            {
                txtEmail.PlaceholderText = "";
            }
            if (txtPassword.Text == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PlaceholderText = "Password";
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            TextPasswordActive();
        }

        private void TextPasswordActive()
        {
            CrdentialsLabel.Visible = false;
            txtPassword.BorderThickness = 2;
            PasswordCredentialLabel.Visible = false;
            txtPassword.UseSystemPasswordChar = !showPassCheckbox.Checked;
            if (txtPassword.PlaceholderText == "Password")
            {
                txtPassword.PlaceholderText = "";
            }
            if (txtEmail.PlaceholderText == "")
            {
                txtEmail.PlaceholderText = "Email";
            }
        }

        private async void LoginButton_Click(object sender, EventArgs e)
        {

            Logger.log.Info("Login button clicked");
            progressBar2.Visible = true;
            LoginButton.Enabled = false;
            CrdentialsLabel.Visible = false;
            if (txtEmail.Text.Trim() == "")
            {
                EmailCredentialLabel.Text = "The Email Field is Required";
                txtEmail.PlaceholderText = "Email";
                EmailCredentialLabel.Visible = true;
                ActiveFocus();
            }
            if (txtPassword.Text.Trim() == "")
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.PlaceholderText = "Password";
                PasswordCredentialLabel.Text = "The Password field is Required";
                PasswordCredentialLabel.Visible = true;
                ActiveFocus();
            }

            if (EmailCredentialLabel.Visible == false && PasswordCredentialLabel.Visible == false)
            {
                /*if (txtEmail.Text.Equals("Admin") && txtPassword.Text.Equals("Admin_ST"))
                {
                    Logger.log.Info("Admin has login");
                    new UI.AdminForm_ST().Show();
                    this.Hide();
                }*/
                if (MonitoringUtil.GetInstance().NetworkConnectionDetector())
                {
                    var res = await LoginWebService.GetService().LoginUser(txtEmail.Text, txtPassword.Text);

                    if (res.status)
                    {

                        var client = new RestClient(Configuration.getInstance().getValue("BaseUrl") + "api/User/Profile");
                        client.Timeout = -1;
                        var request = new RestRequest(Method.GET);
                        request.AddHeader("Content-Type", "application/json");
                        request.AddHeader("Authorization", "bearer " + File.ReadAllText("Token.txt"));
                        IRestResponse response = client.Execute(request);
                        Console.WriteLine(response.Content);
                        p.currentProfile = Crypto.DeserializeJsonObject<Profile>(response.Content);
                        //MessageBox.Show("Current Profile : " + p.currentProfile.UserName);
                        ProfileService.GetInstance().CreatProfile(p.currentProfile);
                        if (p.currentProfile != null && p.currentProfile.UserRole == "Student")
                        {
                            NormalWorking();
                        }
                        else
                        {
                            MessageBox.Show("Only Students can login to this application");
                            ClearingCredentials();
                        }
                    }
                    else
                    {
                        CrdentialsLabel.Visible = true;
                        ActiveFocus();
                    }
                }
                else
                {
                    bool flag = false;
                    //MessageBox.Show("Internet is off");
                    DirectoryInfo folderInWichToSearch = new DirectoryInfo(Configuration.getInstance().getValue("UsersBasePath"));
                    FileSystemInfo[] filesAndDirs = folderInWichToSearch.GetFileSystemInfos("*");

                    foreach (FileSystemInfo foundFile in filesAndDirs)
                    {
                        if (txtEmail.Text.ToLower() == foundFile.Name.ToLower())
                        {
                            p.currentProfile = ProfileService.GetInstance().GetProfile(txtEmail.Text.ToLower());
                            flag = true;
                            //MessageBox.Show("Folder is found");
                            if (p.currentProfile.UserRole == "Student")
                            {
                                NormalWorking();
                            }
                            else
                            {
                                MessageBox.Show("Only students can login to this page.");
                                ClearingCredentials();
                            }
                        }

                    }
                    if (flag == false)
                    {
                        MessageBox.Show("Please check your Internet Connection");
                        ClearingCredentials();
                    }
                }

            }
            progressBar2.Visible = false;
            LoginButton.Enabled = true;
        }

        private void ActiveFocus()
        {
            txtEmail.BorderThickness = 2;
            txtEmail.SelectionStart = txtEmail.Text.Length;
            txtEmail.SelectionLength = 0;
            this.ActiveControl = txtEmail;
            txtEmail.Focus();
        }

        private void NormalWorking()
        {
            p.currentProfile = ProfileService.GetInstance().GetProfile(txtEmail.Text.ToLower());

            //MessageBox.Show("Name : " + p.currentProfile.FirstName + "\nLast Name : " + p.currentProfile.LastName +
            // "\nEmail : " + p.currentProfile.EmailId + "\nUser Role : " + p.currentProfile.UserRole + "\nUser Name : "
            //+ p.currentProfile.UserName);

            try
            {
                string cameraName = MonitoringUtil.GetInstance().GetCameraName();
                //MessageBox.Show(cameraName);

                if (String.IsNullOrEmpty(cameraName))
                {
                    Logger.log.Error("Camera name is empty");
                    throw new Exception();
                }
                else if (QuestionsForm.videoCaptureDevice == null)
                {
                    QuestionsForm.videoCaptureDevice = new VideoCaptureDevice(cameraName);
                }
                this.Hide();

                Logger.log.Info("Showing DashBoard Form");
                Dashboard2.GetInstance().Show();
                

                //new QuestionsForm().Show();


            }
            catch (Exception ex)
            {

                //Logger.log.Error(ex.ToString());
                this.Hide();
                TestSettings.GetInstance(this).Show();
                Logger.log.Info("Camera setting has opened");
            }
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            Logger.log.Info("Maximized button clicked");
            if (this.WindowState != FormWindowState.Maximized)
            {
                if (focused != null)
                {
                    focused.Focus();
                }
                ChangeComponentsOnMaximize();
                this.WindowState = FormWindowState.Maximized;
                Logger.log.Info("Window has been maximized");
            }
            else
            {
                if (focused != null)
                {
                    focused.Focus();
                }
                ChangeComponentsOnMinimize();
                this.WindowState = FormWindowState.Normal;
                Logger.log.Info("Window has been normalized");
            }
        }

        private void ChangeComponentsOnMaximize()
        {
            this.LoginFormEllipse.ElipseRadius = 0;
            SetLocation(this.showPassCheckbox, -145, 87, "Maximzie");
            SetLocation(this.checkBoxLabel, -145, 87, "Maximzie");
            SetLocation(this.LogoPictureBox, 0, -50, "Maximize");
            SetLocation(this.LogoTitle, -30, -50, "Maximize");
            SetLocation(this.EmailCredentialLabel, -60, -50, "Maximize");
            SetLocation(this.txtEmail, -60, -50, "Maximize");
            SetLocation(this.PasswordCredentialLabel, -60, -50, "Maximize");
            SetLocation(this.txtPassword, -60, -50, "Maximize");
            SetLocation(this.LoginButton, -60, -30, "Maximize");
            SetLocation(this.CrdentialsLabel, 25, -40, "Maximize");
            LogoTitle.Font = new Font("Segoe UI", 16);
            SetSize(this.txtEmail, 150, 0, "Maximize");
            SetSize(this.txtPassword, 150, 0, "Maximize");
            SetSize(this.LoginButton, 150, 0, "Maximize");
        }

        private void ChangeComponentsOnMinimize()
        {
            this.LoginFormEllipse.ElipseRadius = 5;
            SetLocation(this.showPassCheckbox, 145, -87, "Minimzie");
            SetLocation(this.checkBoxLabel, 145, -87, "Minimzie");
            SetLocation(this.LogoPictureBox, 0, -50, "Minimize");
            SetLocation(this.LogoTitle, -30, -50, "Minimize");
            SetLocation(this.EmailCredentialLabel, -60, -50, "Minimize");
            SetLocation(this.txtEmail, -60, -50, "Minimize");
            SetLocation(this.PasswordCredentialLabel, -60, -50, "Minimize");
            SetLocation(this.txtPassword, -60, -50, "Minimize");
            SetLocation(this.LoginButton, -60, -30, "Minimize");
            SetLocation(this.CrdentialsLabel, 25, -40, "Minimize");
            LogoTitle.Font = new Font("Segoe UI", 11);
            SetSize(this.txtEmail, 150, 0, "Minimize");
            SetSize(this.txtPassword, 150, 0, "Minimize");
            SetSize(this.LoginButton, 150, 0, "Minimize");
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SetLocation(object sender, int locX, int locY, string msg)
        {
            int x = ((Control)sender).Location.X;
            int y = ((Control)sender).Location.Y;
            if (msg == "Maximize")
            {
                ((Control)sender).Location = new Point(x + locX, y + locY);
            }
            else
            {
                ((Control)sender).Location = new Point(x - locX, y - locY);
            }
        }

        private void SetSize(object sender, int incX, int incY, string msg)
        {
            int width = ((Control)sender).Width;
            int height = ((Control)sender).Height;
            if (msg == "Maximize")
            {
                ((Control)sender).Width = width + incX;
                ((Control)sender).Height = height + incY;
            }
            else
            {
                ((Control)sender).Width = width - incX;
                ((Control)sender).Height = height - incY;
            }
        }

        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private int CheckEmail()
        {
            return LoginUtility.GetLoginUtility().CheckEmail(txtEmail.Text);
        }

        private void LoginForm3_Load(object sender, EventArgs e)
        {
            txtEmail.BorderThickness = 2;
            this.ActiveControl = txtEmail;
            txtEmail.Focus();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                if (txtEmail.Text == "")
                {
                    EmailCredentialLabel.Text = "The Email Field is Required";
                    EmailCredentialLabel.Visible = true;
                }
                TextPasswordActive();
                e.SuppressKeyPress = true;
                txtPassword.SelectionStart = txtPassword.Text.Length;
                txtPassword.SelectionLength = 0;
                this.ActiveControl = txtPassword;
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                LoginButton.PerformClick();
            }
        }

        private void txtEmail_GotFocus(object sender, EventArgs e)
        {
            txtPassword.BorderThickness = 1;
            focused = (Control)sender;
        }

        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            txtEmail.BorderThickness = 1;
            focused = (Control)sender;
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextEmailActive();
        }

        private void showPassCheckbox_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (focused != null)
            {
                focused.Focus();
            }
            txtPassword.SelectionStart = txtPassword.Text.Length;
            txtPassword.SelectionLength = 0;
            ShowPassword();
        }

        private void ShowPassword()
        {
            if (showPassCheckbox.Checked == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                if (txtPassword.Text != "")
                {
                    txtPassword.UseSystemPasswordChar = true;
                }
            }
        }

        private void checkBoxLabel_Click(object sender, EventArgs e)
        {
            if (showPassCheckbox.Checked == true)
            {
                showPassCheckbox.Checked = false;
            }
            else
            {
                showPassCheckbox.Checked = true;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            ShowPassword();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab)
            {
                if (focused.Name == "txtEmail")
                {
                    TextPasswordActive();
                    if (txtEmail.Text.Trim() == "")
                    {
                        EmailCredentialLabel.Visible = true;
                    }
                }
                if (focused.Name == "txtPassword")
                {
                    LoginButton.PerformClick();
                    return true;
                }
            }
            else if (keyData == (Keys.Alt | Keys.F4))
            {
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void LoginContentPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {

                txtEmail.Text = "";
                txtEmail.PlaceholderText = "Email";
                txtPassword.Text = "";
                txtPassword.TextPlaceholder = "Password";
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;

                EmailCredentialLabel.Visible = false;
                PasswordCredentialLabel.Visible = false;
                CrdentialsLabel.Visible = false;
                ChangeComponentsOnMaximize();
                WindowState = FormWindowState.Maximized;

            }
        }

        private void AvailabilityChangedCallback(object sender, NetworkAvailabilityEventArgs e)
        {
            //synth.Speak("I am in function of network checking");
            if (e.IsAvailable)
            {
                //synth.Speak("Network is available");   
            }
            else
            {
                //synth.Speak("Network is not available");
            }
        }
    }
}
