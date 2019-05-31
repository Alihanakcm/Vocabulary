using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using DevExpress.Data.Filtering.Helpers;
using Vocabulary.Business.Abstract;
using Vocabulary.Business.DependencyResolvers;
using Vocabulary.Entity.Concrete;

namespace Vocabulary.MainUI
{
    public partial class WordOperationsForm : DevExpress.XtraEditors.XtraForm
    {
        public WordOperationsForm()
        {
            InitializeComponent();
            _wordService = InstanceFactory.GetInstance<IWordService>();

        }

        private IWordService _wordService;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (_wordService.WordQuery(txtEnglishWord.Text))
            {
                XtraMessageBox.Show("Girmiş olduğunuz kelime mevcut lütfen başka bir kelime giriniz", "Kelime mevcut",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    _wordService.Add(new Word
                    {
                        EnglishWord = txtEnglishWord.Text,
                        TurkishWord = txtTurkishWord.Text,
                        WordType = cbxType.Text,
                        Sentence = RchSampleSentences.Text,
                        LearnState = 0,
                        TimeToLearn = DateTime.Now,
                        Exam1Time = DateTime.Now,
                        Exam2Time = DateTime.Now,
                        Exam3Time = DateTime.Now,
                        Exam4Time = DateTime.Now,
                        Learning = false
                    });
                    XtraMessageBox.Show("Kelime Eklendi", "Kelime Ekle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadWords();
                    Clear();

                }
                catch (Exception exception)
                {
                    XtraMessageBox.Show(exception.Message);
                }

            }
            txtEnglishWord.Focus();
        }
        private void WordOperationsForm_Load(object sender, EventArgs e)
        {
            this.BackColor = BackGroundSettings.Default.FormBackground;
            LoadWords();
        }

        private void LoadWords()
        {
            dgwWords.DataSource = _wordService.LoadWord();
            gridView1.Columns[6].Visible = false;
            gridView1.Columns[7].Visible = false;
            gridView1.Columns[8].Visible = false;
            gridView1.Columns[9].Visible = false;
            gridView1.Columns[10].Visible = false;
            gridView1.Columns[11].Visible = false;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                _wordService.Update(new Word
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("id")),
                    EnglishWord = txtEnglishWord.Text,
                    TurkishWord = txtTurkishWord.Text,
                    WordType = cbxType.Text,
                    Sentence = RchSampleSentences.Text,
                    TimeToLearn = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("TimeToLearn")),
                    Exam1Time = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Exam1Time")),
                    Exam2Time = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Exam3Time")),
                    Exam3Time = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Exam4Time")),
                    Exam4Time = Convert.ToDateTime(gridView1.GetFocusedRowCellValue("Exam2Time"))
                });
                XtraMessageBox.Show("Kelime Güncellendi", "Kelime Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWords();
                Clear();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
           
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _wordService.Delete(new Word { id = (Convert.ToInt32(gridView1.GetFocusedRowCellValue("id"))) });
                XtraMessageBox.Show("Kelime Silindi", "Kelime Sil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadWords();
                Clear();
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }     
           
        }
        private void GridView1_DoubleClick(object sender, EventArgs e)
        {
            txtEnglishWord.Text=gridView1.GetFocusedRowCellValue("EnglishWord").ToString();
            txtTurkishWord.Text = gridView1.GetFocusedRowCellValue("TurkishWord").ToString();
            cbxType.Text = gridView1.GetFocusedRowCellValue("WordType").ToString();
            RchSampleSentences.Text=gridView1.GetFocusedRowCellValue("Sentence").ToString();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtEnglishWord.Text = "";
            txtTurkishWord.Text = "";
            cbxType.Text = "";
            RchSampleSentences.Text = "";
            txtEnglishWord.Focus();
        }
    }
}