using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Vocabulary.Business.Abstract;
using Vocabulary.Business.DependencyResolvers;
using Vocabulary.Entity.Concrete;

namespace Vocabulary.MainUI
{
    public partial class WordLearnForm : DevExpress.XtraEditors.XtraForm
    {
        public WordLearnForm()
        {
            InitializeComponent();
            _wordService = InstanceFactory.GetInstance<IWordService>();
        }

        private IWordService _wordService;
        private void BtnLearn_Click(object sender, EventArgs e)
        {
            try
            {
                _wordService.Update(new Word
                {
                    id = Convert.ToInt32(gridLookUpEdit1View.GetFocusedRowCellValue("id")),
                    EnglishWord = gridLookUpEdit1View.GetFocusedRowCellValue("EnglishWord").ToString(),
                    TurkishWord = gridLookUpEdit1View.GetFocusedRowCellValue("TurkishWord").ToString(),
                    WordType = gridLookUpEdit1View.GetFocusedRowCellValue("WordType").ToString(),
                    Sentence = gridLookUpEdit1View.GetFocusedRowCellValue("Sentence").ToString(),
                    LearnState = Convert.ToInt32(gridLookUpEdit1View.GetFocusedRowCellValue("learnState")),
                    TimeToLearn = DateTime.Now,
                    Learning = true,
                    Exam1Time = DateTime.Now.AddDays(1),
                    Exam2Time = DateTime.Now.AddDays(7),
                    Exam3Time = DateTime.Now.AddMonths(1),
                    Exam4Time = DateTime.Now.AddMonths(6)
                });
                XtraMessageBox.Show("Öğrenme süreciniz başlamıştır.", "İngilizce Kelime Öğrenme", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch
            {
                XtraMessageBox.Show("Lütfen Bir Kelime Seçiniz","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void WordLearnForm_Load(object sender, EventArgs e)
        {
            this.BackColor = BackGroundSettings.Default.FormBackground;
            LoadWords();
        }
        private void LoadWords()
        {
            glueChooseWord.Properties.DataSource = _wordService.GetWordsByLearning();
            gridLookUpEdit1View.Columns.AddVisible("EnglishWord","İngilizce");
            gridLookUpEdit1View.Columns.AddVisible("TurkishWord", "Türkçe");
            glueChooseWord.Properties.DisplayMember = "EnglishWord";
        }
    }
}