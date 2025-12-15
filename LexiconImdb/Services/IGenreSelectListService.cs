using Microsoft.AspNetCore.Mvc.Rendering;

namespace LexiconImdb.Services
{
    public interface IGenreSelectListService
    {
        Task<IEnumerable<SelectListItem>> GetGenresAsync();
    }
}