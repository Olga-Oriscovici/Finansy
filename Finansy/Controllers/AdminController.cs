using Finansy.Data;
using Finansy.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Finansy.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController(ApplicationDbContext context)
        {

            _context = context;

        }
        
      
        [HttpGet]
        public IActionResult Admin(string name)
        {
            var wallets = _context.Wallets.Where(w => w.Name.Contains(name)).ToList();
            var wastes = _context.Wastes.ToList();

            var viewModel = new AdminPageViewModel
            {
                Wallets = wallets,
                Wastes = wastes
            };

            return View(viewModel);
        }
    }
}
