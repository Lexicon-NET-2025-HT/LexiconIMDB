using LexiconImdb.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LexiconImdb.Services
{
    public interface IGenreSelectListService
    {
        //Task<IEnumerable<SelectListItem>> GetGenresAsync();
        IEnumerable<SelectListItem> GetGenres(IEnumerable<Movie> movies); 
    }
}