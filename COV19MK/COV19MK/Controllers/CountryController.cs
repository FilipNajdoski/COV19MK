using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using COV19MK.Services.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace COV19MK.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}