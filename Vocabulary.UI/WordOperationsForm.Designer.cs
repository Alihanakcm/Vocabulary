namespace Vocabulary.MainUI
{
    partial class WordOperationsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordOperationsForm));
            this.gbxWordOperations = new DevExpress.XtraEditors.GroupControl();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.cbxType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.RchSampleSentences = new System.Windows.Forms.RichTextBox();
            this.txtTurkishWord = new DevExpress.XtraEditors.TextEdit();
            this.txtEnglishWord = new DevExpress.XtraEditors.TextEdit();
            this.lblSampleSentences = new DevExpress.XtraEditors.LabelControl();
            this.lblEnglishWord = new DevExpress.XtraEditors.LabelControl();
            this.lblType = new DevExpress.XtraEditors.LabelControl();
            this.lblTurkishWord = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dgwWords = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gbxWordOperations)).BeginInit();
            this.gbxWordOperations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTurkishWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglishWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxWordOperations
            // 
            this.gbxWordOperations.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbxWordOperations.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbxWordOperations.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbxWordOperations.Appearance.Options.UseBackColor = true;
            this.gbxWordOperations.Appearance.Options.UseBorderColor = true;
            this.gbxWordOperations.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbxWordOperations.AppearanceCaption.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gbxWordOperations.AppearanceCaption.Options.UseBackColor = true;
            this.gbxWordOperations.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxWordOperations.Controls.Add(this.btnClear);
            this.gbxWordOperations.Controls.Add(this.cbxType);
            this.gbxWordOperations.Controls.Add(this.btnDelete);
            this.gbxWordOperations.Controls.Add(this.btnUpdate);
            this.gbxWordOperations.Controls.Add(this.btnAdd);
            this.gbxWordOperations.Controls.Add(this.RchSampleSentences);
            this.gbxWordOperations.Controls.Add(this.txtTurkishWord);
            this.gbxWordOperations.Controls.Add(this.txtEnglishWord);
            this.gbxWordOperations.Controls.Add(this.lblSampleSentences);
            this.gbxWordOperations.Controls.Add(this.lblEnglishWord);
            this.gbxWordOperations.Controls.Add(this.lblType);
            this.gbxWordOperations.Controls.Add(this.lblTurkishWord);
            this.gbxWordOperations.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.gbxWordOperations.Location = new System.Drawing.Point(881, 0);
            this.gbxWordOperations.Name = "gbxWordOperations";
            this.gbxWordOperations.Size = new System.Drawing.Size(573, 679);
            this.gbxWordOperations.TabIndex = 8;
            this.gbxWordOperations.Text = "İşlemler";
            // 
            // btnClear
            // 
            this.btnClear.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnClear.Appearance.BackColor2 = System.Drawing.Color.Red;
            this.btnClear.Appearance.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Appearance.Options.UseBackColor = true;
            this.btnClear.Appearance.Options.UseFont = true;
            this.btnClear.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClear.ImageOptions.SvgImage")));
            this.btnClear.Location = new System.Drawing.Point(52, 575);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(500, 72);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "TEMİZLE";
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // cbxType
            // 
            this.cbxType.Location = new System.Drawing.Point(176, 104);
            this.cbxType.Name = "cbxType";
            this.cbxType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cbxType.Properties.Appearance.Options.UseFont = true;
            this.cbxType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxType.Properties.Items.AddRange(new object[] {
            "Edat",
            "Fiil",
            "Fiilimsi",
            "İsim",
            "Sıfat",
            "Zamir",
            "Zarf"});
            this.cbxType.Properties.Sorted = true;
            this.cbxType.Size = new System.Drawing.Size(375, 28);
            this.cbxType.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.Appearance.BackColor2 = System.Drawing.Color.Red;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(52, 497);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(500, 72);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "SİL";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpdate.Appearance.BackColor2 = System.Drawing.Color.Aqua;
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Location = new System.Drawing.Point(52, 419);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(500, 72);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAdd.Appearance.BackColor2 = System.Drawing.Color.Lime;
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(52, 341);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(500, 72);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // RchSampleSentences
            // 
            this.RchSampleSentences.Location = new System.Drawing.Point(177, 143);
            this.RchSampleSentences.Name = "RchSampleSentences";
            this.RchSampleSentences.Size = new System.Drawing.Size(375, 157);
            this.RchSampleSentences.TabIndex = 4;
            this.RchSampleSentences.Text = "";
            // 
            // txtTurkishWord
            // 
            this.txtTurkishWord.Location = new System.Drawing.Point(177, 66);
            this.txtTurkishWord.Name = "txtTurkishWord";
            this.txtTurkishWord.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTurkishWord.Properties.Appearance.Options.UseFont = true;
            this.txtTurkishWord.Properties.Mask.EditMask = "\\p{L}+";
            this.txtTurkishWord.Size = new System.Drawing.Size(375, 28);
            this.txtTurkishWord.TabIndex = 2;
            // 
            // txtEnglishWord
            // 
            this.txtEnglishWord.Location = new System.Drawing.Point(176, 29);
            this.txtEnglishWord.Name = "txtEnglishWord";
            this.txtEnglishWord.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtEnglishWord.Properties.Appearance.Options.UseFont = true;
            this.txtEnglishWord.Properties.Mask.EditMask = "\\p{L}+";
            this.txtEnglishWord.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtEnglishWord.Size = new System.Drawing.Size(376, 28);
            this.txtEnglishWord.TabIndex = 1;
            // 
            // lblSampleSentences
            // 
            this.lblSampleSentences.Appearance.Font = new System.Drawing.Font("Georgia", 10F);
            this.lblSampleSentences.Appearance.Options.UseFont = true;
            this.lblSampleSentences.Location = new System.Drawing.Point(65, 143);
            this.lblSampleSentences.Name = "lblSampleSentences";
            this.lblSampleSentences.Size = new System.Drawing.Size(105, 20);
            this.lblSampleSentences.TabIndex = 4;
            this.lblSampleSentences.Text = "Örnek Cümle:";
            // 
            // lblEnglishWord
            // 
            this.lblEnglishWord.Appearance.Font = new System.Drawing.Font("Georgia", 10F);
            this.lblEnglishWord.Appearance.Options.UseFont = true;
            this.lblEnglishWord.Location = new System.Drawing.Point(100, 29);
            this.lblEnglishWord.Name = "lblEnglishWord";
            this.lblEnglishWord.Size = new System.Drawing.Size(70, 20);
            this.lblEnglishWord.TabIndex = 1;
            this.lblEnglishWord.Text = "İngilizce:";
            // 
            // lblType
            // 
            this.lblType.Appearance.Font = new System.Drawing.Font("Georgia", 10F);
            this.lblType.Appearance.Options.UseFont = true;
            this.lblType.Location = new System.Drawing.Point(127, 106);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(43, 20);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Türü:";
            // 
            // lblTurkishWord
            // 
            this.lblTurkishWord.Appearance.Font = new System.Drawing.Font("Georgia", 10F);
            this.lblTurkishWord.Appearance.Options.UseFont = true;
            this.lblTurkishWord.Location = new System.Drawing.Point(112, 66);
            this.lblTurkishWord.Name = "lblTurkishWord";
            this.lblTurkishWord.Size = new System.Drawing.Size(58, 20);
            this.lblTurkishWord.TabIndex = 2;
            this.lblTurkishWord.Text = "Türkçe:";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dgwWords);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(881, 679);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Kelimeler";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(62, 645);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(444, 32);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "*Güncellemek istediğiniz kelimenin üserine çift tıklayınız.\r\n**Silmek istediğiniz" +
    " kelimenin üzerine tıkladıktan sonra sil butonuna tıklayınız.";
            // 
            // dgwWords
            // 
            this.dgwWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgwWords.Location = new System.Drawing.Point(0, 24);
            this.dgwWords.MainView = this.gridView1;
            this.dgwWords.Name = "dgwWords";
            this.dgwWords.Size = new System.Drawing.Size(881, 655);
            this.dgwWords.TabIndex = 0;
            this.dgwWords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.dgwWords;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.GridView1_DoubleClick);
            // 
            // WordOperationsForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1454, 675);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gbxWordOperations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WordOperationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime İşlemleri";
            this.Load += new System.EventHandler(this.WordOperationsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbxWordOperations)).EndInit();
            this.gbxWordOperations.ResumeLayout(false);
            this.gbxWordOperations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbxType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTurkishWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEnglishWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwWords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbxWordOperations;
        private DevExpress.XtraEditors.ComboBoxEdit cbxType;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.RichTextBox RchSampleSentences;
        private DevExpress.XtraEditors.TextEdit txtTurkishWord;
        private DevExpress.XtraEditors.TextEdit txtEnglishWord;
        private DevExpress.XtraEditors.LabelControl lblSampleSentences;
        private DevExpress.XtraEditors.LabelControl lblEnglishWord;
        private DevExpress.XtraEditors.LabelControl lblType;
        private DevExpress.XtraEditors.LabelControl lblTurkishWord;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraGrid.GridControl dgwWords;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}