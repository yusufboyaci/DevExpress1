﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExpress1.Areas.BasicComponents.Controllers
{
    [Area("BasicComponents")]
    public class CheckBoxController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
