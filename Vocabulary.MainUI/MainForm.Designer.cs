namespace Vocabulary.MainUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblWelcome = new DevExpress.XtraEditors.LabelControl();
            this.btnWordLearn = new DevExpress.XtraEditors.SimpleButton();
            this.btnWordOperations = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAbout = new DevExpress.XtraEditors.SimpleButton();
            this.btnExam = new DevExpress.XtraEditors.SimpleButton();
            this.btnExit = new DevExpress.XtraEditors.SimpleButton();
            this.btnSettings = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Appearance.Font = new System.Drawing.Font("Elephant", 34.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblWelcome.Appearance.Options.UseFont = true;
            this.lblWelcome.Appearance.Options.UseForeColor = true;
            this.lblWelcome.Location = new System.Drawing.Point(32, 12);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(382, 75);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Hoş Geldiniz";
            // 
            // btnWordLearn
            // 
            this.btnWordLearn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnWordLearn.Appearance.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWordLearn.Appearance.Options.UseBackColor = true;
            this.btnWordLearn.Appearance.Options.UseFont = true;
            this.btnWordLearn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWordLearn.ImageOptions.Image")));
            this.btnWordLearn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnWordLearn.ImageOptions.SvgImage")));
            this.btnWordLearn.Location = new System.Drawing.Point(44, 117);
            this.btnWordLearn.Name = "btnWordLearn";
            this.btnWordLearn.Size = new System.Drawing.Size(355, 61);
            this.btnWordLearn.TabIndex = 1;
            this.btnWordLearn.Text = "KELİME ÖĞREN";
            this.btnWordLearn.Click += new System.EventHandler(this.BtnWordLearn_Click);
            // 
            // btnWordOperations
            // 
            this.btnWordOperations.Appearance.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnWordOperations.Appearance.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWordOperations.Appearance.Options.UseBackColor = true;
            this.btnWordOperations.Appearance.Options.UseFont = true;
            this.btnWordOperations.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnWordOperations.ImageOptions.SvgImage")));
            this.btnWordOperations.Location = new System.Drawing.Point(44, 251);
            this.btnWordOperations.Name = "btnWordOperations";
            this.btnWordOperations.Size = new System.Drawing.Size(355, 61);
            this.btnWordOperations.TabIndex = 3;
            this.btnWordOperations.Text = "KELİME İŞLEMLERİ";
            this.btnWordOperations.Click += new System.EventHandler(this.BtnWordOperations_Click);
            // 
            // BtnAbout
            // 
            this.BtnAbout.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BtnAbout.Appearance.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbout.Appearance.Options.UseBackColor = true;
            this.BtnAbout.Appearance.Options.UseFont = true;
            this.BtnAbout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAbout.ImageOptions.SvgImage")));
            this.BtnAbout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BtnAbout.Location = new System.Drawing.Point(93, 473);
            this.BtnAbout.Name = "BtnAbout";
            this.BtnAbout.Size = new System.Drawing.Size(240, 61);
            this.BtnAbout.TabIndex = 5;
            this.BtnAbout.Text = "HAKKINDA ";
            this.BtnAbout.Click += new System.EventHandler(this.BtnAbout_Click);
            // 
            // btnExam
            // 
            this.btnExam.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnExam.Appearance.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExam.Appearance.Options.UseBackColor = true;
            this.btnExam.Appearance.Options.UseFont = true;
            this.btnExam.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExam.ImageOptions.Image")));
            this.btnExam.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExam.ImageOptions.SvgImage")));
            this.btnExam.Location = new System.Drawing.Point(44, 184);
            this.btnExam.Name = "btnExam";
            this.btnExam.Size = new System.Drawing.Size(355, 61);
            this.btnExam.TabIndex = 2;
            this.btnExam.Text = "KELİME SINAVI";
            this.btnExam.Click += new System.EventHandler(this.BtnLearnState_Click);
            // 
            // btnExit
            // 
            this.btnExit.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.Appearance.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Appearance.Options.UseBackColor = true;
            this.btnExit.Appearance.Options.UseFont = true;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Location = new System.Drawing.Point(93, 540);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(240, 61);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSettings.Appearance.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Appearance.Options.UseBackColor = true;
            this.btnSettings.Appearance.Options.UseFont = true;
            this.btnSettings.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSettings.ImageOptions.SvgImage")));
            this.btnSettings.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnSettings.Location = new System.Drawing.Point(93, 406);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(240, 61);
            this.btnSettings.TabIndex = 4;
            this.btnSettings.Text = "AYARLAR";
            this.btnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(44, 318);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(355, 61);
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "İSTATİSTİKLER";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // MainForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.ForeColor = System.Drawing.Color.GreenYellow;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(448, 653);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExam);
            this.Controls.Add(this.BtnAbout);
            this.Controls.Add(this.btnWordOperations);
            this.Controls.Add(this.btnWordLearn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Hazinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblWelcome;
        private DevExpress.XtraEditors.SimpleButton btnWordLearn;
        private DevExpress.XtraEditors.SimpleButton btnWordOperations;
        private DevExpress.XtraEditors.SimpleButton BtnAbout;
        private DevExpress.XtraEditors.SimpleButton btnExam;
        private DevExpress.XtraEditors.SimpleButton btnExit;
        private DevExpress.XtraEditors.SimpleButton btnSettings;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}

