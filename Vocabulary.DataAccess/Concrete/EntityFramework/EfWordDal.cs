using Vocabulary.DataAccess.Abstract;
using Vocabulary.Entity.Concrete;

namespace Vocabulary.DataAccess.Concrete.EntityFramework
{
    public class EfWordDal:EfEntityRepositoryBase<Word,VocabularyContext>,IWordDal
    {
    }
}
