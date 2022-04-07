using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExpress1.Areas.BarCharts.Controllers
{
    [Area("BarCharts")]
    public class StandartBarController : Controller
    {
        public IActionResult StandartBar()
        {
            return View();
        }

        public IActionResult StandartBar2()
        {
            return View();
        }
    }
}
