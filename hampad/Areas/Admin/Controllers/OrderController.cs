using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hampad.Models;
using DataLayer.Context;
using Microsoft.AspNetCore.Hosting;

namespace hampad.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class  OrderController: BaseController
    {
        public OrderController(ContextHampadco _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
        public IActionResult Index()
        {
            return View();
        }
          public IActionResult ongoing()
        {
            return View();
        }
          public IActionResult sender()
        {
            return View();
        }

    }
}