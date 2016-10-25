namespace ArenaDraftBot
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.groupConfig = new DevExpress.XtraEditors.GroupControl();
            this.btConnect = new System.Windows.Forms.Button();
            this.tbTwitchChannel = new DevExpress.XtraEditors.TextEdit();
            this.lbTwitchChannel = new DevExpress.XtraEditors.LabelControl();
            this.lbBotOAuth = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.tbOAuth = new DevExpress.XtraEditors.TextEdit();
            this.tbBotUsername = new DevExpress.XtraEditors.TextEdit();
            this.lbBotUsername = new DevExpress.XtraEditors.LabelControl();
            this.groupDraft = new DevExpress.XtraEditors.GroupControl();
            this.lbTimeLeft = new DevExpress.XtraEditors.LabelControl();
            this.btNextPick = new DevExpress.XtraEditors.SimpleButton();
            this.lbCard3 = new System.Windows.Forms.Label();
            this.lbCard2 = new System.Windows.Forms.Label();
            this.lbCard1 = new System.Windows.Forms.Label();
            this.picCard3 = new System.Windows.Forms.PictureBox();
            this.picCard2 = new System.Windows.Forms.PictureBox();
            this.picCard1 = new System.Windows.Forms.PictureBox();
            this.btStartDraft = new DevExpress.XtraEditors.SimpleButton();
            this.btStopDraft = new DevExpress.XtraEditors.SimpleButton();
            this.checkAutoPick = new DevExpress.XtraEditors.CheckEdit();
            this.timePick = new DevExpress.XtraEditors.TimeSpanEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lbVersion = new DevExpress.XtraEditors.LabelControl();
            this.lbCopyright = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.pickTimer = new System.Windows.Forms.Timer(this.components);
            this.draftTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupConfig)).BeginInit();
            this.groupConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTwitchChannel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOAuth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBotUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDraft)).BeginInit();
            this.groupDraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAutoPick.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePick.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupConfig
            // 
            this.groupConfig.Controls.Add(this.btConnect);
            this.groupConfig.Controls.Add(this.tbTwitchChannel);
            this.groupConfig.Controls.Add(this.lbTwitchChannel);
            this.groupConfig.Controls.Add(this.lbBotOAuth);
            this.groupConfig.Controls.Add(this.tbOAuth);
            this.groupConfig.Controls.Add(this.tbBotUsername);
            this.groupConfig.Controls.Add(this.lbBotUsername);
            this.groupConfig.Location = new System.Drawing.Point(12, 12);
            this.groupConfig.Name = "groupConfig";
            this.groupConfig.Padding = new System.Windows.Forms.Padding(3);
            this.groupConfig.Size = new System.Drawing.Size(375, 105);
            this.groupConfig.TabIndex = 0;
            this.groupConfig.Text = "Config";
            // 
            // btConnect
            // 
            this.btConnect.Enabled = false;
            this.btConnect.Location = new System.Drawing.Point(256, 25);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(111, 73);
            this.btConnect.TabIndex = 6;
            this.btConnect.Text = "Connect";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // tbTwitchChannel
            // 
            this.tbTwitchChannel.Location = new System.Drawing.Point(90, 78);
            this.tbTwitchChannel.Name = "tbTwitchChannel";
            this.tbTwitchChannel.Size = new System.Drawing.Size(160, 20);
            this.tbTwitchChannel.TabIndex = 5;
            this.tbTwitchChannel.TextChanged += new System.EventHandler(this.tbConfigs_TextChanged);
            // 
            // lbTwitchChannel
            // 
            this.lbTwitchChannel.Location = new System.Drawing.Point(9, 81);
            this.lbTwitchChannel.Name = "lbTwitchChannel";
            this.lbTwitchChannel.Size = new System.Drawing.Size(73, 13);
            this.lbTwitchChannel.TabIndex = 4;
            this.lbTwitchChannel.Text = "Twitch Channel";
            // 
            // lbBotOAuth
            // 
            this.lbBotOAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbBotOAuth.Location = new System.Drawing.Point(34, 55);
            this.lbBotOAuth.Name = "lbBotOAuth";
            this.lbBotOAuth.Size = new System.Drawing.Size(50, 13);
            this.lbBotOAuth.TabIndex = 3;
            this.lbBotOAuth.Text = "Bot OAuth";
            this.lbBotOAuth.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.lbBotOAuth_HyperlinkClick);
            // 
            // tbOAuth
            // 
            this.tbOAuth.Location = new System.Drawing.Point(90, 52);
            this.tbOAuth.Name = "tbOAuth";
            this.tbOAuth.Size = new System.Drawing.Size(160, 20);
            this.tbOAuth.TabIndex = 2;
            this.tbOAuth.TextChanged += new System.EventHandler(this.tbConfigs_TextChanged);
            // 
            // tbBotUsername
            // 
            this.tbBotUsername.Location = new System.Drawing.Point(90, 26);
            this.tbBotUsername.Name = "tbBotUsername";
            this.tbBotUsername.Size = new System.Drawing.Size(160, 20);
            this.tbBotUsername.TabIndex = 1;
            this.tbBotUsername.TextChanged += new System.EventHandler(this.tbConfigs_TextChanged);
            // 
            // lbBotUsername
            // 
            this.lbBotUsername.Location = new System.Drawing.Point(17, 29);
            this.lbBotUsername.Name = "lbBotUsername";
            this.lbBotUsername.Size = new System.Drawing.Size(67, 13);
            this.lbBotUsername.TabIndex = 0;
            this.lbBotUsername.Text = "Bot Username";
            // 
            // groupDraft
            // 
            this.groupDraft.Controls.Add(this.lbTimeLeft);
            this.groupDraft.Controls.Add(this.btNextPick);
            this.groupDraft.Controls.Add(this.lbCard3);
            this.groupDraft.Controls.Add(this.lbCard2);
            this.groupDraft.Controls.Add(this.lbCard1);
            this.groupDraft.Controls.Add(this.picCard3);
            this.groupDraft.Controls.Add(this.picCard2);
            this.groupDraft.Controls.Add(this.picCard1);
            this.groupDraft.Controls.Add(this.btStartDraft);
            this.groupDraft.Controls.Add(this.btStopDraft);
            this.groupDraft.Controls.Add(this.checkAutoPick);
            this.groupDraft.Controls.Add(this.timePick);
            this.groupDraft.Controls.Add(this.labelControl1);
            this.groupDraft.Location = new System.Drawing.Point(12, 123);
            this.groupDraft.Name = "groupDraft";
            this.groupDraft.Padding = new System.Windows.Forms.Padding(3);
            this.groupDraft.Size = new System.Drawing.Size(375, 230);
            this.groupDraft.TabIndex = 1;
            this.groupDraft.Text = "Draft";
            // 
            // lbTimeLeft
            // 
            this.lbTimeLeft.Location = new System.Drawing.Point(9, 209);
            this.lbTimeLeft.Name = "lbTimeLeft";
            this.lbTimeLeft.Size = new System.Drawing.Size(59, 13);
            this.lbTimeLeft.TabIndex = 12;
            this.lbTimeLeft.Text = "Time left: 0s";
            // 
            // btNextPick
            // 
            this.btNextPick.Enabled = false;
            this.btNextPick.Location = new System.Drawing.Point(156, 52);
            this.btNextPick.Name = "btNextPick";
            this.btNextPick.Size = new System.Drawing.Size(65, 23);
            this.btNextPick.TabIndex = 11;
            this.btNextPick.Text = "Next";
            this.btNextPick.Click += new System.EventHandler(this.btNextPick_Click);
            // 
            // lbCard3
            // 
            this.lbCard3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCard3.Location = new System.Drawing.Point(263, 159);
            this.lbCard3.Name = "lbCard3";
            this.lbCard3.Size = new System.Drawing.Size(68, 23);
            this.lbCard3.TabIndex = 10;
            this.lbCard3.Text = "0";
            this.lbCard3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCard2
            // 
            this.lbCard2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCard2.Location = new System.Drawing.Point(152, 159);
            this.lbCard2.Name = "lbCard2";
            this.lbCard2.Size = new System.Drawing.Size(68, 23);
            this.lbCard2.TabIndex = 9;
            this.lbCard2.Text = "0";
            this.lbCard2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCard1
            // 
            this.lbCard1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCard1.Location = new System.Drawing.Point(38, 159);
            this.lbCard1.Name = "lbCard1";
            this.lbCard1.Size = new System.Drawing.Size(68, 23);
            this.lbCard1.TabIndex = 8;
            this.lbCard1.Text = "0";
            this.lbCard1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picCard3
            // 
            this.picCard3.Image = ((System.Drawing.Image)(resources.GetObject("picCard3.Image")));
            this.picCard3.Location = new System.Drawing.Point(266, 91);
            this.picCard3.Name = "picCard3";
            this.picCard3.Size = new System.Drawing.Size(65, 65);
            this.picCard3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard3.TabIndex = 7;
            this.picCard3.TabStop = false;
            // 
            // picCard2
            // 
            this.picCard2.Image = ((System.Drawing.Image)(resources.GetObject("picCard2.Image")));
            this.picCard2.Location = new System.Drawing.Point(155, 90);
            this.picCard2.Name = "picCard2";
            this.picCard2.Size = new System.Drawing.Size(65, 65);
            this.picCard2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard2.TabIndex = 6;
            this.picCard2.TabStop = false;
            // 
            // picCard1
            // 
            this.picCard1.Image = ((System.Drawing.Image)(resources.GetObject("picCard1.Image")));
            this.picCard1.Location = new System.Drawing.Point(41, 91);
            this.picCard1.Name = "picCard1";
            this.picCard1.Size = new System.Drawing.Size(65, 65);
            this.picCard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picCard1.TabIndex = 5;
            this.picCard1.TabStop = false;
            // 
            // btStartDraft
            // 
            this.btStartDraft.Enabled = false;
            this.btStartDraft.Location = new System.Drawing.Point(41, 52);
            this.btStartDraft.Name = "btStartDraft";
            this.btStartDraft.Size = new System.Drawing.Size(65, 23);
            this.btStartDraft.TabIndex = 4;
            this.btStartDraft.Text = "Start Draft";
            this.btStartDraft.Click += new System.EventHandler(this.btStartDraft_Click);
            // 
            // btStopDraft
            // 
            this.btStopDraft.Enabled = false;
            this.btStopDraft.Location = new System.Drawing.Point(267, 52);
            this.btStopDraft.Name = "btStopDraft";
            this.btStopDraft.Size = new System.Drawing.Size(64, 23);
            this.btStopDraft.TabIndex = 3;
            this.btStopDraft.Text = "Stop Draft";
            this.btStopDraft.Click += new System.EventHandler(this.btStopDraft_Click);
            // 
            // checkAutoPick
            // 
            this.checkAutoPick.Enabled = false;
            this.checkAutoPick.Location = new System.Drawing.Point(256, 27);
            this.checkAutoPick.Name = "checkAutoPick";
            this.checkAutoPick.Properties.Caption = "Auto Pick?";
            this.checkAutoPick.Size = new System.Drawing.Size(75, 19);
            this.checkAutoPick.TabIndex = 2;
            // 
            // timePick
            // 
            this.timePick.EditValue = System.TimeSpan.Parse("00:00:30");
            this.timePick.Location = new System.Drawing.Point(90, 26);
            this.timePick.Name = "timePick";
            this.timePick.Properties.AllowEditDays = false;
            this.timePick.Properties.AllowEditHours = false;
            this.timePick.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timePick.Properties.DisplayFormat.FormatString = "mm:ss";
            this.timePick.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.timePick.Properties.Mask.EditMask = "mm:ss";
            this.timePick.Properties.MaxDays = 0;
            this.timePick.Properties.MaxHours = 0;
            this.timePick.Properties.MaxMinutes = 6;
            this.timePick.Properties.TouchUIMaxValue = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.timePick.Properties.TouchUIMinValue = new System.DateTime(((long)(0)));
            this.timePick.Size = new System.Drawing.Size(160, 20);
            this.timePick.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(41, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Pick Time";
            // 
            // lbVersion
            // 
            this.lbVersion.Location = new System.Drawing.Point(351, 359);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(36, 13);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "v.0.0.2";
            // 
            // lbCopyright
            // 
            this.lbCopyright.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbCopyright.Location = new System.Drawing.Point(12, 359);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(101, 13);
            this.lbCopyright.TabIndex = 3;
            this.lbCopyright.Text = "2016 © exceptionptr";
            this.lbCopyright.HyperlinkClick += new DevExpress.Utils.HyperlinkClickEventHandler(this.lbCopyright_HyperlinkClick);
            // 
            // pickTimer
            // 
            this.pickTimer.Interval = 1000;
            this.pickTimer.Tick += new System.EventHandler(this.pickTimer_Tick);
            // 
            // draftTimer
            // 
            this.draftTimer.Tick += new System.EventHandler(this.draftTimer_Tick);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 384);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.groupDraft);
            this.Controls.Add(this.groupConfig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arena Draft Bot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.Load += new System.EventHandler(this.mainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupConfig)).EndInit();
            this.groupConfig.ResumeLayout(false);
            this.groupConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTwitchChannel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOAuth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBotUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupDraft)).EndInit();
            this.groupDraft.ResumeLayout(false);
            this.groupDraft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCard3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkAutoPick.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timePick.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupConfig;
        private DevExpress.XtraEditors.LabelControl lbBotUsername;
        private DevExpress.XtraEditors.HyperlinkLabelControl lbBotOAuth;
        private System.Windows.Forms.Button btConnect;
        private DevExpress.XtraEditors.LabelControl lbTwitchChannel;
        public DevExpress.XtraEditors.TextEdit tbBotUsername;
        public DevExpress.XtraEditors.TextEdit tbOAuth;
        public DevExpress.XtraEditors.TextEdit tbTwitchChannel;
        private DevExpress.XtraEditors.GroupControl groupDraft;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.CheckEdit checkAutoPick;
        public DevExpress.XtraEditors.TimeSpanEdit timePick;
        private DevExpress.XtraEditors.SimpleButton btStartDraft;
        private DevExpress.XtraEditors.SimpleButton btStopDraft;
        private DevExpress.XtraEditors.LabelControl lbVersion;
        private DevExpress.XtraEditors.HyperlinkLabelControl lbCopyright;
        private System.Windows.Forms.PictureBox picCard1;
        private System.Windows.Forms.PictureBox picCard3;
        private System.Windows.Forms.PictureBox picCard2;
        private System.Windows.Forms.Label lbCard3;
        private System.Windows.Forms.Label lbCard2;
        private System.Windows.Forms.Label lbCard1;
        private DevExpress.XtraEditors.SimpleButton btNextPick;
        private System.Windows.Forms.Timer pickTimer;
        private System.Windows.Forms.Timer draftTimer;
        private DevExpress.XtraEditors.LabelControl lbTimeLeft;
    }
}

