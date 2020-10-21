using System;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeThings.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
