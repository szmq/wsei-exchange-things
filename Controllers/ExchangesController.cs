using System;
using Microsoft.AspNetCore.Mvc;
using Wsei.ExchangeThings.Web.Database;
using Wsei.ExchangeThings.Web.Entities;
using ExchangeThings.Models;

namespace ExchangeThings.Controllers
{
    public class ExchangesController : Controller
    {
        private readonly ExchangesDbContext _dbContext;

        public ExchangesController(ExchangesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public IActionResult Add(CompanyModel item)
        {
            var entity = new ItemEntity
            {
                Name = item.Name,
                Description = item.Description,
                IsVisible = item.IsVisible,
            };

            _dbContext.Items.Add(entity);
            _dbContext.SaveChanges();

            return RedirectToAction("AddConfirmation", new { itemId = entity.Id });
        }

        public IActionResult Show()
        {
            return View();
        }
    }
}
