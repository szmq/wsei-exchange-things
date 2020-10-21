using System;
using Microsoft.AspNetCore.Mvc;

namespace ExchangeThings.Controllers
{
    public class ExchangesController : Controller
    {
        //public ExchangesController()
        //{
        //}

        public IActionResult Show()
        {
            return View();
        }
    }
}
