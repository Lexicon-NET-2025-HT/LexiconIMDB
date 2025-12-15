using LexiconImdb.Models.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace LexiconImdb.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Movie> Movies { get; set; } = new List<Movie>();
        public IEnumerable<SelectListItem> Genres { get; set; } = new List<SelectListItem>();

        public string? Title { get; set; }
        public Genre? Genre { get; set; }
    }
}
