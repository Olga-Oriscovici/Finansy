using Finansy.Data;
using Finansy.Models;
using Microsoft.AspNetCore.Mvc;

namespace Finansy.Controllers
{
    public class WalletController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WalletController(ApplicationDbContext context)
        {

            _context = context;

        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public IActionResult Create(WalletInfo wallet)
        {
            if (ModelState.IsValid)
            {
                _context.Wallets.Add(wallet);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            return View(wallet);
        }

        [HttpGet]
        public IActionResult Search(string name) {
         var wallets =_context.Wallets.Where(w =>w.Name.Contains(name)).ToList();
            return View(wallets);
        }

        public IActionResult Admin()
        {
            var wallets = _context.Wallets.ToList(); // Получение данных из базы данных
            return View(wallets);
        }

    }
        
    }

