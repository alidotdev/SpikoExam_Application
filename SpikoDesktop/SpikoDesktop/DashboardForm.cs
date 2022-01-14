using MaterialSkin;
using MaterialSkin.Controls;
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
using Bunifu.UI.WinForms;
using SpikoDesktop.Models;

namespace SpikoDesktop
{
    public partial class DashboardForm : MaterialForm
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme((Primary)2305844, (Primary)2305844, (Primary)2305844, (Accent)2305844, TextShade.WHITE);
           
            panel2.Hide();
        }
        private Control ctrl;

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            bunifuLabel4.Visible = false;
            string exams = File.ReadAllText(@"..\..\..\Program Files\exams.json");
            List<Exam> listOfExams =  <List<Exam>>(exams);
            bunifuPages1.TabPages[1].AutoScroll = true;
            //Point loc = bunifuLabel1.Location;
            bool pending = false;
            ctrl = bunifuLabel1;
            
            for (int i = 0; i < listOfExams.Count; i++)
            {
                if (String.Equals(listOfExams[i].Status, "Pending"))
                {
                    pending = true;
                    Bunifu.UI.WinForms.BunifuShadowPanel p = new BunifuShadowPanel();
                    p.Size = new Size(614, 152);
                    p.BorderStyle = BorderStyle.None;
                    //p.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    p.BorderRadius = 1;
                    p.BorderColor = Color.White;
                    p.BackColor = Color.White;
                    p.PanelColor = Color.FromArgb(78, 92, 81);
                    Label name = new Label();
                    name.Location = new Point(43, ctrl.Location.Y);
                    name.Size = new Size(104, 16);
                    name.Text = listOfExams[i].Name;
                    name.BackColor = Color.FromArgb(78, 92, 81);
                    name.ForeColor = Color.White;
                    //name.AutoSize = false;
                    p.Controls.Add(name);

                    p.Location = new Point(43, ctrl.Location.Y + ctrl.Height);
                    bunifuPages1.TabPages[1].Controls.Add(p);
                    //Bunifu.UI.WinForms.BunifuButton.BunifuButton btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
                    Button btn = new Button();
                    btn.Text = "Start " + listOfExams[i].Name + " Exam";
                    btn.Location = new Point(460, 24);
                    btn.Size = new Size(112, 36);
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.Black;
                    btn.Visible = true;
                    btn.Click += new System.EventHandler(this.ExamLoad);
                    p.Controls.Add(btn);
                    // ctrl = p;
                    bunifuLabel4.Visible = false;
                }
                if (pending == false)
                {
                    bunifuLabel4.Visible = true;
                }
            }

        }
        private void ExamLoad(object sender, EventArgs e)
        {
            //new QuestionsForm().Show();
            //this.Hide();
            string exams = File.ReadAllText(@"..\..\..\Program Files\exams.json");
            List<Exam> listOfExams = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Exam>>(exams);
            foreach (Exam yd in listOfExams)
            {
                if ((sender as Button).Text.Equals("Start " + yd.Name  + " Exam"))
                {
                    string ecat = File.ReadAllText(@"..\..\..\Program Files\" + yd.Name + ".json");
                    TextWriter txt = new StreamWriter(@"..\..\..\Program Files\Questions.json");
                    txt.Write(ecat);
                    txt.Close();
                    new QuestionsForm().Show();
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

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {

        }

      
    }
}
