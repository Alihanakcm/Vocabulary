using Ninject.Modules;
using Vocabulary.Business.Abstract;
using Vocabulary.Business.Concrete;
using Vocabulary.DataAccess.Abstract;
using Vocabulary.DataAccess.Concrete.EntityFramework;

namespace Vocabulary.Business.DependencyResolvers
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IWordService>().To<WordManager>();
            Bind<IWordDal>().To<EfWordDal>();

            Bind<IMonthService>().To<MonthManager>();
            Bind<IMonthDal>().To<EfMonthDal>();
        }
    }
}
