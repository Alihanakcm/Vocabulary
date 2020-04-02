namespace Vocabulary.MainUI
{
    public class ObjectCreation
    {
        private ObjectCreation()
        {
            
        }
        private static ExamForm _ExamForm;

        public static void examForm()
        {
            if (_ExamForm==null || _ExamForm.IsDisposed)
            {
                _ExamForm=new ExamForm();
                _ExamForm.Show();
            }           
        }

        private static SettingsForm _SettingsForm;

        public static void settingsForm()
        {
            if (_SettingsForm==null || _SettingsForm.IsDisposed)
            {
                _SettingsForm=new SettingsForm();
                _SettingsForm.Show();
            }
        }

        private static WordLearnForm _WordLearnForm;

        public static void wordLearnForm()
        {
            if (_WordLearnForm==null || _WordLearnForm.IsDisposed)
            {
                _WordLearnForm=new WordLearnForm();
                _WordLearnForm.Show();
            }
        }

        private static WordOperationsForm _WordOperationsForm;

        public static void wordOperationsForm()
        {
            if (_WordOperationsForm==null || _WordOperationsForm.IsDisposed)
            {
                _WordOperationsForm=new WordOperationsForm();
                _WordOperationsForm.Show();
            }
        }

        private static StatisticsForm _StatisticsForm;

        public static void statisticsForm()
        {
            if (_StatisticsForm==null || _StatisticsForm.IsDisposed)
            {
                _StatisticsForm=new StatisticsForm();
                _StatisticsForm.Show();
            }
        }
    }
}
