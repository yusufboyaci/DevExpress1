using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExpress1.Areas.PieCharts.Controllers
{
    public class PieController : Controller
    {
        [Area("PieCharts")]
        public IActionResult Pie()
        {
            return View();
        }
    }
}
