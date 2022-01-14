using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop
{
    public partial class ProgressBar : UserControl
    {
        private static ProgressBar _instance = null;

        public static ProgressBar GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ProgressBar();
            }
            return _instance;
        }
        public ProgressBar()
        {
            InitializeComponent();
            _instance = this;
            timer2.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.timer1.Enabled = false;
            //panel2.Location = new Point(panel2.Location.X, panel2.Location.Y+3);
            panel2.Width += 3;
            if(panel2.Width >= 443)
            {
                panel2.Width = 30;
            }
            this.timer1.Enabled = true;
            this.timer1.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.timer2.Stop();
            this.timer2.Enabled = false;
            if (LoadingLabel.Text == "Loading.")
            {
                LoadingLabel.Text = "Loading..";
            }
            else if (LoadingLabel.Text == "Loading..")
            {
                LoadingLabel.Text = "Loading...";
            }
            else
            {
                LoadingLabel.Text = "Loading.";
            }
            this.timer2.Enabled = true;
            this.timer2.Start();
        }
        private void ProgressBar_VisibleChanged(object sender, EventArgs e)
        {
            bool flag = this.Visible;
            timer1.Enabled = timer2.Enabled = this.Visible;
            //MessageBox.Show("" + flag);
        }

    }
}
