using Finansy.Data;
using Microsoft.AspNetCore.Mvc;

namespace Finansy.Controllers
{
    public class WastetsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WastetsController(ApplicationDbContext context)
        {

            _context = context;

        }
        public IActionResult Wastes()
        {
            var wastets= _context.Wastes.ToList(); // Получение данных из базы данных
            return View(wastets);
            
        }
    }
}
