using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpikoDesktop.UI
{
    class SpikoPanel : Bunifu.UI.WinForms.BunifuShadowPanel
    {
        private Label name;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn;
        public SpikoPanel(String title)
        {
            Size = new Size(614, 152);
            //BorderStyle = BorderStyle.None;
            BorderRadius = 1;
            BorderColor = Color.FloralWhite;
            
            //Label
            name = new Label();
            name.Location = new Point(16, 16);
            name.Size = new Size(104, 16);
            name.Text = title;
            //name.AutoSize = false;
            Location = new Point(43, 99 + 160);
            //bunifuPages1.TabPages[1].Controls.Add(p);

            //Button
            btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            btn.Text = "Start " + title + " Exam";
            btn.Location = new Point(460, 24);
            btn.Size = new Size(112, 36);
            btn.AutoRoundBorders = true;
            btn.IdleFillColor = Color.FromArgb(73, 92, 99);
            btn.onHoverState.FillColor = Color.FromArgb(132, 149, 156);
            btn.IdleBorderColor = Color.White;
            btn.onHoverState.BorderColor = Color.White;
            btn.Visible = true;
            
            //btn.Click += new System.EventHandler(this.ExamLoad);

            //Adding Controls
            Controls.Add(name);
            Controls.Add(btn);
        }
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton GetButton()
        {
            return btn;
        }
        public Label GetLabel()
        {
            return name;
        }
    }
}
