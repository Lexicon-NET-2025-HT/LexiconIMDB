using LexiconImdb.Data;
using LexiconImdb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LexiconImdb.ViewComponents
{
    //[ViewComponent] //Om vi inte har ViewComponent i namnet
    public class StarViewComponent : ViewComponent
    {
        //private readonly LexiconImdbContext _context;

        //public StarViewComponent(LexiconImdbContext context)
        //{
        //    _context = context; 
        //}

        public IViewComponentResult Invoke(float rating)
        {
            var roundedRating = (int)Math.Floor(rating);

            var model = new StarViewModel
            {
                Stars = roundedRating,
                IsHalfStar = rating % 1 >= 0.5f
            };

            return View(model); 
        }

    }
}
