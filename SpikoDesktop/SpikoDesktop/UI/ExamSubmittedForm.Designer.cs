
namespace SpikoDesktop
{
    partial class ExamSubmittedForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamSubmittedForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.AttemptedQuesLabel = new System.Windows.Forms.Label();
            this.UnAttemptedQuesLabel = new System.Windows.Forms.Label();
            this.SubmitExamButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.WifiStatusPanel = new System.Windows.Forms.Panel();
            this.WifiStatusLabel = new System.Windows.Forms.Label();
            this.statusCheckingTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // AttemptedQuesLabel
            // 
            this.AttemptedQuesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AttemptedQuesLabel.AutoSize = true;
            this.AttemptedQuesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AttemptedQuesLabel.ForeColor = System.Drawing.Color.Black;
            this.AttemptedQuesLabel.Location = new System.Drawing.Point(60, 84);
            this.AttemptedQuesLabel.Name = "AttemptedQuesLabel";
            this.AttemptedQuesLabel.Size = new System.Drawing.Size(164, 21);
            this.AttemptedQuesLabel.TabIndex = 1;
            this.AttemptedQuesLabel.Text = "Attempted Questions: ";
            // 
            // UnAttemptedQuesLabel
            // 
            this.UnAttemptedQuesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UnAttemptedQuesLabel.AutoSize = true;
            this.UnAttemptedQuesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnAttemptedQuesLabel.ForeColor = System.Drawing.Color.Black;
            this.UnAttemptedQuesLabel.Location = new System.Drawing.Point(346, 84);
            this.UnAttemptedQuesLabel.Name = "UnAttemptedQuesLabel";
            this.UnAttemptedQuesLabel.Size = new System.Drawing.Size(184, 21);
            this.UnAttemptedQuesLabel.TabIndex = 2;
            this.UnAttemptedQuesLabel.Text = "UnAttempted Questions: ";
            // 
            // SubmitExamButton
            // 
            this.SubmitExamButton.AllowAnimations = true;
            this.SubmitExamButton.AllowMouseEffects = true;
            this.SubmitExamButton.AllowToggling = false;
            this.SubmitExamButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubmitExamButton.AnimationSpeed = 200;
            this.SubmitExamButton.AutoGenerateColors = false;
            this.SubmitExamButton.AutoRoundBorders = true;
            this.SubmitExamButton.AutoSizeLeftIcon = true;
            this.SubmitExamButton.AutoSizeRightIcon = true;
            this.SubmitExamButton.BackColor = System.Drawing.Color.Transparent;
            this.SubmitExamButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubmitExamButton.BackgroundImage")));
            this.SubmitExamButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SubmitExamButton.ButtonText = "Go to Dashboard";
            this.SubmitExamButton.ButtonTextMarginLeft = 0;
            this.SubmitExamButton.ColorContrastOnClick = 45;
            this.SubmitExamButton.ColorContrastOnHover = 45;
            this.SubmitExamButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.SubmitExamButton.CustomizableEdges = borderEdges3;
            this.SubmitExamButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SubmitExamButton.DisabledBorderColor = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.DisabledFillColor = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.DisabledForecolor = System.Drawing.Color.White;
            this.SubmitExamButton.Enabled = false;
            this.SubmitExamButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SubmitExamButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubmitExamButton.ForeColor = System.Drawing.Color.White;
            this.SubmitExamButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SubmitExamButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SubmitExamButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SubmitExamButton.IconMarginLeft = 11;
            this.SubmitExamButton.IconPadding = 10;
            this.SubmitExamButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SubmitExamButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SubmitExamButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SubmitExamButton.IconSize = 25;
            this.SubmitExamButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.IdleBorderRadius = 25;
            this.SubmitExamButton.IdleBorderThickness = 1;
            this.SubmitExamButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.IdleIconLeftImage = null;
            this.SubmitExamButton.IdleIconRightImage = null;
            this.SubmitExamButton.IndicateFocus = false;
            this.SubmitExamButton.Location = new System.Drawing.Point(32, 327);
            this.SubmitExamButton.Name = "SubmitExamButton";
            this.SubmitExamButton.OnDisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.OnDisabledState.BorderRadius = 1;
            this.SubmitExamButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SubmitExamButton.OnDisabledState.BorderThickness = 1;
            this.SubmitExamButton.OnDisabledState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.SubmitExamButton.OnDisabledState.IconLeftImage = null;
            this.SubmitExamButton.OnDisabledState.IconRightImage = null;
            this.SubmitExamButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SubmitExamButton.onHoverState.BorderRadius = 1;
            this.SubmitExamButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SubmitExamButton.onHoverState.BorderThickness = 1;
            this.SubmitExamButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SubmitExamButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SubmitExamButton.onHoverState.IconLeftImage = null;
            this.SubmitExamButton.onHoverState.IconRightImage = null;
            this.SubmitExamButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.OnIdleState.BorderRadius = 1;
            this.SubmitExamButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SubmitExamButton.OnIdleState.BorderThickness = 1;
            this.SubmitExamButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SubmitExamButton.OnIdleState.IconLeftImage = null;
            this.SubmitExamButton.OnIdleState.IconRightImage = null;
            this.SubmitExamButton.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.OnPressedState.BorderRadius = 1;
            this.SubmitExamButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SubmitExamButton.OnPressedState.BorderThickness = 1;
            this.SubmitExamButton.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SubmitExamButton.OnPressedState.IconLeftImage = null;
            this.SubmitExamButton.OnPressedState.IconRightImage = null;
            this.SubmitExamButton.Size = new System.Drawing.Size(124, 27);
            this.SubmitExamButton.TabIndex = 10;
            this.SubmitExamButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SubmitExamButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubmitExamButton.TextMarginLeft = 0;
            this.SubmitExamButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SubmitExamButton.UseDefaultRadiusAndThickness = true;
            this.SubmitExamButton.Click += new System.EventHandler(this.SubmitExamButton_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Exam Submitted Successfully !!!";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges4;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(122, 243);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnDisabledState.BorderRadius = 1;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 1;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.BorderRadius = 1;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnPressedState.BorderRadius = 1;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(383, 46);
            this.bunifuButton1.TabIndex = 11;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // WifiStatusPanel
            // 
            this.WifiStatusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WifiStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.WifiStatusPanel.Location = new System.Drawing.Point(574, 9);
            this.WifiStatusPanel.Name = "WifiStatusPanel";
            this.WifiStatusPanel.Size = new System.Drawing.Size(17, 14);
            this.WifiStatusPanel.TabIndex = 13;
            // 
            // WifiStatusLabel
            // 
            this.WifiStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WifiStatusLabel.AutoSize = true;
            this.WifiStatusLabel.Location = new System.Drawing.Point(509, 9);
            this.WifiStatusLabel.Name = "WifiStatusLabel";
            this.WifiStatusLabel.Size = new System.Drawing.Size(61, 13);
            this.WifiStatusLabel.TabIndex = 12;
            this.WifiStatusLabel.Text = "Wifi Status:";
            // 
            // statusCheckingTimer
            // 
            this.statusCheckingTimer.Interval = 10000;
            this.statusCheckingTimer.Tick += new System.EventHandler(this.statusCheckingTimer_Tick);
            // 
            // ExamSubmittedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(602, 409);
            this.Controls.Add(this.WifiStatusPanel);
            this.Controls.Add(this.WifiStatusLabel);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.SubmitExamButton);
            this.Controls.Add(this.UnAttemptedQuesLabel);
            this.Controls.Add(this.AttemptedQuesLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExamSubmittedForm";
            this.Text = "ExamSubmittedForm";
            this.VisibleChanged += new System.EventHandler(this.ExamSubmittedForm_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label AttemptedQuesLabel;
        private System.Windows.Forms.Label UnAttemptedQuesLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SubmitExamButton;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        public System.Windows.Forms.Panel WifiStatusPanel;
        private System.Windows.Forms.Label WifiStatusLabel;
        private System.Windows.Forms.Timer statusCheckingTimer;
    }
}