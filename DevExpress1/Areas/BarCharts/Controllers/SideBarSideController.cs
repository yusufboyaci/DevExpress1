using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExpress1.Areas.BarCharts.Controllers
{
    [Area("BarCharts")]
    public class SideBarSideController : Controller
    {
        public IActionResult SideBarSide()
        {
            return View();
        }
    }
}
