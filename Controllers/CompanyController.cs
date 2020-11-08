using System;
using Microsoft.AspNetCore.Mvc;
using ExchangeThings.Models;

namespace ExchangeThings.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CompanyModel company)
        {
            //var viewModel = new CompanyAddedViewModel
            //{
            //    NumberOfCharsInName = company.Name.Length,
            //    NumberOfCharsInDescription = company.Description.Length,
            //    IsHidden = !company.IsVisible
            //};

            //return View("CompanyAdded", viewModel);
            return RedirectToAction("CompanyAdded");
        }

        [HttpGet]
        public IActionResult CompanyAdded()
        {
            return View();
        }
    }
}
