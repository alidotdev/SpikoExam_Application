using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using SpikoDesktop.Utility;
using SpikoDesktop.UI;
using AForge.Video.DirectShow;

namespace SpikoDesktop
{
    public partial class DashboardForm : MaterialForm
    {
        private static DashboardForm _instance;

        public static DashboardForm GetInstance ()
        {
            if (_instance == null)
            {
                _instance = new DashboardForm();
            }
            _instance.bunifuPages1.SelectedIndex = 0;
            _instance.panel2.Hide();
            _instance.bunifuLabel4.Visible = false;
            _instance.bunifuLabel10.Visible = false;
            _instance.bunifuLabel8.Visible = false;
            _instance.bunifuLabel9.Visible = false;
            _instance.WifiStatusPanel.BackColor = MonitoringUtil.GetInstance().getStatusColor();

            return _instance;
        }

        public DashboardForm()
        {
            InitializeComponent();
            MaterialFormSetting();
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

        ////[Obsolete]
        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadTypedExam(bunifuLabel1, bunifuLabel4, 0, 1);
            LoadTypedExam(bunifuLabel5, bunifuLabel8, 1, 2);
            LoadTypedExam(bunifuLabel6, bunifuLabel9, 2, 3);
            LoadTypedExam(bunifuLabel7, bunifuLabel10, 3, 4);
        }

        //[Obsolete]
        private void LoadTypedExam(Bunifu.UI.WinForms.BunifuLabel c, Bunifu.UI.WinForms.BunifuLabel label, int type, int tabPaneIndex)
        {
            Control ctrl = c;
            bunifuPages1.TabPages[tabPaneIndex].AutoScroll = true;
            List<Exam> list = AttemptExamUtility.GetInstance().GetExamsByType(type);

            if (list.Count != 0)
            {
                label.Visible = false;
                for (int i = 0; i < list.Count; i++)
                {
                    SpikoPanel p = new SpikoPanel(list[i].ExamName);
                    p.Location = new Point(ctrl.Location.X, ctrl.Location.Y + ctrl.Height + 5);
                    p.GetButton().Click += new EventHandler(this.ExamLoad);
                    bunifuPages1.TabPages[tabPaneIndex].Controls.Add(p);
                    ctrl = p;
                }
            }
            else
            {
                label.Visible = true;
            }
        }

        //[Obsolete]
        private void ExamLoad(object sender, EventArgs e)
        {

            foreach (Exam exam in AttemptExamUtility.GetInstance().listOfExams)
            {
                if ((sender as Bunifu.UI.WinForms.BunifuButton.BunifuButton).Text.Equals("Start " + exam.ExamName + " Exam"))
                {
                    /* code here*/



                    /**/
                    AttemptExamUtility.GetInstance().MakeReadyExam(exam.Id);
                    Instructions.GetInstance().Show();
                    this.Hide();
                }
            }
        }

        private void bunifuButton3_Click_1(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                panel2.Visible = false;
            }
            else
            {
                panel2.Visible = true;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 1;
        }

        private void DashboardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void compBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 2;
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 3;
        }

        private void expiredBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 4;
        }

        private void pendiBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 1;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 3;
        }

        private void expireBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 4;
        }

        private void comBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 2;
        }

        private void penBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 1;
        }

        private void expirBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 4;
        }

        private void complBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 2;
        }

        private void submBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 3;
        }

        private void pendBtn_Click(object sender, EventArgs e)
        {
            bunifuPages1.SelectedIndex = 1;
        }

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {

        }
    }
}