using System.Collections.Generic;
using System.Data;
using System.Linq;
using Ninject.Infrastructure.Language;
using Vocabulary.Business.Abstract;
using Vocabulary.DataAccess.Abstract;
using Vocabulary.Entity.Concrete;

namespace Vocabulary.Business.Concrete
{
    public class MonthManager:IMonthService
    {
        private IMonthDal _monthDal;

        public MonthManager(IMonthDal monthDal)
        {
            _monthDal = monthDal;
        }

        public List<Month> GetMonths(int year)
        {
            return _monthDal.StatisticsGet(p=>p.Monthid==year);
        }

        public void Update(Month month)
        {
            _monthDal.Update(month);
        }

        public bool isYear(int year)
        {
            return _monthDal.YearQuery(p=>p.Monthid==year);
        }

        public void AddYear(Month month)
        {
            _monthDal.Add(month);
        }
    }
}
