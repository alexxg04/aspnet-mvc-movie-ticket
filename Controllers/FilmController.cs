using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Movie.Data;

namespace Movie.Controllers
{
    public class FilmController : Controller
    {
        private readonly AppDbContext _context;

        public FilmController(AppDbContext context)
        {
            _context = context;
        }

        public async Task <IActionResult> Index()

        {
            var allCinemas = await _context.Films.ToListAsync();
            return View();
        }
    }
}
