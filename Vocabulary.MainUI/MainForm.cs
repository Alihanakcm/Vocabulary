using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using Vocabulary.Business.Abstract;
using Vocabulary.Business.DependencyResolvers;

namespace Vocabulary.MainUI
{
    public partial class MainForm : DevExpress.XtraEditors.XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            _wordService = InstanceFactory.GetInstance<IWordService>();
        }
        private void BtnWordLearn_Click(object sender, EventArgs e)
        {
           ObjectCreation.wordLearnForm();
        }

        private IWordService _wordService;
        private void BtnLearnState_Click(object sender, EventArgs e)
        {
            try
            {
                    if (_wordService.GetTime1() || _wordService.GetTime2() || _wordService.GetTime3() || _wordService.GetTime4())
                    {
                        ObjectCreation.examForm();
                    }
                    else
                    {
                        XtraMessageBox.Show("Şu an için öğrenilecek kelime bulunmamaktadır", "Kelime Sınavı",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message);
            }
           
           
        }

        private void BtnWordOperations_Click(object sender, EventArgs e)
        {
           ObjectCreation.wordOperationsForm();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
           ObjectCreation.settingsForm();
        }

        private void BtnAbout_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("Develop By Alihan Akçam","Developer",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SimpleButton2_Click(object sender, EventArgs e)
        {
            ObjectCreation.statisticsForm();
        }
    }
}
