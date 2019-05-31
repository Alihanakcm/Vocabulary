using DevExpress.XtraEditors;
using Microsoft.Win32;
using System;
using System.Windows.Forms;
using Vocabulary.Business.Abstract;
using Vocabulary.Business.Concrete;
using Vocabulary.Business.DependencyResolvers;
using Vocabulary.DataAccess.Concrete.EntityFramework;

namespace Vocabulary.MainUI
{
    public partial class SettingsForm : DevExpress.XtraEditors.XtraForm
    {
        public SettingsForm()
        {
            InitializeComponent();
            _wordService = InstanceFactory.GetInstance<IWordService>();
            try
            {
                RegistryKey key= Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
            if (key.GetValue("Vocabulary").ToString()=="\""+Application.ExecutablePath+ "\"")
            {
                chkInitial.Checked = true;
            }

            }
            catch
            {
            }
          
        }

        private IWordService _wordService;
        private void CheckEdit1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkInitial.Checked)
            {
                RegistryKey key =
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("Vocabulary", "\""+Application.ExecutablePath+ "\"");
            }
            else
            {
                RegistryKey key =
                    Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.DeleteValue("Vocabulary");
            }
        }
        private void BtnSaveChanges_Click(object sender, EventArgs e)
        {
            BackGroundSettings.Default.FormBackground = cmbColors.Color;
            XtraMessageBox.Show("Değişiklikler kaydedildi", "Ayarlar", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            this.Close();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            this.BackColor = BackGroundSettings.Default.FormBackground;
        }
    }
}