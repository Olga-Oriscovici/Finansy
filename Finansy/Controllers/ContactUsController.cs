using Finansy.Data;
using Microsoft.AspNetCore.Mvc;
using Finansy.Models;
using Microsoft.EntityFrameworkCore;

namespace Finansy.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactUsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Display the contact form
        public IActionResult Index()
        {
            return View("Index");
        }

        // POST: Handle the form submission
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Submit(ContactUs contactUs)
        {
            if (ModelState.IsValid)
            {
                // Save the data to the database
                _context.ContactUsEntries.Add(contactUs);
                await _context.SaveChangesAsync();

               
                return RedirectToAction("Index"); // Redirect back to the contact form
            }

            // If validation failed, return to the form with the data
            return View("Index", contactUs);
        }
        public IActionResult GetMessage()
        {
            // Получаем данные из базы
            var contact = _context.ContactUsEntries.ToList();

            // Возвращаем Partial View с данными
            return PartialView("_ContactUs", contact);
        }
    }
    public class ContactUsM
    {
        public string Name { get; set; }
        public string Message { get; set; }
    }

}
