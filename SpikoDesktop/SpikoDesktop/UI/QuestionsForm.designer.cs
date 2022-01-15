
namespace SpikoDesktop
{
    partial class QuestionsForm
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
        //[System.Obsolete]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtAnswer = new System.Windows.Forms.RichTextBox();
            this.TitlePanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.WifiStatusPanel = new System.Windows.Forms.Panel();
            this.WifiStatusLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.TitlePictureBox = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.TimerPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.qMarks = new Bunifu.UI.WinForms.BunifuLabel();
            this.MarkesLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.BottomLineTimerSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.txtResult = new Bunifu.UI.WinForms.BunifuLabel();
            this.TimeLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.TopLineTimerSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.QuestionTypeAndCounterPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.QuesInfoLabel = new System.Windows.Forms.Label();
            this.QuestionTypeLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.QuestionCounterSeparator = new Bunifu.UI.WinForms.BunifuSeparator();
            this.QuestionCounterLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.QuestionContentPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.ButtonsPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.AnswerPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.OptionGrid = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.OptionsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionPicturePanel = new System.Windows.Forms.Panel();
            this.qPicture = new System.Windows.Forms.PictureBox();
            this.txtQuestion = new System.Windows.Forms.RichTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuestionControlPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.SubmitExamButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DirectQuestionButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.directQuesTextBox = new System.Windows.Forms.TextBox();
            this.QueueLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.LastQuestionButton = new System.Windows.Forms.Button();
            this.NextQuestionButton = new System.Windows.Forms.Button();
            this.PreviousQuestionButton = new System.Windows.Forms.Button();
            this.FirstQuestionButton = new System.Windows.Forms.Button();
            this.QuestionListPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.TotalQuestionsGrid = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.monitoringTimer = new System.Windows.Forms.Timer(this.components);
            this.clipboard = new WK.Libraries.SharpClipboardNS.SharpClipboard(this.components);
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).BeginInit();
            this.TimerPanel.SuspendLayout();
            this.QuestionTypeAndCounterPanel.SuspendLayout();
            this.QuestionContentPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.AnswerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OptionGrid)).BeginInit();
            this.QuestionPicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qPicture)).BeginInit();
            this.QuestionControlPanel.SuspendLayout();
            this.QuestionListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TotalQuestionsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAnswer
            // 
            this.txtAnswer.AutoWordSelection = true;
            this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtAnswer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtAnswer.ForeColor = System.Drawing.Color.Black;
            this.txtAnswer.Location = new System.Drawing.Point(0, 0);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(511, 195);
            this.txtAnswer.TabIndex = 1;
            this.txtAnswer.Text = "Answer:";
            this.txtAnswer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAnswer_MouseClick);
            this.txtAnswer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtAnswer_KeyUp);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.TitlePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitlePanel.BackgroundImage")));
            this.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitlePanel.BorderColor = System.Drawing.Color.Transparent;
            this.TitlePanel.BorderRadius = 3;
            this.TitlePanel.BorderThickness = 1;
            this.TitlePanel.Controls.Add(this.WifiStatusPanel);
            this.TitlePanel.Controls.Add(this.WifiStatusLabel);
            this.TitlePanel.Controls.Add(this.TitleLabel);
            this.TitlePanel.Controls.Add(this.TitlePictureBox);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Margin = new System.Windows.Forms.Padding(0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.ShowBorders = true;
            this.TitlePanel.Size = new System.Drawing.Size(1285, 130);
            this.TitlePanel.TabIndex = 0;
            // 
            // WifiStatusPanel
            // 
            this.WifiStatusPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WifiStatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.WifiStatusPanel.Location = new System.Drawing.Point(1228, 15);
            this.WifiStatusPanel.Margin = new System.Windows.Forms.Padding(4);
            this.WifiStatusPanel.Name = "WifiStatusPanel";
            this.WifiStatusPanel.Size = new System.Drawing.Size(23, 17);
            this.WifiStatusPanel.TabIndex = 3;
            // 
            // WifiStatusLabel
            // 
            this.WifiStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WifiStatusLabel.AutoSize = true;
            this.WifiStatusLabel.Location = new System.Drawing.Point(1141, 15);
            this.WifiStatusLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WifiStatusLabel.Name = "WifiStatusLabel";
            this.WifiStatusLabel.Size = new System.Drawing.Size(79, 17);
            this.WifiStatusLabel.TabIndex = 2;
            this.WifiStatusLabel.Text = "Wifi Status:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AllowParentOverrides = false;
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoEllipsis = false;
            this.TitleLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TitleLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.TitleLabel.ForeColor = System.Drawing.Color.Black;
            this.TitleLabel.Location = new System.Drawing.Point(457, 46);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(4);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleLabel.Size = new System.Drawing.Size(394, 45);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Eduko Online Exam System";
            this.TitleLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TitleLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TitlePictureBox
            // 
            this.TitlePictureBox.AllowFocused = false;
            this.TitlePictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitlePictureBox.AutoSizeHeight = true;
            this.TitlePictureBox.BorderRadius = 67;
            this.TitlePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("TitlePictureBox.Image")));
            this.TitlePictureBox.IsCircle = true;
            this.TitlePictureBox.Location = new System.Drawing.Point(292, 4);
            this.TitlePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.TitlePictureBox.Name = "TitlePictureBox";
            this.TitlePictureBox.Size = new System.Drawing.Size(135, 135);
            this.TitlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TitlePictureBox.TabIndex = 0;
            this.TitlePictureBox.TabStop = false;
            this.TitlePictureBox.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // TimerPanel
            // 
            this.TimerPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.TimerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TimerPanel.BackgroundImage")));
            this.TimerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TimerPanel.BorderColor = System.Drawing.Color.Transparent;
            this.TimerPanel.BorderRadius = 3;
            this.TimerPanel.BorderThickness = 1;
            this.TimerPanel.Controls.Add(this.qMarks);
            this.TimerPanel.Controls.Add(this.MarkesLabel);
            this.TimerPanel.Controls.Add(this.BottomLineTimerSeparator);
            this.TimerPanel.Controls.Add(this.txtResult);
            this.TimerPanel.Controls.Add(this.TimeLabel);
            this.TimerPanel.Controls.Add(this.TopLineTimerSeparator);
            this.TimerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TimerPanel.Location = new System.Drawing.Point(0, 130);
            this.TimerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.TimerPanel.Name = "TimerPanel";
            this.TimerPanel.ShowBorders = true;
            this.TimerPanel.Size = new System.Drawing.Size(1285, 71);
            this.TimerPanel.TabIndex = 1;
            // 
            // qMarks
            // 
            this.qMarks.AllowParentOverrides = false;
            this.qMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qMarks.AutoEllipsis = false;
            this.qMarks.CursorType = null;
            this.qMarks.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.qMarks.Location = new System.Drawing.Point(1137, 25);
            this.qMarks.Margin = new System.Windows.Forms.Padding(4);
            this.qMarks.Name = "qMarks";
            this.qMarks.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.qMarks.Size = new System.Drawing.Size(12, 30);
            this.qMarks.TabIndex = 5;
            this.qMarks.Text = "0";
            this.qMarks.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.qMarks.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MarkesLabel
            // 
            this.MarkesLabel.AllowParentOverrides = false;
            this.MarkesLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MarkesLabel.AutoEllipsis = false;
            this.MarkesLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MarkesLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.MarkesLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.MarkesLabel.Location = new System.Drawing.Point(1045, 25);
            this.MarkesLabel.Margin = new System.Windows.Forms.Padding(4);
            this.MarkesLabel.Name = "MarkesLabel";
            this.MarkesLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MarkesLabel.Size = new System.Drawing.Size(64, 30);
            this.MarkesLabel.TabIndex = 4;
            this.MarkesLabel.Text = "Marks: ";
            this.MarkesLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.MarkesLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BottomLineTimerSeparator
            // 
            this.BottomLineTimerSeparator.BackColor = System.Drawing.Color.Transparent;
            this.BottomLineTimerSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BottomLineTimerSeparator.BackgroundImage")));
            this.BottomLineTimerSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomLineTimerSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.BottomLineTimerSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomLineTimerSeparator.LineColor = System.Drawing.Color.Black;
            this.BottomLineTimerSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.RightEdgeFaded;
            this.BottomLineTimerSeparator.LineThickness = 2;
            this.BottomLineTimerSeparator.Location = new System.Drawing.Point(0, 54);
            this.BottomLineTimerSeparator.Margin = new System.Windows.Forms.Padding(5);
            this.BottomLineTimerSeparator.Name = "BottomLineTimerSeparator";
            this.BottomLineTimerSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.BottomLineTimerSeparator.Size = new System.Drawing.Size(1285, 17);
            this.BottomLineTimerSeparator.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.AllowParentOverrides = false;
            this.txtResult.AutoEllipsis = false;
            this.txtResult.CursorType = null;
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.txtResult.Location = new System.Drawing.Point(135, 25);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Name = "txtResult";
            this.txtResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtResult.Size = new System.Drawing.Size(82, 30);
            this.txtResult.TabIndex = 2;
            this.txtResult.Text = "00:00:00";
            this.txtResult.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.txtResult.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AllowParentOverrides = false;
            this.TimeLabel.AutoEllipsis = false;
            this.TimeLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TimeLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.TimeLabel.Location = new System.Drawing.Point(28, 25);
            this.TimeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimeLabel.Size = new System.Drawing.Size(95, 30);
            this.TimeLabel.TabIndex = 1;
            this.TimeLabel.Text = "Time Left:";
            this.TimeLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.TimeLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TopLineTimerSeparator
            // 
            this.TopLineTimerSeparator.BackColor = System.Drawing.Color.Transparent;
            this.TopLineTimerSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TopLineTimerSeparator.BackgroundImage")));
            this.TopLineTimerSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TopLineTimerSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.TopLineTimerSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopLineTimerSeparator.LineColor = System.Drawing.Color.Black;
            this.TopLineTimerSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.LeftEdgeFaded;
            this.TopLineTimerSeparator.LineThickness = 2;
            this.TopLineTimerSeparator.Location = new System.Drawing.Point(0, 0);
            this.TopLineTimerSeparator.Margin = new System.Windows.Forms.Padding(5);
            this.TopLineTimerSeparator.Name = "TopLineTimerSeparator";
            this.TopLineTimerSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.TopLineTimerSeparator.Size = new System.Drawing.Size(1285, 17);
            this.TopLineTimerSeparator.TabIndex = 0;
            // 
            // QuestionTypeAndCounterPanel
            // 
            this.QuestionTypeAndCounterPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.QuestionTypeAndCounterPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestionTypeAndCounterPanel.BackgroundImage")));
            this.QuestionTypeAndCounterPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuestionTypeAndCounterPanel.BorderColor = System.Drawing.Color.Transparent;
            this.QuestionTypeAndCounterPanel.BorderRadius = 3;
            this.QuestionTypeAndCounterPanel.BorderThickness = 1;
            this.QuestionTypeAndCounterPanel.Controls.Add(this.QuesInfoLabel);
            this.QuestionTypeAndCounterPanel.Controls.Add(this.QuestionTypeLabel);
            this.QuestionTypeAndCounterPanel.Controls.Add(this.QuestionCounterSeparator);
            this.QuestionTypeAndCounterPanel.Controls.Add(this.QuestionCounterLabel);
            this.QuestionTypeAndCounterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestionTypeAndCounterPanel.Location = new System.Drawing.Point(0, 201);
            this.QuestionTypeAndCounterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionTypeAndCounterPanel.Name = "QuestionTypeAndCounterPanel";
            this.QuestionTypeAndCounterPanel.ShowBorders = true;
            this.QuestionTypeAndCounterPanel.Size = new System.Drawing.Size(1285, 55);
            this.QuestionTypeAndCounterPanel.TabIndex = 2;
            // 
            // QuesInfoLabel
            // 
            this.QuesInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuesInfoLabel.AutoSize = true;
            this.QuesInfoLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuesInfoLabel.Location = new System.Drawing.Point(991, 18);
            this.QuesInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QuesInfoLabel.Name = "QuesInfoLabel";
            this.QuesInfoLabel.Size = new System.Drawing.Size(259, 23);
            this.QuesInfoLabel.TabIndex = 6;
            this.QuesInfoLabel.Text = "Multiple Answers Can be Correct";
            // 
            // QuestionTypeLabel
            // 
            this.QuestionTypeLabel.AllowParentOverrides = false;
            this.QuestionTypeLabel.AutoEllipsis = false;
            this.QuestionTypeLabel.CursorType = null;
            this.QuestionTypeLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.QuestionTypeLabel.Location = new System.Drawing.Point(16, 18);
            this.QuestionTypeLabel.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionTypeLabel.Name = "QuestionTypeLabel";
            this.QuestionTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuestionTypeLabel.Size = new System.Drawing.Size(244, 25);
            this.QuestionTypeLabel.TabIndex = 5;
            this.QuestionTypeLabel.Text = "Question Type: Short Question";
            this.QuestionTypeLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.QuestionTypeLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // QuestionCounterSeparator
            // 
            this.QuestionCounterSeparator.BackColor = System.Drawing.Color.Transparent;
            this.QuestionCounterSeparator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestionCounterSeparator.BackgroundImage")));
            this.QuestionCounterSeparator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuestionCounterSeparator.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Round;
            this.QuestionCounterSeparator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuestionCounterSeparator.LineColor = System.Drawing.Color.Black;
            this.QuestionCounterSeparator.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.DoubleEdgeFaded;
            this.QuestionCounterSeparator.LineThickness = 2;
            this.QuestionCounterSeparator.Location = new System.Drawing.Point(0, 38);
            this.QuestionCounterSeparator.Margin = new System.Windows.Forms.Padding(5);
            this.QuestionCounterSeparator.Name = "QuestionCounterSeparator";
            this.QuestionCounterSeparator.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.QuestionCounterSeparator.Size = new System.Drawing.Size(1285, 17);
            this.QuestionCounterSeparator.TabIndex = 4;
            // 
            // QuestionCounterLabel
            // 
            this.QuestionCounterLabel.AllowParentOverrides = false;
            this.QuestionCounterLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QuestionCounterLabel.AutoEllipsis = false;
            this.QuestionCounterLabel.CursorType = null;
            this.QuestionCounterLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.QuestionCounterLabel.Location = new System.Drawing.Point(563, 7);
            this.QuestionCounterLabel.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionCounterLabel.Name = "QuestionCounterLabel";
            this.QuestionCounterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QuestionCounterLabel.Size = new System.Drawing.Size(91, 25);
            this.QuestionCounterLabel.TabIndex = 3;
            this.QuestionCounterLabel.Text = "Question 1:";
            this.QuestionCounterLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.QuestionCounterLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // QuestionContentPanel
            // 
            this.QuestionContentPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.QuestionContentPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestionContentPanel.BackgroundImage")));
            this.QuestionContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuestionContentPanel.BorderColor = System.Drawing.Color.Transparent;
            this.QuestionContentPanel.BorderRadius = 3;
            this.QuestionContentPanel.BorderThickness = 1;
            this.QuestionContentPanel.Controls.Add(this.ButtonsPanel);
            this.QuestionContentPanel.Controls.Add(this.QuestionPicturePanel);
            this.QuestionContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionContentPanel.Location = new System.Drawing.Point(0, 256);
            this.QuestionContentPanel.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionContentPanel.Name = "QuestionContentPanel";
            this.QuestionContentPanel.ShowBorders = true;
            this.QuestionContentPanel.Size = new System.Drawing.Size(1285, 474);
            this.QuestionContentPanel.TabIndex = 3;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ButtonsPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonsPanel.BackgroundImage")));
            this.ButtonsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonsPanel.BorderColor = System.Drawing.Color.Transparent;
            this.ButtonsPanel.BorderRadius = 3;
            this.ButtonsPanel.BorderThickness = 1;
            this.ButtonsPanel.Controls.Add(this.AnswerPanel);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonsPanel.Location = new System.Drawing.Point(0, 39);
            this.ButtonsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.ShowBorders = true;
            this.ButtonsPanel.Size = new System.Drawing.Size(1285, 435);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // AnswerPanel
            // 
            this.AnswerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AnswerPanel.AutoScroll = true;
            this.AnswerPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.AnswerPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AnswerPanel.BackgroundImage")));
            this.AnswerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AnswerPanel.BorderColor = System.Drawing.Color.Transparent;
            this.AnswerPanel.BorderRadius = 3;
            this.AnswerPanel.BorderThickness = 1;
            this.AnswerPanel.Controls.Add(this.OptionGrid);
            this.AnswerPanel.Location = new System.Drawing.Point(0, 7);
            this.AnswerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AnswerPanel.Name = "AnswerPanel";
            this.AnswerPanel.ShowBorders = true;
            this.AnswerPanel.Size = new System.Drawing.Size(1281, 372);
            this.AnswerPanel.TabIndex = 19;
            // 
            // OptionGrid
            // 
            this.OptionGrid.AllowCustomTheming = false;
            this.OptionGrid.AllowUserToAddRows = false;
            this.OptionGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.OptionGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.OptionGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OptionGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OptionGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.OptionGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OptionGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.OptionGrid.ColumnHeadersHeight = 40;
            this.OptionGrid.ColumnHeadersVisible = false;
            this.OptionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OptionsColumn});
            this.OptionGrid.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.OptionGrid.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.OptionGrid.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.OptionGrid.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.OptionGrid.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.OptionGrid.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.OptionGrid.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.OptionGrid.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.OptionGrid.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.OptionGrid.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.OptionGrid.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.OptionGrid.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.OptionGrid.CurrentTheme.Name = null;
            this.OptionGrid.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.OptionGrid.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.OptionGrid.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.OptionGrid.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.OptionGrid.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OptionGrid.DefaultCellStyle = dataGridViewCellStyle9;
            this.OptionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionGrid.EnableHeadersVisualStyles = false;
            this.OptionGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.OptionGrid.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.OptionGrid.HeaderBgColor = System.Drawing.Color.Empty;
            this.OptionGrid.HeaderForeColor = System.Drawing.Color.White;
            this.OptionGrid.Location = new System.Drawing.Point(0, 0);
            this.OptionGrid.Margin = new System.Windows.Forms.Padding(4);
            this.OptionGrid.Name = "OptionGrid";
            this.OptionGrid.ReadOnly = true;
            this.OptionGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OptionGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.OptionGrid.RowHeadersVisible = false;
            this.OptionGrid.RowHeadersWidth = 51;
            this.OptionGrid.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.OptionGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionGrid.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(44)))), ((int)(((byte)(50)))));
            this.OptionGrid.RowTemplate.Height = 40;
            this.OptionGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.OptionGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OptionGrid.Size = new System.Drawing.Size(1281, 372);
            this.OptionGrid.TabIndex = 10;
            this.OptionGrid.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.OptionGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OptionGrid_CellClick);
            // 
            // OptionsColumn
            // 
            this.OptionsColumn.HeaderText = "Options";
            this.OptionsColumn.MinimumWidth = 6;
            this.OptionsColumn.Name = "OptionsColumn";
            this.OptionsColumn.ReadOnly = true;
            // 
            // QuestionPicturePanel
            // 
            this.QuestionPicturePanel.AutoScroll = true;
            this.QuestionPicturePanel.Controls.Add(this.qPicture);
            this.QuestionPicturePanel.Controls.Add(this.txtQuestion);
            this.QuestionPicturePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.QuestionPicturePanel.Location = new System.Drawing.Point(0, 0);
            this.QuestionPicturePanel.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionPicturePanel.Name = "QuestionPicturePanel";
            this.QuestionPicturePanel.Size = new System.Drawing.Size(1285, 39);
            this.QuestionPicturePanel.TabIndex = 3;
            // 
            // qPicture
            // 
            this.qPicture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.qPicture.Location = new System.Drawing.Point(0, 33);
            this.qPicture.Margin = new System.Windows.Forms.Padding(4);
            this.qPicture.Name = "qPicture";
            this.qPicture.Size = new System.Drawing.Size(1264, 98);
            this.qPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.qPicture.TabIndex = 1;
            this.qPicture.TabStop = false;
            this.qPicture.Visible = false;
            this.qPicture.Click += new System.EventHandler(this.qPicture_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.txtQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQuestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuestion.ForeColor = System.Drawing.Color.Black;
            this.txtQuestion.Location = new System.Drawing.Point(0, 0);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.ReadOnly = true;
            this.txtQuestion.Size = new System.Drawing.Size(1264, 33);
            this.txtQuestion.TabIndex = 0;
            this.txtQuestion.Text = "Question:";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Options";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // QuestionControlPanel
            // 
            this.QuestionControlPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.QuestionControlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestionControlPanel.BackgroundImage")));
            this.QuestionControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuestionControlPanel.BorderColor = System.Drawing.Color.Transparent;
            this.QuestionControlPanel.BorderRadius = 3;
            this.QuestionControlPanel.BorderThickness = 1;
            this.QuestionControlPanel.Controls.Add(this.SubmitExamButton);
            this.QuestionControlPanel.Controls.Add(this.DirectQuestionButton);
            this.QuestionControlPanel.Controls.Add(this.directQuesTextBox);
            this.QuestionControlPanel.Controls.Add(this.QueueLabel);
            this.QuestionControlPanel.Controls.Add(this.LastQuestionButton);
            this.QuestionControlPanel.Controls.Add(this.NextQuestionButton);
            this.QuestionControlPanel.Controls.Add(this.PreviousQuestionButton);
            this.QuestionControlPanel.Controls.Add(this.FirstQuestionButton);
            this.QuestionControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuestionControlPanel.Location = new System.Drawing.Point(0, 672);
            this.QuestionControlPanel.Margin = new System.Windows.Forms.Padding(4);
            this.QuestionControlPanel.Name = "QuestionControlPanel";
            this.QuestionControlPanel.ShowBorders = true;
            this.QuestionControlPanel.Size = new System.Drawing.Size(1285, 58);
            this.QuestionControlPanel.TabIndex = 22;
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
            this.SubmitExamButton.ButtonText = "Click Here to FINISH your Exam";
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
            this.SubmitExamButton.IdleBorderRadius = 31;
            this.SubmitExamButton.IdleBorderThickness = 1;
            this.SubmitExamButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.SubmitExamButton.IdleIconLeftImage = null;
            this.SubmitExamButton.IdleIconRightImage = null;
            this.SubmitExamButton.IndicateFocus = false;
            this.SubmitExamButton.Location = new System.Drawing.Point(16, 11);
            this.SubmitExamButton.Margin = new System.Windows.Forms.Padding(4);
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
            this.SubmitExamButton.Size = new System.Drawing.Size(255, 33);
            this.SubmitExamButton.TabIndex = 9;
            this.SubmitExamButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SubmitExamButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SubmitExamButton.TextMarginLeft = 0;
            this.SubmitExamButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SubmitExamButton.UseDefaultRadiusAndThickness = true;
            this.SubmitExamButton.Click += new System.EventHandler(this.SubmitExamButton_Click_1);
            // 
            // DirectQuestionButton
            // 
            this.DirectQuestionButton.AllowAnimations = true;
            this.DirectQuestionButton.AllowMouseEffects = true;
            this.DirectQuestionButton.AllowToggling = false;
            this.DirectQuestionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DirectQuestionButton.AnimationSpeed = 200;
            this.DirectQuestionButton.AutoGenerateColors = false;
            this.DirectQuestionButton.AutoRoundBorders = false;
            this.DirectQuestionButton.AutoSizeLeftIcon = true;
            this.DirectQuestionButton.AutoSizeRightIcon = true;
            this.DirectQuestionButton.BackColor = System.Drawing.Color.Transparent;
            this.DirectQuestionButton.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.DirectQuestionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DirectQuestionButton.BackgroundImage")));
            this.DirectQuestionButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DirectQuestionButton.ButtonText = "Go";
            this.DirectQuestionButton.ButtonTextMarginLeft = 0;
            this.DirectQuestionButton.ColorContrastOnClick = 45;
            this.DirectQuestionButton.ColorContrastOnHover = 45;
            this.DirectQuestionButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.DirectQuestionButton.CustomizableEdges = borderEdges4;
            this.DirectQuestionButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DirectQuestionButton.DisabledBorderColor = System.Drawing.Color.DodgerBlue;
            this.DirectQuestionButton.DisabledFillColor = System.Drawing.Color.DodgerBlue;
            this.DirectQuestionButton.DisabledForecolor = System.Drawing.Color.White;
            this.DirectQuestionButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.DirectQuestionButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DirectQuestionButton.ForeColor = System.Drawing.Color.White;
            this.DirectQuestionButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DirectQuestionButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DirectQuestionButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.DirectQuestionButton.IconMarginLeft = 11;
            this.DirectQuestionButton.IconPadding = 10;
            this.DirectQuestionButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DirectQuestionButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DirectQuestionButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.DirectQuestionButton.IconSize = 25;
            this.DirectQuestionButton.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.DirectQuestionButton.IdleBorderRadius = 1;
            this.DirectQuestionButton.IdleBorderThickness = 1;
            this.DirectQuestionButton.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.DirectQuestionButton.IdleIconLeftImage = null;
            this.DirectQuestionButton.IdleIconRightImage = null;
            this.DirectQuestionButton.IndicateFocus = false;
            this.DirectQuestionButton.Location = new System.Drawing.Point(703, 20);
            this.DirectQuestionButton.Margin = new System.Windows.Forms.Padding(4);
            this.DirectQuestionButton.Name = "DirectQuestionButton";
            this.DirectQuestionButton.OnDisabledState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DirectQuestionButton.OnDisabledState.BorderRadius = 1;
            this.DirectQuestionButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DirectQuestionButton.OnDisabledState.BorderThickness = 1;
            this.DirectQuestionButton.OnDisabledState.FillColor = System.Drawing.Color.DodgerBlue;
            this.DirectQuestionButton.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.DirectQuestionButton.OnDisabledState.IconLeftImage = null;
            this.DirectQuestionButton.OnDisabledState.IconRightImage = null;
            this.DirectQuestionButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.DirectQuestionButton.onHoverState.BorderRadius = 1;
            this.DirectQuestionButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DirectQuestionButton.onHoverState.BorderThickness = 1;
            this.DirectQuestionButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.DirectQuestionButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.DirectQuestionButton.onHoverState.IconLeftImage = null;
            this.DirectQuestionButton.onHoverState.IconRightImage = null;
            this.DirectQuestionButton.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DirectQuestionButton.OnIdleState.BorderRadius = 1;
            this.DirectQuestionButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DirectQuestionButton.OnIdleState.BorderThickness = 1;
            this.DirectQuestionButton.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.DirectQuestionButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.DirectQuestionButton.OnIdleState.IconLeftImage = null;
            this.DirectQuestionButton.OnIdleState.IconRightImage = null;
            this.DirectQuestionButton.OnPressedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DirectQuestionButton.OnPressedState.BorderRadius = 1;
            this.DirectQuestionButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DirectQuestionButton.OnPressedState.BorderThickness = 1;
            this.DirectQuestionButton.OnPressedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.DirectQuestionButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DirectQuestionButton.OnPressedState.IconLeftImage = null;
            this.DirectQuestionButton.OnPressedState.IconRightImage = null;
            this.DirectQuestionButton.Size = new System.Drawing.Size(36, 25);
            this.DirectQuestionButton.TabIndex = 8;
            this.DirectQuestionButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DirectQuestionButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DirectQuestionButton.TextMarginLeft = 0;
            this.DirectQuestionButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.DirectQuestionButton.UseDefaultRadiusAndThickness = true;
            this.DirectQuestionButton.Click += new System.EventHandler(this.DirectQuestionButton_Click_1);
            // 
            // directQuesTextBox
            // 
            this.directQuesTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.directQuesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.directQuesTextBox.Location = new System.Drawing.Point(652, 20);
            this.directQuesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.directQuesTextBox.Name = "directQuesTextBox";
            this.directQuesTextBox.Size = new System.Drawing.Size(41, 22);
            this.directQuesTextBox.TabIndex = 7;
            this.directQuesTextBox.Text = "1";
            this.directQuesTextBox.Enter += new System.EventHandler(this.dirextQuesTextBox_Enter_1);
            this.directQuesTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.directQuesTextBox_KeyDown);
            // 
            // QueueLabel
            // 
            this.QueueLabel.AllowParentOverrides = false;
            this.QueueLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.QueueLabel.AutoEllipsis = false;
            this.QueueLabel.CursorType = null;
            this.QueueLabel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.QueueLabel.Location = new System.Drawing.Point(519, 20);
            this.QueueLabel.Margin = new System.Windows.Forms.Padding(4);
            this.QueueLabel.Name = "QueueLabel";
            this.QueueLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.QueueLabel.Size = new System.Drawing.Size(103, 25);
            this.QueueLabel.TabIndex = 6;
            this.QueueLabel.Text = "Go to Que #:";
            this.QueueLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.QueueLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LastQuestionButton
            // 
            this.LastQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LastQuestionButton.FlatAppearance.BorderSize = 0;
            this.LastQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LastQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("LastQuestionButton.Image")));
            this.LastQuestionButton.Location = new System.Drawing.Point(1228, 11);
            this.LastQuestionButton.Margin = new System.Windows.Forms.Padding(4);
            this.LastQuestionButton.Name = "LastQuestionButton";
            this.LastQuestionButton.Size = new System.Drawing.Size(47, 39);
            this.LastQuestionButton.TabIndex = 3;
            this.LastQuestionButton.UseVisualStyleBackColor = true;
            this.LastQuestionButton.Click += new System.EventHandler(this.LastQuestionButton_Click);
            // 
            // NextQuestionButton
            // 
            this.NextQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextQuestionButton.FlatAppearance.BorderSize = 0;
            this.NextQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("NextQuestionButton.Image")));
            this.NextQuestionButton.Location = new System.Drawing.Point(1173, 11);
            this.NextQuestionButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextQuestionButton.Name = "NextQuestionButton";
            this.NextQuestionButton.Size = new System.Drawing.Size(47, 39);
            this.NextQuestionButton.TabIndex = 2;
            this.NextQuestionButton.UseVisualStyleBackColor = true;
            this.NextQuestionButton.Click += new System.EventHandler(this.NextQuestionButton_Click_1);
            // 
            // PreviousQuestionButton
            // 
            this.PreviousQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousQuestionButton.FlatAppearance.BorderSize = 0;
            this.PreviousQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PreviousQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousQuestionButton.Image")));
            this.PreviousQuestionButton.Location = new System.Drawing.Point(1119, 11);
            this.PreviousQuestionButton.Margin = new System.Windows.Forms.Padding(4);
            this.PreviousQuestionButton.Name = "PreviousQuestionButton";
            this.PreviousQuestionButton.Size = new System.Drawing.Size(47, 39);
            this.PreviousQuestionButton.TabIndex = 1;
            this.PreviousQuestionButton.UseVisualStyleBackColor = true;
            this.PreviousQuestionButton.Click += new System.EventHandler(this.PreviousQuestionButton_Click_1);
            // 
            // FirstQuestionButton
            // 
            this.FirstQuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstQuestionButton.FlatAppearance.BorderSize = 0;
            this.FirstQuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FirstQuestionButton.Image = ((System.Drawing.Image)(resources.GetObject("FirstQuestionButton.Image")));
            this.FirstQuestionButton.Location = new System.Drawing.Point(1064, 11);
            this.FirstQuestionButton.Margin = new System.Windows.Forms.Padding(4);
            this.FirstQuestionButton.Name = "FirstQuestionButton";
            this.FirstQuestionButton.Size = new System.Drawing.Size(47, 39);
            this.FirstQuestionButton.TabIndex = 0;
            this.FirstQuestionButton.UseVisualStyleBackColor = true;
            this.FirstQuestionButton.Click += new System.EventHandler(this.FirstQuestionButton_Click);
            // 
            // QuestionListPanel
            // 
            this.QuestionListPanel.AutoScroll = true;
            this.QuestionListPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.QuestionListPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestionListPanel.BackgroundImage")));
            this.QuestionListPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuestionListPanel.BorderColor = System.Drawing.Color.Transparent;
            this.QuestionListPanel.BorderRadius = 3;
            this.QuestionListPanel.BorderThickness = 1;
            this.QuestionListPanel.Controls.Add(this.TotalQuestionsGrid);
            this.QuestionListPanel.Controls.Add(this.bunifuLabel2);
            this.QuestionListPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.QuestionListPanel.Location = new System.Drawing.Point(0, 730);
            this.QuestionListPanel.Margin = new System.Windows.Forms.Padding(0);
            this.QuestionListPanel.Name = "QuestionListPanel";
            this.QuestionListPanel.ShowBorders = true;
            this.QuestionListPanel.Size = new System.Drawing.Size(1285, 60);
            this.QuestionListPanel.TabIndex = 23;
            // 
            // TotalQuestionsGrid
            // 
            this.TotalQuestionsGrid.AllowUserToAddRows = false;
            this.TotalQuestionsGrid.AllowUserToDeleteRows = false;
            this.TotalQuestionsGrid.AllowUserToResizeColumns = false;
            this.TotalQuestionsGrid.AllowUserToResizeRows = false;
            this.TotalQuestionsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TotalQuestionsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.TotalQuestionsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TotalQuestionsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.TotalQuestionsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TotalQuestionsGrid.ColumnHeadersVisible = false;
            this.TotalQuestionsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TotalQuestionsGrid.DefaultCellStyle = dataGridViewCellStyle12;
            this.TotalQuestionsGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TotalQuestionsGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.TotalQuestionsGrid.Location = new System.Drawing.Point(0, 28);
            this.TotalQuestionsGrid.Margin = new System.Windows.Forms.Padding(0);
            this.TotalQuestionsGrid.Name = "TotalQuestionsGrid";
            this.TotalQuestionsGrid.ReadOnly = true;
            this.TotalQuestionsGrid.RowHeadersVisible = false;
            this.TotalQuestionsGrid.RowHeadersWidth = 51;
            this.TotalQuestionsGrid.ShowEditingIcon = false;
            this.TotalQuestionsGrid.Size = new System.Drawing.Size(1285, 32);
            this.TotalQuestionsGrid.TabIndex = 5;
            this.TotalQuestionsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TotalQuestionsGrid_CellClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.AutoSize = false;
            this.bunifuLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuLabel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuLabel2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(1285, 28);
            this.bunifuLabel2.TabIndex = 4;
            this.bunifuLabel2.Text = "Questions Summary: (Attempted Questions)";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.BottomLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // monitoringTimer
            // 
            this.monitoringTimer.Enabled = true;
            this.monitoringTimer.Interval = 600000;
            this.monitoringTimer.Tick += new System.EventHandler(this.monitoringTimer_Tick);
            // 
            // clipboard
            // 
            this.clipboard.MonitorClipboard = true;
            this.clipboard.ObservableFormats.All = true;
            this.clipboard.ObservableFormats.Files = true;
            this.clipboard.ObservableFormats.Images = true;
            this.clipboard.ObservableFormats.Others = true;
            this.clipboard.ObservableFormats.Texts = true;
            this.clipboard.ObserveLastEntry = true;
            this.clipboard.Tag = null;
            this.clipboard.ClipboardChanged += new System.EventHandler<WK.Libraries.SharpClipboardNS.SharpClipboard.ClipboardChangedEventArgs>(this.clipboard_ClipboardChanged);
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1285, 790);
            this.Controls.Add(this.QuestionControlPanel);
            this.Controls.Add(this.QuestionContentPanel);
            this.Controls.Add(this.QuestionListPanel);
            this.Controls.Add(this.QuestionTypeAndCounterPanel);
            this.Controls.Add(this.TimerPanel);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "QuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuestionsForm";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuestionsForm_FormClosing);
            this.Load += new System.EventHandler(this.QuestionsForm_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePictureBox)).EndInit();
            this.TimerPanel.ResumeLayout(false);
            this.TimerPanel.PerformLayout();
            this.QuestionTypeAndCounterPanel.ResumeLayout(false);
            this.QuestionTypeAndCounterPanel.PerformLayout();
            this.QuestionContentPanel.ResumeLayout(false);
            this.ButtonsPanel.ResumeLayout(false);
            this.AnswerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OptionGrid)).EndInit();
            this.QuestionPicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.qPicture)).EndInit();
            this.QuestionControlPanel.ResumeLayout(false);
            this.QuestionControlPanel.PerformLayout();
            this.QuestionListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TotalQuestionsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel TitlePanel;
        private Bunifu.UI.WinForms.BunifuPictureBox TitlePictureBox;
        private Bunifu.UI.WinForms.BunifuLabel TitleLabel;
        private Bunifu.UI.WinForms.BunifuPanel TimerPanel;
        private Bunifu.UI.WinForms.BunifuSeparator TopLineTimerSeparator;
        private Bunifu.UI.WinForms.BunifuLabel TimeLabel;
        private Bunifu.UI.WinForms.BunifuLabel txtResult;
        private Bunifu.UI.WinForms.BunifuSeparator BottomLineTimerSeparator;
        private Bunifu.UI.WinForms.BunifuPanel QuestionTypeAndCounterPanel;
        private Bunifu.UI.WinForms.BunifuLabel QuestionCounterLabel;
        private Bunifu.UI.WinForms.BunifuSeparator QuestionCounterSeparator;
        private Bunifu.UI.WinForms.BunifuPanel QuestionContentPanel;
        private System.Windows.Forms.RichTextBox txtQuestion;
        private Bunifu.UI.WinForms.BunifuLabel QuestionTypeLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.RichTextBox txtAnswer;
        private Bunifu.UI.WinForms.BunifuPanel QuestionControlPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SubmitExamButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DirectQuestionButton;
        private System.Windows.Forms.TextBox directQuesTextBox;
        private Bunifu.UI.WinForms.BunifuLabel QueueLabel;
        private System.Windows.Forms.Button LastQuestionButton;
        private System.Windows.Forms.Button NextQuestionButton;
        private System.Windows.Forms.Button PreviousQuestionButton;
        private System.Windows.Forms.Button FirstQuestionButton;
        private Bunifu.UI.WinForms.BunifuPanel ButtonsPanel;
        private Bunifu.UI.WinForms.BunifuPanel AnswerPanel;
        private Bunifu.UI.WinForms.BunifuPanel QuestionListPanel;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private System.Windows.Forms.DataGridView TotalQuestionsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Panel QuestionPicturePanel;
        private System.Windows.Forms.PictureBox qPicture;
        private Bunifu.UI.WinForms.BunifuDataGridView OptionGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn OptionsColumn;
        private Bunifu.UI.WinForms.BunifuLabel qMarks;
        private Bunifu.UI.WinForms.BunifuLabel MarkesLabel;
        private System.Windows.Forms.Label QuesInfoLabel;
        private System.Windows.Forms.Timer monitoringTimer;
        private System.Windows.Forms.Label WifiStatusLabel;
        private System.Windows.Forms.Panel WifiStatusPanel;
        private WK.Libraries.SharpClipboardNS.SharpClipboard clipboard;
    }
}