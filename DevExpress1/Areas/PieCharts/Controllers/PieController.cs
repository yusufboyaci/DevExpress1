using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExpress1.Areas.PieCharts.Controllers
{
    [Area("PieCharts")]
    public class PieController : Controller
    {      
        public IActionResult Pie()
        {
            return View();
        }

        public IActionResult Pie2()
        {
            return View();
        }
    }
}
