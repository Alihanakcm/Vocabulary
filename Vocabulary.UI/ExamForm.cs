using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Vocabulary.Business.Abstract;
using Vocabulary.Business.DependencyResolvers;
using Vocabulary.Entity.Concrete;

namespace Vocabulary.MainUI
{
    public partial class ExamForm : DevExpress.XtraEditors.XtraForm
    {
        public ExamForm()
        {
            InitializeComponent();
            _wordService = InstanceFactory.GetInstance<IWordService>();
            _monthService = InstanceFactory.GetInstance<IMonthService>();
        }

        private IMonthService _monthService;
        private IWordService _wordService;
        private int _id;
        private DateTime _TimeToLearn;
        private DateTime _Exam1Time;
        private DateTime _Exam2Time;
        private DateTime _Exam3Time;
        private DateTime _Exam4Time;
        private string _TurkishWord;

        private void ExamForm_Load(object sender, EventArgs e)
        {
            this.BackColor = BackGroundSettings.Default.FormBackground;
            LoadWordInformations();
        }

        private void LoadWordInformations()
        {
            txtTurkishWordAnswer.Text = "";
            txtTurkishWordAnswer.Focus();
            if (_wordService.GetTime1())
            {
                foreach (var word in _wordService.GetWordInformations1())
                {

                    _id = word.id;
                    lblEnglishWord.Text = word.EnglishWord;
                    lblWordType.Text = word.WordType;
                    lblSentence.Text = word.Sentence;
                    pbcLearnState.EditValue = word.LearnState;
                    _TimeToLearn = word.TimeToLearn;
                    _Exam1Time = word.Exam1Time;
                    _Exam2Time = word.Exam2Time;
                    _Exam3Time = word.Exam3Time;
                    _Exam4Time = word.Exam4Time;
                    _TurkishWord = word.TurkishWord;
                }
            }
            else if (_wordService.GetTime2())
            {
                foreach (var word in _wordService.GetWordInformations2())
                {

                    _id = word.id;
                    lblEnglishWord.Text = word.EnglishWord;
                    lblWordType.Text = word.WordType;
                    lblSentence.Text = word.Sentence;
                    pbcLearnState.EditValue = word.LearnState;
                    _TimeToLearn = word.TimeToLearn;
                    _Exam1Time = word.Exam1Time;
                    _Exam2Time = word.Exam2Time;
                    _Exam3Time = word.Exam3Time;
                    _Exam4Time = word.Exam4Time;
                    _TurkishWord = word.TurkishWord;
                }
            }
            else if (_wordService.GetTime3())
            {
                foreach (var word in _wordService.GetWordInformations3())
                {

                    _id = word.id;
                    lblEnglishWord.Text = word.EnglishWord;
                    lblWordType.Text = word.WordType;
                    lblSentence.Text = word.Sentence;
                    pbcLearnState.EditValue = word.LearnState;
                    _TimeToLearn = word.TimeToLearn;
                    _Exam1Time = word.Exam1Time;
                    _Exam2Time = word.Exam2Time;
                    _Exam3Time = word.Exam3Time;
                    _Exam4Time = word.Exam4Time;
                    _TurkishWord = word.TurkishWord;
                }
            }
            else
            {
                foreach (var word in _wordService.GetWordInformations4())
                {

                    _id = word.id;
                    lblEnglishWord.Text = word.EnglishWord;
                    lblWordType.Text = word.WordType;
                    lblSentence.Text = word.Sentence;
                    pbcLearnState.EditValue = word.LearnState;
                    _TimeToLearn = word.TimeToLearn;
                    _Exam1Time = word.Exam1Time;
                    _Exam2Time = word.Exam2Time;
                    _Exam3Time = word.Exam3Time;
                    _Exam4Time = word.Exam4Time;
                    _TurkishWord = word.TurkishWord;
                }
            }
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            if (_wordService.GetTime1())
                SendWord1();
            else if (_wordService.GetTime2())
                SendWord2();
            else if (_wordService.GetTime3())
                SendWord3();
            else
                SendWord4();
        }
        private void SendWord4()
        {
            try
            { 
                if (_wordService.GetValue4(txtTurkishWordAnswer.Text))
                {
                        _wordService.Update(new Word
                        {
                            id = _id,
                            LearnState = Convert.ToInt32(pbcLearnState.EditValue) + 25,
                            EnglishWord = lblEnglishWord.Text,
                            WordType = lblWordType.Text,
                            Sentence = lblSentence.Text,
                            Exam1Time = _Exam1Time,
                            Exam2Time = _Exam2Time,
                            Exam3Time = _Exam3Time,
                            Exam4Time = DateTime.MaxValue,
                            TimeToLearn = _TimeToLearn,
                            TurkishWord = _TurkishWord,
                            Learning = true
                        });
                        XtraMessageBox.Show("Tebrikler kelimeyi doğru bildiniz", "Tebrikler!!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        if (!_monthService.isYear(DateTime.Now.Year))
                        {
                            _monthService.AddYear(new Month
                            {
                                Monthid = DateTime.Now.Year,
                                January = 0,
                                Fabruary = 0,
                                March = 0,
                                April = 0,
                                May = 0,
                                June = 0,
                                July = 0,
                                August = 0,
                                September = 0,
                                October = 0,
                                November = 0,
                                December = 0
                            });
                        }
                        if (_monthService.isYear(DateTime.Now.Year))
                        {
                            AddStatistic();
                        }
                }
                else
                {
                    XtraMessageBox.Show("Maalesef cevabınız doğru değil\nÖğrenme süreciniz sıfırlanmıştır.", "Yanlış Cevap",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    _wordService.Update(new Word
                    {
                        id = _id,
                        LearnState = 0,
                        EnglishWord = lblEnglishWord.Text,
                        WordType = lblWordType.Text,
                        Sentence = lblSentence.Text,
                        Exam1Time = DateTime.Now.AddDays(1),
                        Exam2Time = DateTime.Now.AddDays(7),
                        Exam3Time = DateTime.Now.AddMonths(1),
                        Exam4Time = DateTime.Now.AddMonths(6),
                        TimeToLearn = DateTime.Now,
                        TurkishWord = _TurkishWord,
                        Learning = true
                    });
                }
                LoadWordInformations();
                ExamControl();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
        }
        private void SendWord3()
        {
            try
            {
                    if (_wordService.GetValue3(txtTurkishWordAnswer.Text))
                    {
                        _wordService.Update(new Word
                        {
                            id = _id,
                            LearnState = Convert.ToInt32(pbcLearnState.EditValue) + 25,
                            EnglishWord = lblEnglishWord.Text,
                            WordType = lblWordType.Text,
                            Sentence = lblSentence.Text,
                            Exam1Time = _Exam1Time,
                            Exam2Time = _Exam2Time,
                            Exam3Time = DateTime.MaxValue,
                            Exam4Time = DateTime.Now.AddMonths(6),
                            TimeToLearn = _TimeToLearn,
                            TurkishWord = _TurkishWord,
                            Learning = true
                        });
                        XtraMessageBox.Show("Tebrikler kelimeyi doğru bildiniz", "Tebrikler!!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        XtraMessageBox.Show("Maalesef cevabınız doğru değil\nÖğrenme süreciniz sıfırlanmıştır.", "Yanlış Cevap",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _wordService.Update(new Word
                        {
                            id = _id,
                            LearnState = 0,
                            EnglishWord = lblEnglishWord.Text,
                            WordType = lblWordType.Text,
                            Sentence = lblSentence.Text,
                            Exam1Time = DateTime.Now.AddDays(1),
                            Exam2Time = DateTime.Now.AddDays(7),
                            Exam3Time = DateTime.Now.AddMonths(1),
                            Exam4Time = DateTime.Now.AddMonths(6),
                            TimeToLearn = DateTime.Now,
                            TurkishWord = _TurkishWord,
                            Learning = true
                        });
                    }

                LoadWordInformations();
                ExamControl();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
        }

        private void SendWord2()
        {
            try
            {
                if (_wordService.GetValue2(txtTurkishWordAnswer.Text))
                    {

                        _wordService.Update(new Word
                        {
                            id = _id,
                            LearnState = Convert.ToInt32(pbcLearnState.EditValue) + 25,
                            EnglishWord = lblEnglishWord.Text,
                            WordType = lblWordType.Text,
                            Sentence = lblSentence.Text,
                            Exam1Time = _Exam1Time,
                            Exam2Time = DateTime.MaxValue,
                            Exam3Time = DateTime.Now.AddMonths(1),
                            Exam4Time = DateTime.Now.AddMonths(6),
                            TimeToLearn = _TimeToLearn,
                            TurkishWord = _TurkishWord,
                            Learning = true
                        });
                        XtraMessageBox.Show("Tebrikler kelimeyi doğru bildiniz", "Tebrikler!!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                 }
                else
                 {
                        XtraMessageBox.Show("Maalesef cevabınız doğru değil\nÖğrenme süreciniz sıfırlanmıştır.", "Yanlış Cevap",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _wordService.Update(new Word
                        {
                            id = _id,
                            LearnState = 0,
                            EnglishWord = lblEnglishWord.Text,
                            WordType = lblWordType.Text,
                            Sentence = lblSentence.Text,
                            Exam1Time = DateTime.Now.AddDays(1),
                            Exam2Time = DateTime.Now.AddDays(7),
                            Exam3Time = DateTime.Now.AddMonths(1),
                            Exam4Time = DateTime.Now.AddMonths(6),
                            TimeToLearn = DateTime.Now,
                            TurkishWord = _TurkishWord,
                            Learning = true
                        });
                }
                LoadWordInformations();
                ExamControl();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
        }
        
        private void SendWord1()
        {
            try
            {
                var word = _wordService.GetValue1(txtTurkishWordAnswer.Text);
                if (_wordService.GetValue1(txtTurkishWordAnswer.Text))
                    {
                        _wordService.Update(new Word
                        {
                            id = _id,
                            LearnState = Convert.ToInt32(pbcLearnState.EditValue) + 25,
                            EnglishWord = lblEnglishWord.Text,
                            WordType = lblWordType.Text,
                            Sentence = lblSentence.Text,
                            Exam1Time = DateTime.MaxValue,
                            Exam2Time = DateTime.Now.AddDays(7),
                            Exam3Time = DateTime.Now.AddMonths(1),
                            Exam4Time = DateTime.Now.AddMonths(6),
                            TimeToLearn = _TimeToLearn,
                            TurkishWord = _TurkishWord,
                            Learning = true
                        });
                        XtraMessageBox.Show("Tebrikler kelimeyi doğru bildiniz", "Tebrikler!!!", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
                else
                {
                        XtraMessageBox.Show("Maalesef cevabınız doğru değil\nÖğrenme süreciniz sıfırlanmıştır.", "Yanlış Cevap",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        _wordService.Update(new Word
                        {
                            id = _id,
                            LearnState = 0,
                            EnglishWord = lblEnglishWord.Text,
                            WordType = lblWordType.Text,
                            Sentence = lblSentence.Text,
                            Exam1Time = DateTime.Now.AddDays(1),
                            Exam2Time = DateTime.Now.AddDays(7),
                            Exam3Time = DateTime.Now.AddMonths(1),
                            Exam4Time = DateTime.Now.AddMonths(6),
                            TimeToLearn = DateTime.Now,
                            TurkishWord = _TurkishWord,
                            Learning = true
                        });
                }
                LoadWordInformations();
                ExamControl();
            }
            catch (Exception e)
            {
                XtraMessageBox.Show(e.Message);
            }
        }
        private void AddStatistic()
        {
            foreach (var month in _monthService.GetMonths(DateTime.Now.Year))
            {
                switch (DateTime.Now.Month)
                {
                    case 1:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            January = month.January + 1
                        });
                        break;
                    case 2:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            Fabruary = month.Fabruary + 1
                        });
                        break;
                    case 3:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            March = month.March + 1
                        });
                        break;
                    case 4:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            April = month.January + 1
                        });
                        break;
                    case 5:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            May = month.May + 1
                        });
                        break;
                    case 6:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            June = month.January + 1
                        });
                        break;
                    case 7:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            July = month.July + 1
                        });
                        break;
                    case 8:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            August = month.August + 1
                        });
                        break;
                    case 9:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            September = month.September + 1
                        });
                        break;
                    case 10:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            October = month.October + 1
                        });
                        break;
                    case 11:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            November = month.November + 1
                        });
                        break;
                    case 12:
                        _monthService.Update(new Month
                        {
                            Monthid = DateTime.Now.Year,
                            December = month.December + 1
                        });
                        break;
                }
            }

            XtraMessageBox.Show("TEBRİKLER " + lblEnglishWord.Text + " KELİMESİNİ ÖĞRENDİNİZ",
                "Tebrikler!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ExamControl()
        {
            if (!(_wordService.GetTime1() || _wordService.GetTime2() || _wordService.GetTime3() || _wordService.GetTime4()))
            {
                XtraMessageBox.Show("Şu an için öğrenilecek kelime bulunmamaktadır", "Kelime Sınavı",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
        
    
