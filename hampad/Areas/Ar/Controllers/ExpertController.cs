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

namespace hampad.Areas.Ar.Controllers
{
       public class ExpertController : BaseController
    {
       ////////////////////////////////////////////////////type db
        public ExpertController(ContextHampadco _db, IWebHostEnvironment env):base(_db,env)
        {
            
        }

        //////////////////////////////////////////////////////////
        public IActionResult Index()
        {
           
           //////////////////////////////////////////////////////////////////////////////////expert list
           ViewBag.expert=db.Tbl_Experts.Where(a=>a.Language==ln ).OrderByDescending(a=>a.Id).ToList();
           return View();
        }
        
         public IActionResult details(int id)
        {
           
           //////////////////////////////////////////////////////////////////////////////////expert list
           var expert=db.Tbl_Experts.Where(a =>a.Id==id && a.Language==ln).SingleOrDefault();
           if (expert == null)
           {
               return RedirectToAction("index","home");
           }
           return View(expert);
        }
        

    }
}
