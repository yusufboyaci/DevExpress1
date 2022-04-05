using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExpress1.Controllers
{
    public class LookupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
