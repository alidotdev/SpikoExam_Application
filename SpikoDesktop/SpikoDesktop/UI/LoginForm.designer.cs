
namespace SpikoDesktop
{
    partial class LoginForm
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.LoginFormEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LoginButtonEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LoginButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LoginContentPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.baseUrlLabel = new System.Windows.Forms.Label();
            this.progressBar2 = new SpikoDesktop.ProgressBar();
            this.checkBoxLabel = new System.Windows.Forms.Label();
            this.showPassCheckbox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.CrdentialsLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.ControlPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.MaximizeButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.PasswordCredentialLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.EmailCredentialLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txtEmail = new Bunifu.UI.WinForms.BunifuTextBox();
            this.LogoTitle = new Bunifu.UI.WinForms.BunifuLabel();
            this.LogoPictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LoginContentPanel.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginFormEllipse
            // 
            this.LoginFormEllipse.ElipseRadius = 5;
            this.LoginFormEllipse.TargetControl = this;
            // 
            // LoginButtonEllipse
            // 
            this.LoginButtonEllipse.ElipseRadius = 5;
            this.LoginButtonEllipse.TargetControl = this.LoginButton;
            // 
            // LoginButton
            // 
            this.LoginButton.AllowAnimations = true;
            this.LoginButton.AllowMouseEffects = true;
            this.LoginButton.AllowToggling = false;
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginButton.AnimationSpeed = 200;
            this.LoginButton.AutoGenerateColors = false;
            this.LoginButton.AutoRoundBorders = false;
            this.LoginButton.AutoSizeLeftIcon = true;
            this.LoginButton.AutoSizeRightIcon = true;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginButton.ButtonText = "Login";
            this.LoginButton.ButtonTextMarginLeft = 0;
            this.LoginButton.ColorContrastOnClick = 45;
            this.LoginButton.ColorContrastOnHover = 45;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.LoginButton.CustomizableEdges = borderEdges1;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoginButton.DisabledBorderColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.DisabledFillColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.DisabledForecolor = System.Drawing.Color.White;
            this.LoginButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LoginButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LoginButton.IconMarginLeft = 11;
            this.LoginButton.IconPadding = 10;
            this.LoginButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LoginButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LoginButton.IconSize = 25;
            this.LoginButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.IdleBorderRadius = 1;
            this.LoginButton.IdleBorderThickness = 1;
            this.LoginButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.IdleIconLeftImage = null;
            this.LoginButton.IdleIconRightImage = null;
            this.LoginButton.IndicateFocus = false;
            this.LoginButton.Location = new System.Drawing.Point(40, 581);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.OnDisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.OnDisabledState.BorderRadius = 1;
            this.LoginButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginButton.OnDisabledState.BorderThickness = 1;
            this.LoginButton.OnDisabledState.FillColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.LoginButton.OnDisabledState.IconLeftImage = null;
            this.LoginButton.OnDisabledState.IconRightImage = null;
            this.LoginButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LoginButton.onHoverState.BorderRadius = 1;
            this.LoginButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginButton.onHoverState.BorderThickness = 1;
            this.LoginButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LoginButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LoginButton.onHoverState.IconLeftImage = null;
            this.LoginButton.onHoverState.IconRightImage = null;
            this.LoginButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.OnIdleState.BorderRadius = 1;
            this.LoginButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginButton.OnIdleState.BorderThickness = 1;
            this.LoginButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LoginButton.OnIdleState.IconLeftImage = null;
            this.LoginButton.OnIdleState.IconRightImage = null;
            this.LoginButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LoginButton.OnPressedState.BorderRadius = 1;
            this.LoginButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoginButton.OnPressedState.BorderThickness = 1;
            this.LoginButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LoginButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LoginButton.OnPressedState.IconLeftImage = null;
            this.LoginButton.OnPressedState.IconRightImage = null;
            this.LoginButton.Size = new System.Drawing.Size(389, 48);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginButton.TextMarginLeft = 0;
            this.LoginButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.LoginButton.UseDefaultRadiusAndThickness = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginContentPanel
            // 
            this.LoginContentPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.LoginContentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginContentPanel.BackgroundImage")));
            this.LoginContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginContentPanel.BorderColor = System.Drawing.Color.Transparent;
            this.LoginContentPanel.BorderRadius = 3;
            this.LoginContentPanel.BorderThickness = 1;
            this.LoginContentPanel.Controls.Add(this.baseUrlLabel);
            this.LoginContentPanel.Controls.Add(this.progressBar2);
            this.LoginContentPanel.Controls.Add(this.checkBoxLabel);
            this.LoginContentPanel.Controls.Add(this.showPassCheckbox);
            this.LoginContentPanel.Controls.Add(this.CrdentialsLabel);
            this.LoginContentPanel.Controls.Add(this.ControlPanel);
            this.LoginContentPanel.Controls.Add(this.LoginButton);
            this.LoginContentPanel.Controls.Add(this.PasswordCredentialLabel);
            this.LoginContentPanel.Controls.Add(this.EmailCredentialLabel);
            this.LoginContentPanel.Controls.Add(this.txtPassword);
            this.LoginContentPanel.Controls.Add(this.txtEmail);
            this.LoginContentPanel.Controls.Add(this.LogoTitle);
            this.LoginContentPanel.Controls.Add(this.LogoPictureBox);
            this.LoginContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginContentPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginContentPanel.Margin = new System.Windows.Forms.Padding(5);
            this.LoginContentPanel.Name = "LoginContentPanel";
            this.LoginContentPanel.ShowBorders = true;
            this.LoginContentPanel.Size = new System.Drawing.Size(465, 700);
            this.LoginContentPanel.TabIndex = 9;
            this.LoginContentPanel.VisibleChanged += new System.EventHandler(this.LoginContentPanel_VisibleChanged);
            this.LoginContentPanel.Click += new System.EventHandler(this.LoginContentPanel_Click);
            // 
            // baseUrlLabel
            // 
            this.baseUrlLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.baseUrlLabel.AutoSize = true;
            this.baseUrlLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseUrlLabel.Location = new System.Drawing.Point(8, 658);
            this.baseUrlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baseUrlLabel.Name = "baseUrlLabel";
            this.baseUrlLabel.Size = new System.Drawing.Size(112, 32);
            this.baseUrlLabel.TabIndex = 19;
            this.baseUrlLabel.Text = "Base URL";
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.progressBar2.BackColor = System.Drawing.Color.White;
            this.progressBar2.Location = new System.Drawing.Point(14, 219);
            this.progressBar2.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(435, 153);
            this.progressBar2.TabIndex = 18;
            // 
            // checkBoxLabel
            // 
            this.checkBoxLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBoxLabel.AutoSize = true;
            this.checkBoxLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLabel.Location = new System.Drawing.Point(403, 526);
            this.checkBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.checkBoxLabel.Name = "checkBoxLabel";
            this.checkBoxLabel.Size = new System.Drawing.Size(42, 19);
            this.checkBoxLabel.TabIndex = 17;
            this.checkBoxLabel.Text = "Show";
            this.checkBoxLabel.Click += new System.EventHandler(this.checkBoxLabel_Click);
            // 
            // showPassCheckbox
            // 
            this.showPassCheckbox.AllowBindingControlAnimation = true;
            this.showPassCheckbox.AllowBindingControlColorChanges = false;
            this.showPassCheckbox.AllowBindingControlLocation = true;
            this.showPassCheckbox.AllowCheckBoxAnimation = false;
            this.showPassCheckbox.AllowCheckmarkAnimation = true;
            this.showPassCheckbox.AllowOnHoverStates = true;
            this.showPassCheckbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPassCheckbox.AutoCheck = true;
            this.showPassCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.showPassCheckbox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showPassCheckbox.BackgroundImage")));
            this.showPassCheckbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.showPassCheckbox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.showPassCheckbox.BorderRadius = 0;
            this.showPassCheckbox.Checked = false;
            this.showPassCheckbox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.showPassCheckbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.showPassCheckbox.CustomCheckmarkImage = null;
            this.showPassCheckbox.Location = new System.Drawing.Point(371, 519);
            this.showPassCheckbox.Margin = new System.Windows.Forms.Padding(4);
            this.showPassCheckbox.MinimumSize = new System.Drawing.Size(23, 21);
            this.showPassCheckbox.Name = "showPassCheckbox";
            this.showPassCheckbox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.showPassCheckbox.OnCheck.BorderRadius = 9;
            this.showPassCheckbox.OnCheck.BorderThickness = 2;
            this.showPassCheckbox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.showPassCheckbox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.showPassCheckbox.OnCheck.CheckmarkThickness = 2;
            this.showPassCheckbox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.showPassCheckbox.OnDisable.BorderRadius = 9;
            this.showPassCheckbox.OnDisable.BorderThickness = 2;
            this.showPassCheckbox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.showPassCheckbox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.showPassCheckbox.OnDisable.CheckmarkThickness = 2;
            this.showPassCheckbox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.showPassCheckbox.OnHoverChecked.BorderRadius = 9;
            this.showPassCheckbox.OnHoverChecked.BorderThickness = 2;
            this.showPassCheckbox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.showPassCheckbox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.showPassCheckbox.OnHoverChecked.CheckmarkThickness = 2;
            this.showPassCheckbox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.showPassCheckbox.OnHoverUnchecked.BorderRadius = 9;
            this.showPassCheckbox.OnHoverUnchecked.BorderThickness = 1;
            this.showPassCheckbox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.showPassCheckbox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.showPassCheckbox.OnUncheck.BorderRadius = 9;
            this.showPassCheckbox.OnUncheck.BorderThickness = 1;
            this.showPassCheckbox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.showPassCheckbox.Size = new System.Drawing.Size(28, 28);
            this.showPassCheckbox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.showPassCheckbox.TabIndex = 16;
            this.showPassCheckbox.ThreeState = false;
            this.showPassCheckbox.ToolTipText = null;
            this.showPassCheckbox.CheckedChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.showPassCheckbox_CheckedChanged);
            // 
            // CrdentialsLabel
            // 
            this.CrdentialsLabel.AllowParentOverrides = false;
            this.CrdentialsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CrdentialsLabel.AutoEllipsis = false;
            this.CrdentialsLabel.CursorType = null;
            this.CrdentialsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrdentialsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.CrdentialsLabel.Location = new System.Drawing.Point(151, 533);
            this.CrdentialsLabel.Margin = new System.Windows.Forms.Padding(4);
            this.CrdentialsLabel.Name = "CrdentialsLabel";
            this.CrdentialsLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CrdentialsLabel.Size = new System.Drawing.Size(176, 28);
            this.CrdentialsLabel.TabIndex = 14;
            this.CrdentialsLabel.Text = "Wrong Crdentials !!!";
            this.CrdentialsLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.CrdentialsLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.ControlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControlPanel.BackgroundImage")));
            this.ControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ControlPanel.BorderColor = System.Drawing.Color.Transparent;
            this.ControlPanel.BorderRadius = 3;
            this.ControlPanel.BorderThickness = 1;
            this.ControlPanel.Controls.Add(this.MaximizeButton);
            this.ControlPanel.Controls.Add(this.MinimizeButton);
            this.ControlPanel.Controls.Add(this.CloseButton);
            this.ControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlPanel.Location = new System.Drawing.Point(0, 0);
            this.ControlPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.ShowBorders = true;
            this.ControlPanel.Size = new System.Drawing.Size(465, 54);
            this.ControlPanel.TabIndex = 13;
            this.ControlPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ControlPanel_MouseDown);
            // 
            // MaximizeButton
            // 
            this.MaximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MaximizeButton.FlatAppearance.BorderSize = 0;
            this.MaximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MaximizeButton.Image")));
            this.MaximizeButton.Location = new System.Drawing.Point(341, -1);
            this.MaximizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeButton.Name = "MaximizeButton";
            this.MaximizeButton.Size = new System.Drawing.Size(57, 52);
            this.MaximizeButton.TabIndex = 11;
            this.MaximizeButton.UseVisualStyleBackColor = true;
            this.MaximizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(276, -1);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(57, 52);
            this.MinimizeButton.TabIndex = 12;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Image = ((System.Drawing.Image)(resources.GetObject("CloseButton.Image")));
            this.CloseButton.Location = new System.Drawing.Point(407, -1);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(57, 52);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // PasswordCredentialLabel
            // 
            this.PasswordCredentialLabel.AllowParentOverrides = false;
            this.PasswordCredentialLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordCredentialLabel.AutoEllipsis = false;
            this.PasswordCredentialLabel.CursorType = null;
            this.PasswordCredentialLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.PasswordCredentialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.PasswordCredentialLabel.Location = new System.Drawing.Point(56, 521);
            this.PasswordCredentialLabel.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordCredentialLabel.Name = "PasswordCredentialLabel";
            this.PasswordCredentialLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PasswordCredentialLabel.Size = new System.Drawing.Size(241, 25);
            this.PasswordCredentialLabel.TabIndex = 9;
            this.PasswordCredentialLabel.Text = "The Password field is Required";
            this.PasswordCredentialLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.PasswordCredentialLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // EmailCredentialLabel
            // 
            this.EmailCredentialLabel.AllowParentOverrides = false;
            this.EmailCredentialLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailCredentialLabel.AutoEllipsis = false;
            this.EmailCredentialLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.EmailCredentialLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.EmailCredentialLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.EmailCredentialLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.EmailCredentialLabel.Location = new System.Drawing.Point(56, 415);
            this.EmailCredentialLabel.Margin = new System.Windows.Forms.Padding(4);
            this.EmailCredentialLabel.Name = "EmailCredentialLabel";
            this.EmailCredentialLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailCredentialLabel.Size = new System.Drawing.Size(207, 25);
            this.EmailCredentialLabel.TabIndex = 8;
            this.EmailCredentialLabel.Text = "The Email field is Required";
            this.EmailCredentialLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.EmailCredentialLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.AnimationSpeed = 200;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPassword.BackgroundImage")));
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderThickness = 1;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI", 13F);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.White;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = null;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(40, 459);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPassword.Modified = false;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPassword.OnIdleState = stateProperties4;
            this.txtPassword.Padding = new System.Windows.Forms.Padding(4);
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(389, 54);
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TabIndex = 7;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginBottom = 0;
            this.txtPassword.TextMarginLeft = 3;
            this.txtPassword.TextMarginTop = 0;
            this.txtPassword.TextPlaceholder = "Password";
            this.txtPassword.UseSystemPasswordChar = false;
            this.txtPassword.WordWrap = true;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.GotFocus += new System.EventHandler(this.txtPassword_GotFocus);
            // 
            // txtEmail
            // 
            this.txtEmail.AcceptsReturn = false;
            this.txtEmail.AcceptsTab = false;
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.AnimationSpeed = 200;
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtEmail.BackgroundImage")));
            this.txtEmail.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.txtEmail.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtEmail.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.txtEmail.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtEmail.BorderRadius = 10;
            this.txtEmail.BorderThickness = 1;
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultFont = new System.Drawing.Font("Segoe UI", 13F);
            this.txtEmail.DefaultText = "";
            this.txtEmail.FillColor = System.Drawing.Color.White;
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.txtEmail.HideSelection = true;
            this.txtEmail.IconLeft = null;
            this.txtEmail.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.IconPadding = 10;
            this.txtEmail.IconRight = null;
            this.txtEmail.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(40, 353);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtEmail.Modified = false;
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtEmail.OnIdleState = stateProperties8;
            this.txtEmail.Padding = new System.Windows.Forms.Padding(4);
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.ReadOnly = false;
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(389, 54);
            this.txtEmail.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtEmail.TabIndex = 5;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMarginBottom = 0;
            this.txtEmail.TextMarginLeft = 3;
            this.txtEmail.TextMarginTop = 0;
            this.txtEmail.TextPlaceholder = "Email";
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.WordWrap = true;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            this.txtEmail.GotFocus += new System.EventHandler(this.txtEmail_GotFocus);
            // 
            // LogoTitle
            // 
            this.LogoTitle.AllowParentOverrides = false;
            this.LogoTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoTitle.AutoEllipsis = false;
            this.LogoTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.LogoTitle.CursorType = System.Windows.Forms.Cursors.Default;
            this.LogoTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.LogoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.LogoTitle.Location = new System.Drawing.Point(113, 276);
            this.LogoTitle.Margin = new System.Windows.Forms.Padding(4);
            this.LogoTitle.Name = "LogoTitle";
            this.LogoTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LogoTitle.Size = new System.Drawing.Size(204, 25);
            this.LogoTitle.TabIndex = 4;
            this.LogoTitle.Text = "Eduko Online Exam Portal";
            this.LogoTitle.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LogoTitle.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.AllowFocused = false;
            this.LogoPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoPictureBox.AutoSizeHeight = true;
            this.LogoPictureBox.BorderRadius = 114;
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.IsCircle = true;
            this.LogoPictureBox.Location = new System.Drawing.Point(113, 58);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(5);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(228, 228);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPictureBox.TabIndex = 3;
            this.LogoPictureBox.TabStop = false;
            this.LogoPictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(465, 700);
            this.Controls.Add(this.LoginContentPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm3_Load);
            this.LoginContentPanel.ResumeLayout(false);
            this.LoginContentPanel.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse LoginFormEllipse;
        private Bunifu.UI.WinForms.BunifuPanel LoginContentPanel;
        private Bunifu.UI.WinForms.BunifuTextBox txtEmail;
        private Bunifu.UI.WinForms.BunifuLabel LogoTitle;
        private Bunifu.UI.WinForms.BunifuPictureBox LogoPictureBox;
        private System.Windows.Forms.Button CloseButton;
        private Bunifu.UI.WinForms.BunifuTextBox txtPassword;
        private Bunifu.UI.WinForms.BunifuLabel EmailCredentialLabel;
        private Bunifu.UI.WinForms.BunifuLabel PasswordCredentialLabel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LoginButton;
        private System.Windows.Forms.Button MaximizeButton;
        private System.Windows.Forms.Button MinimizeButton;
        private Bunifu.UI.WinForms.BunifuPanel ControlPanel;
        private Bunifu.Framework.UI.BunifuElipse LoginButtonEllipse;
        private Bunifu.UI.WinForms.BunifuLabel CrdentialsLabel;
        private Bunifu.UI.WinForms.BunifuCheckBox showPassCheckbox;
        private System.Windows.Forms.Label checkBoxLabel;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        //private ProgressBar progressBar1;
        private ProgressBar progressBar2;
        private System.Windows.Forms.Label baseUrlLabel;
    }
}