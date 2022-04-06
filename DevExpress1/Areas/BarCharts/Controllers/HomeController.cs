using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExpress1.Areas.BarCharts.Controllers
{
    public class HomeController : Controller
    {
        [Area("BarCharts")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
