using Finansy.Data;
using Finansy.Models;
using Microsoft.AspNetCore.Mvc;

namespace Finansy.Controllers
{
    public class ServiceController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ServiceController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Save([FromBody] PricingModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.Title))
            {
                return BadRequest("Invalid data.");
            }

            // Сохранение данных в таблицу PricingPlans
            var pricingPlan = new PricingPlan
            {
                Title = model.Title,
                Price = model.Price
            };

            _dbContext.PricingPlans.Add(pricingPlan);
            _dbContext.SaveChanges();

            return Json(new { message = "Data saved successfully!" });
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetPricingPlansPartial()
        {
            // Получаем данные из базы
            var pricingPlans = _dbContext.PricingPlans.ToList();

            // Возвращаем Partial View с данными
            return PartialView("_PricingPlansPartial", pricingPlans);
        }
    }

   
    public class PricingModel
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
    }


}
