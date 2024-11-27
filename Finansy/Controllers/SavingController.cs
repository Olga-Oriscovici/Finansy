using Finansy.Models;
using Microsoft.AspNetCore.Mvc;

namespace Finansy.Controllers
{
    public class SavingController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SavingsModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateFutureValue();
                ViewBag.FutureValue = model.FutureValue;
            }
            return View(model);
        }
    }
}
