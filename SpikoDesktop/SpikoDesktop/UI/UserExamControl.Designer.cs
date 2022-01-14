
namespace SpikoDesktop.UI
{
    partial class UserExamControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPending = new System.Windows.Forms.TabPage();
            this.tabSubmitted = new System.Windows.Forms.TabPage();
            this.tabExpired = new System.Windows.Forms.TabPage();
            this.tabCompleted = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPending);
            this.tabControl1.Controls.Add(this.tabCompleted);
            this.tabControl1.Controls.Add(this.tabSubmitted);
            this.tabControl1.Controls.Add(this.tabExpired);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(463, 381);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPending
            // 
            this.tabPending.Location = new System.Drawing.Point(4, 22);
            this.tabPending.Margin = new System.Windows.Forms.Padding(2);
            this.tabPending.Name = "tabPending";
            this.tabPending.Padding = new System.Windows.Forms.Padding(2);
            this.tabPending.Size = new System.Drawing.Size(455, 355);
            this.tabPending.TabIndex = 0;
            this.tabPending.Text = "Pending";
            this.tabPending.UseVisualStyleBackColor = true;
            // 
            // tabSubmitted
            // 
            this.tabSubmitted.Location = new System.Drawing.Point(4, 22);
            this.tabSubmitted.Margin = new System.Windows.Forms.Padding(2);
            this.tabSubmitted.Name = "tabSubmitted";
            this.tabSubmitted.Padding = new System.Windows.Forms.Padding(2);
            this.tabSubmitted.Size = new System.Drawing.Size(455, 355);
            this.tabSubmitted.TabIndex = 1;
            this.tabSubmitted.Text = "Submitted";
            this.tabSubmitted.UseVisualStyleBackColor = true;
            // 
            // tabExpired
            // 
            this.tabExpired.Location = new System.Drawing.Point(4, 22);
            this.tabExpired.Margin = new System.Windows.Forms.Padding(2);
            this.tabExpired.Name = "tabExpired";
            this.tabExpired.Size = new System.Drawing.Size(455, 355);
            this.tabExpired.TabIndex = 2;
            this.tabExpired.Text = "Expired";
            this.tabExpired.UseVisualStyleBackColor = true;
            // 
            // tabCompleted
            // 
            this.tabCompleted.Location = new System.Drawing.Point(4, 22);
            this.tabCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.tabCompleted.Name = "tabCompleted";
            this.tabCompleted.Size = new System.Drawing.Size(455, 355);
            this.tabCompleted.TabIndex = 3;
            this.tabCompleted.Text = "Completed";
            this.tabCompleted.UseVisualStyleBackColor = true;
            // 
            // UserExamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UserExamControl";
            this.Size = new System.Drawing.Size(463, 381);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPending;
        private System.Windows.Forms.TabPage tabSubmitted;
        private System.Windows.Forms.TabPage tabExpired;
        private System.Windows.Forms.TabPage tabCompleted;
    }
}
