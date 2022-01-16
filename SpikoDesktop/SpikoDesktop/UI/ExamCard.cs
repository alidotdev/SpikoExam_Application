using SpikoDesktop.Services;
using SpikoDesktop.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.UI
{
    public partial class ExamCard : UserControl
    {
        public int id { get; set; }
        private Dashboard2 dashboard;
        public ExamCard(Exam e)
        {
            InitializeComponent();

            dashboard = Dashboard2.GetInstance();

            lblTitle.Text = e.ExamName;
            id = e.Id;

            /*
            * 0 = pending
            * 1 = completed
            * 2 = submitted
            * 3 = expired
            */
            switch (e.Status)
            {
                case 0:
                    btnAction.Text = "Start Exam";
                    btnAction.Show();
                    break;
                case 1:
                    btnAction.Hide();
                    break;
                case 2:
                    btnAction.Hide();
                    break;
                case 3:
                    btnAction.Hide();
                    break;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            Logger.log.Info("Exam Starting button clicked");
            if (MonitoringUtil.GetInstance().NetworkConnectionDetector())
            {
                Utility.AttemptExamUtility.GetInstance().MakeReadyExam(id);
                Logger.log.Info("Instruction page is going to show for exam starting.");
                Instructions.GetInstance().Show();
                //*************************************************
                dashboard.Hide();
            }
            else
            {
                Logger.log.Info("Exam could be started due to internet connection disability.");
                MessageBox.Show("Please check your Internet Connection");
            }
            
        }
    }
}
