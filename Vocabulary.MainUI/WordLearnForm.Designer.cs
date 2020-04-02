namespace Vocabulary.MainUI
{
    partial class WordLearnForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordLearnForm));
            this.lblchooseWord = new DevExpress.XtraEditors.LabelControl();
            this.btnLearn = new DevExpress.XtraEditors.SimpleButton();
            this.glueChooseWord = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.glueChooseWord.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // lblchooseWord
            // 
            this.lblchooseWord.Appearance.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblchooseWord.Appearance.Options.UseFont = true;
            this.lblchooseWord.Location = new System.Drawing.Point(65, 32);
            this.lblchooseWord.Name = "lblchooseWord";
            this.lblchooseWord.Size = new System.Drawing.Size(296, 20);
            this.lblchooseWord.TabIndex = 8;
            this.lblchooseWord.Text = "Öğrenmek İstediğiniz Kelimeyi Seçiniz:";
            // 
            // btnLearn
            // 
            this.btnLearn.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLearn.Appearance.Font = new System.Drawing.Font("Georgia", 13.8F);
            this.btnLearn.Appearance.Options.UseBackColor = true;
            this.btnLearn.Appearance.Options.UseFont = true;
            this.btnLearn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLearn.ImageOptions.SvgImage")));
            this.btnLearn.Location = new System.Drawing.Point(180, 86);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(334, 54);
            this.btnLearn.TabIndex = 10;
            this.btnLearn.Text = "ÖĞRENMEYE BAŞLA";
            this.btnLearn.Click += new System.EventHandler(this.BtnLearn_Click);
            // 
            // glueChooseWord
            // 
            this.glueChooseWord.Location = new System.Drawing.Point(367, 27);
            this.glueChooseWord.Name = "glueChooseWord";
            this.glueChooseWord.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F);
            this.glueChooseWord.Properties.Appearance.Options.UseFont = true;
            this.glueChooseWord.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.glueChooseWord.Properties.NullText = "";
            this.glueChooseWord.Properties.PopupView = this.gridLookUpEdit1View;
            this.glueChooseWord.Size = new System.Drawing.Size(295, 28);
            this.glueChooseWord.TabIndex = 12;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // WordLearnForm
            // 
            this.AcceptButton = this.btnLearn;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(727, 190);
            this.Controls.Add(this.glueChooseWord);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.lblchooseWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WordLearnForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Öğren";
            this.Load += new System.EventHandler(this.WordLearnForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.glueChooseWord.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblchooseWord;
        private DevExpress.XtraEditors.SimpleButton btnLearn;
        private DevExpress.XtraEditors.GridLookUpEdit glueChooseWord;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}