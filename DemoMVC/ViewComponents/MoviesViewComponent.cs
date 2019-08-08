using DemoMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.ViewComponents
{
    public class MoviesViewComponent : ViewComponent
    {

        private readonly MoviesContext _moviesContext;

        public MoviesViewComponent(MoviesContext moviesContext)
        {
            _moviesContext = moviesContext;
        }

        public async Task<IViewComponentResult> InvokeAsync(int max = 10)
        {
            var movies = await _moviesContext.Movies.Take(max).ToListAsync();
            return View(movies);
        }
    }


}
