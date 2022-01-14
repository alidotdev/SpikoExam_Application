
namespace SpikoDesktop
{
    partial class PicturePopUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.qPicture = new System.Windows.Forms.PictureBox();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.qPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qPicture
            // 
            this.qPicture.BackColor = System.Drawing.Color.White;
            this.qPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.qPicture.Location = new System.Drawing.Point(25, 60);
            this.qPicture.Name = "qPicture";
            this.qPicture.Size = new System.Drawing.Size(750, 335);
            this.qPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qPicture.TabIndex = 2;
            this.qPicture.TabStop = false;
            this.qPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.qPicture_MouseDown);
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.White;
            this.txtQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txtQuestion.Location = new System.Drawing.Point(25, 25);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(750, 35);
            this.txtQuestion.TabIndex = 4;
            this.txtQuestion.Text = "Question: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.materialFlatButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(25, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 45);
            this.panel1.TabIndex = 5;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Font = new System.Drawing.Font("Century", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialFlatButton1.Location = new System.Drawing.Point(344, 3);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(64, 36);
            this.materialFlatButton1.TabIndex = 6;
            this.materialFlatButton1.Text = "Cancel";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // PicturePopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qPicture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQuestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PicturePopUp";
            this.Padding = new System.Windows.Forms.Padding(25, 25, 25, 10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PicturePopUp";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicturePopUp_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.qPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox qPicture;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}