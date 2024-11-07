using Microsoft.EntityFrameworkCore;
using TestTranslation.Models;

namespace TestTranslation
{
    public class TranslationDBContext:DbContext
    {
        public TranslationDBContext(DbContextOptions<TranslationDBContext> options) : base(options) { }
        public DbSet<TranslationWord> TranslationWord { get; set; }
    }
}
