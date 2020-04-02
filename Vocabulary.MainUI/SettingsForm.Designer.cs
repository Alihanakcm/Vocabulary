namespace Vocabulary.MainUI
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.lblSettings = new DevExpress.XtraEditors.LabelControl();
            this.lblBackGroundColor = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.cmbColors = new DevExpress.XtraEditors.ColorEdit();
            this.chkInitial = new DevExpress.XtraEditors.CheckEdit();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cmbColors.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInitial.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSettings
            // 
            this.lblSettings.Appearance.Font = new System.Drawing.Font("Elephant", 40F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
            this.lblSettings.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblSettings.Appearance.Options.UseFont = true;
            this.lblSettings.Appearance.Options.UseForeColor = true;
            this.lblSettings.Location = new System.Drawing.Point(102, 0);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(296, 87);
            this.lblSettings.TabIndex = 17;
            this.lblSettings.Text = "Ayarlar";
            // 
            // lblBackGroundColor
            // 
            this.lblBackGroundColor.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBackGroundColor.Appearance.Options.UseFont = true;
            this.lblBackGroundColor.Location = new System.Drawing.Point(54, 112);
            this.lblBackGroundColor.Name = "lblBackGroundColor";
            this.lblBackGroundColor.Size = new System.Drawing.Size(150, 24);
            this.lblBackGroundColor.TabIndex = 14;
            this.lblBackGroundColor.Text = "Arka Plan Rengi:";
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnSaveChanges.Appearance.Font = new System.Drawing.Font("Georgia", 12F);
            this.btnSaveChanges.Appearance.Options.UseBackColor = true;
            this.btnSaveChanges.Appearance.Options.UseFont = true;
            this.btnSaveChanges.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveChanges.ImageOptions.SvgImage")));
            this.btnSaveChanges.Location = new System.Drawing.Point(54, 226);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(383, 49);
            this.btnSaveChanges.TabIndex = 13;
            this.btnSaveChanges.Text = "DEĞİŞİKLİKLERİ KAYDET";
            this.btnSaveChanges.Click += new System.EventHandler(this.BtnSaveChanges_Click);
            // 
            // cmbColors
            // 
            this.cmbColors.EditValue = System.Drawing.Color.Empty;
            this.cmbColors.Location = new System.Drawing.Point(210, 110);
            this.cmbColors.Name = "cmbColors";
            this.cmbColors.Properties.Appearance.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbColors.Properties.Appearance.Options.UseFont = true;
            this.cmbColors.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbColors.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbColors.Size = new System.Drawing.Size(231, 30);
            this.cmbColors.TabIndex = 12;
            // 
            // chkInitial
            // 
            this.chkInitial.Location = new System.Drawing.Point(26, 156);
            this.chkInitial.Name = "chkInitial";
            this.chkInitial.Properties.Appearance.Font = new System.Drawing.Font("Georgia", 12F);
            this.chkInitial.Properties.Appearance.Options.UseFont = true;
            this.chkInitial.Properties.Caption = "Başlangıçta Açılma:";
            this.chkInitial.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.chkInitial.Size = new System.Drawing.Size(201, 28);
            this.chkInitial.TabIndex = 19;
            this.chkInitial.CheckedChanged += new System.EventHandler(this.CheckEdit1_CheckedChanged);
            // 
            // SettingsForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(495, 301);
            this.Controls.Add(this.chkInitial);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lblBackGroundColor);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.cmbColors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbColors.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkInitial.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblSettings;
        private DevExpress.XtraEditors.LabelControl lblBackGroundColor;
        private DevExpress.XtraEditors.SimpleButton btnSaveChanges;
        private DevExpress.XtraEditors.ColorEdit cmbColors;
        private DevExpress.XtraEditors.CheckEdit chkInitial;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}