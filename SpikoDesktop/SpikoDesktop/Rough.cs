using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop
{
    public partial class Rough : Form
    {
        public Rough()
        {
            //Clipboard.Clear();
            InitializeComponent();

            MessageBox.Show(""+SystemInformation.WorkingArea);
            
        }
        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Process.Start("ms-settings:clipboard");
        }
    }
}
