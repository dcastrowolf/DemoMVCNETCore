using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.ViewComponents
{
    public class MovieViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(Movie movie)
        {
            return View(movie);
        }

    }
}
