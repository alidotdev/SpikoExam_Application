using SpikoDesktop.Services.WebServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpikoDesktop.Utility;

namespace SpikoDesktop.UI
{
    public partial class UserExamControl : UserControl
    {
        Dashboard2 dashboard = Dashboard2.GetInstance();

        public UserExamControl()
        {

            InitializeComponent();

            //ExamWebService e = ExamWebService.GetService();
            AttemptExamUtility eUtil = AttemptExamUtility.GetInstance();
            
            for (int i = 0; i < 4; ++i)
            {
                TabPage tab = tabControl1.TabPages[i];
                Console.WriteLine(tab.Text);

                List<Exam> exams = eUtil.GetExamsByType(i);
                
                /*
                * 0 = pending
                * 1 = completed
                * 2 = submitted
                * 3 = expired
                */

                foreach (var e in exams)
                {
                    ExamCard card = new ExamCard(e);
                    card.Visible = true;
                    card.Dock = DockStyle.Top;
                    card.Visible = true;
                    tab.Controls.Add(card);
                }

            }

            


            //            int i = 0;
            //            foreach (var e in exams)
            //            {

            ////                dgPending.Rows.Add(e.ExamName, "Start Exam", e.Id.ToString());
            //                //Console.WriteLine(dgPending[0, 0].Value);
            //                //Console.WriteLine(dgPending[2, 0].Value);
            //                i++;
            //            }

        }

        /*private void dgPending_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int nr = dgPending.Rows.Count;
            int nc = dgPending.Columns.Count;
            Console.WriteLine($"{nr}\n{nc}");
            int c = e.ColumnIndex;
            if (c == 1)
            {
                int r = e.RowIndex;
                try
                {
                    int id = Convert.ToInt32(dgPending[2, r].Value.ToString());

                    Utility.AttemptExamUtility.GetInstance().MakeReadyExam(id);
                    Instructions.GetInstance().Show();
                    //*************************************************
                    dashboard.Hide();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.WriteLine(ex.StackTrace);
                    //throw;
                }

            }

        }*/
    }
}
