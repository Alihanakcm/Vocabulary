using Ninject;

namespace Vocabulary.Business.DependencyResolvers
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernel =new StandardKernel(new BusinessModule());
            return kernel.Get<T>();
        }
    }
}
