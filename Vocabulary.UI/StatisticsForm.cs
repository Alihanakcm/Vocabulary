using DevExpress.XtraCharts;
using System;
using Vocabulary.Business.Abstract;
using Vocabulary.Business.DependencyResolvers;

namespace Vocabulary.MainUI
{
    public partial class StatisticsForm : DevExpress.XtraEditors.XtraForm
    {
        public StatisticsForm()
        {
            InitializeComponent();
            _monthService = InstanceFactory.GetInstance<IMonthService>();
        }

        private IMonthService _monthService;
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            this.BackColor = BackGroundSettings.Default.FormBackground;
        }

        private void LoadStatistics()
        {
            Series series1 =new Series();
            series1.Name = cbxYears.SelectedText;
            foreach (var word in _monthService.GetMonths(Convert.ToInt32(cbxYears.SelectedText)))
            {
                series1.Points.Add(new SeriesPoint("Ocak", word.January));
                series1.Points.Add(new SeriesPoint("Şubat", word.Fabruary));
                series1.Points.Add(new SeriesPoint("Mart", word.March));
                series1.Points.Add(new SeriesPoint("Nisan", word.April));
                series1.Points.Add(new SeriesPoint("Mayıs", word.May));
                series1.Points.Add(new SeriesPoint("Haziran", word.June));
                series1.Points.Add(new SeriesPoint("Temmuz", word.July));
                series1.Points.Add(new SeriesPoint("Ağustos", word.August));
                series1.Points.Add(new SeriesPoint("Eylül", word.September));
                series1.Points.Add(new SeriesPoint("Ekim", word.October));
                series1.Points.Add(new SeriesPoint("Kasım", word.November));
                series1.Points.Add(new SeriesPoint("Aralık", word.December));
            }
            chartcColumn.Series.Clear();
            chartcColumn.Series.Add(series1);
        }
        
        private void CbxYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadStatistics();
        }
    }
}