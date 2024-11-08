using TestTranslation.Models;
namespace TestTranslation.Interfaces
{
    public interface ITranslationWordRepository
    {
        Task<TranslationWord?> GetTranslationAsync(string english);
    }
}
