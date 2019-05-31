using System.Data.Entity;
using Vocabulary.Entity.Concrete;

namespace Vocabulary.DataAccess.Concrete.EntityFramework
{
    public class VocabularyContext:DbContext
    {
        public DbSet<Word> Words { get; set; }
        public DbSet<Month> Months { get; set; }
    }
}
