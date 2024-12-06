using CurrencyConverter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CurrencyConverter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new CurrencyConverterModel
            {
                Amount = 0,
                OriginCurrency = "Select Currency",
                DestinationCurrency = "Select Currency"
            };

            ViewBag.Currencies = new List<string> { "DOP", "USD", "EUR" };

            return View(model);
        }

        [HttpPost]
        public IActionResult Convert(CurrencyConverterModel model)
        {
            if (model == null || string.IsNullOrEmpty(model.OriginCurrency) || string.IsNullOrEmpty(model.DestinationCurrency))
            {
                ModelState.AddModelError("", "Origen y destino de la moneda son requeridos.");
                ViewBag.Currencies = new List<string> { "DOP", "USD", "EUR" };
                return View("Index", model);
            }

            if (model.OriginCurrency == "DOP" && model.DestinationCurrency == "USD")
            {
                model.Result = model.Amount * 0.0165M;  //DOP a USD
            }
            else if (model.OriginCurrency == "DOP" && model.DestinationCurrency == "EUR")
            {
                model.Result = model.Amount * 0.0158M;  //DOP a EUR
            }
            else if (model.OriginCurrency == "USD" && model.DestinationCurrency == "DOP")
            {
                model.Result = model.Amount * 60.65M;  //USD a DOP
            }
            else if (model.OriginCurrency == "EUR" && model.DestinationCurrency == "DOP")
            {
                model.Result = model.Amount * 63.32M;  //EUR a DOP
            }
            else if (model.OriginCurrency == "USD" && model.DestinationCurrency == "EUR")
            {
                model.Result = model.Amount * 0.95M;  //USD a EUR
            }
            else if (model.OriginCurrency == "EUR" && model.DestinationCurrency == "USD")
            {
                model.Result = model.Amount * 1.06M;  //EUR a USD
            }

            ViewBag.Currencies = new List<string> { "DOP", "USD", "EUR" };

            return View("Index", model);
        }
    }
}