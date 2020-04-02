using System.Collections.Generic;
using System.Data;
using Vocabulary.Entity.Concrete;

namespace Vocabulary.Business.Abstract
{
    public interface IMonthService
    {
        List<Month> GetMonths(int year);
        void Update(Month month);
        bool isYear(int year);
        void AddYear(Month month);
    }
}
