using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hampad.Models;
using DataLayer.Context;
using ViewModels.AdminViewModel.Richat;
using DataLayer.AdminEntities.Richat;
using Microsoft.AspNetCore.Hosting;

namespace hampad.Areas.Admin.Controllers
{
   
    public class RayChatController : BaseController
    {
        public RayChatController(ContextHampadco _db,IWebHostEnvironment  env) :base(_db,env)
        {
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////index logo

        public IActionResult Index()
        {
             if (err != null)
            {
                ViewBag.er = err;
                err = null;
            }

            var list=db.Tbl_Richats.SingleOrDefault();
            if (list != null)
            {
             var qlist=new Vm_Richat()
            {
              ScriptChat=list.ScriptChat
            };
           return View(qlist);
            }
          
            return View();
        }

        public IActionResult add(Vm_Richat soc)
        {
          var listp=db.Tbl_Richats.SingleOrDefault();
          if (listp != null)
          {
              
              listp.ScriptChat=soc.ScriptChat;

              db.Tbl_Richats.Update(listp);
              db.SaveChanges();

              err="اطلاعات با موفقیت بروز رسانی شد";
          }
          else
          {
              var social=new Tbl_Richat()
              {
                ScriptChat=soc.ScriptChat
              };

              db.Tbl_Richats.Add(social);
              db.SaveChanges();
              err="اطلاعات با موفقیت ثبت شد";
          }
          return RedirectToAction("index");

        }

    }
}