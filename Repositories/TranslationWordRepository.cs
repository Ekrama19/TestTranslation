using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestTranslation.Interfaces;
using TestTranslation.Models;
using TestTranslation.Repositories;

namespace TestTranslation.Repositories
{
    public class TranslationWordRepository : ITranslationWordRepository
    {
        private readonly TranslationDBContext _context;

        public TranslationWordRepository(TranslationDBContext context)
        {
            _context = context;
        }

        public async Task<TranslationWord?> GetTranslationAsync(string english)
        {
            return await _context.TranslationWord
                .FirstOrDefaultAsync(w => w.English.ToLower() == english.ToLower());
        }
    }
}
