using LexiconImdb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LexiconImdb.Services
{
    public class GenreSelectListService : IGenreSelectListService
    {
        private readonly LexiconImdbContext _context;

        public GenreSelectListService(LexiconImdbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<SelectListItem>> GetGenresAsync()
        {
            return await _context.Movies.Select(m => m.Genre)
                .Distinct()
                .Select(g => new SelectListItem
                {
                    Text = g.ToString(),
                    Value = g.ToString()
                }).ToListAsync();
        }
    }
}
