using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExpress1.Areas.PieCharts.Controllers
{
    public class HomeController : Controller
    {
        [Area("PieCharts")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
