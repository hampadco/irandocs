using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hampad.Models;
using DataLayer.Context;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using ViewModels.AdminViewModel.Originality;
using DataLayer.AdminEntities.Blog;
using Microsoft.AspNetCore.Hosting;

namespace hampad.Areas.Ar.Controllers
{
       public class HomeController : BaseController
    {
       ////////////////////////////////////////////////////type db
        public HomeController(ContextHampadco _db, IWebHostEnvironment env):base(_db,env)
        {
            
        }
         
       
        //////////////////////////////////////////////////////////
        public IActionResult Index()
        {


            menu.cat=db.tbl_category.Where( a=>a.Language==ln).ToList();
            menu.Richat=db.Tbl_Richats.SingleOrDefault()?.ScriptChat;
 
             ///////////////////////////////////////////////////////////////////////////////////////////////////////////count msg
              menu.resiver=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess=="admin" && a.ResiverMess==User.Identity.GetId()).Count();
              menu.sender=db.Tbl_Message.Where(a=>a.StateMess==false  && a.SenderMess==User.Identity.GetId()).Count();
             ///////////////////////////////////////////////////////////////////////////logo & titel
            var logo=db.Tbl_Logo.Where(a=>a.Language==ln).SingleOrDefault();
            if (logo != null)
            {
                  menu.logo=logo.ImageLogo;
                  menu.Title=logo.TitleLogo;
                 
            }else
            {
                menu.logo=null;
                menu.Title=null;
            }
          ////////////////////////////////////////////////////////////////////////////////social network
           var social=db.Tbl_SocialNetwork.ToList();
            if (social != null)
            {
                  menu.social=social;
                 
            }else
            {
                menu.social=null;
            }
          ////////////////////////////////////////////////////////////////////////////////////////////////address
           var address=db.Tbl_Adress.Where(a=>a.Language==ln).ToList();
            if (address != null)
            {
                  ViewBag.address=address;
                 
            }else
            {
                 ViewBag.address=null;
            }
          
            /////////////////////////////////////////////////////////////////////////////////////////////////////blog
         
            var blog=db.Tbl_Blog.Where(a=>a.Language==ln).OrderByDescending(a=>a.Id).Take(4).ToList();
             if (blog != null)
             {
                 ViewBag.blog=blog;
             }

           //////////////////////////////////////////////////////////////////slider
           var qslider=db.Tbl_Slider.Where(a=>a.Language==ln).OrderByDescending(a=>a.Id).ToList();
           if (qslider != null)
           {
               ViewBag.slider=qslider;
           }
           //////////////////////////////////////////////////////////////////baner
           var qbaner=db.Tbl_Baner.Where(a=>a.Language==ln).OrderByDescending(a=>a.Id).ToList();
           if (qbaner != null)
           {
               ViewBag.baner=qbaner;
           }
           /////////////////////////////////////////////////////////////////////////////////////////////////////first_page
           var qfirst=db.tbl_category.Where(a=>a.FatherIdCat==-3  ).ToList();
           
           List<Tb_Blog> blg = new List<Tb_Blog>();
           foreach (var item in qfirst)
           {
               var first=db.Tbl_Blog.Where(a=>a.IdCtegoryBlo==item.Id && a.Language==ln).SingleOrDefault();
               if (first != null)
               {
                   blg.Add(first);
               }
               
           }
           
             if (blg != null)
             {
                 ViewBag.first=blg.OrderByDescending(a=>a.Id).Take(2).ToList();
             }
           /////////////////////////////////////////////////////////////////////////////search product
           var qproduct=db.Tbl_Product.Where(a=>a.Language==ln).ToList();
           List<String> lp =new List<string>();
           foreach (var item in qproduct)
           {
               lp.Add(item.TitleProductPro);
           }
           ViewData["FieldsList"]= lp;
           /////////////////////////////////////////////////////////////////////////////search blog
           var qproduct1=db.Tbl_Blog.ToList();
           List<String> lp1 =new List<string>();
           foreach (var item in qproduct1)
           {
               lp1.Add(item.TitleBLo);
           }
           ViewData["FieldsList1"]= lp1;
           ///////////////////////////////////////////////////////////////////////////////teaser
           ViewBag.Teaser=db.Tbl_Teaser.Where(a=>a.Language==ln).OrderByDescending(a=>a.Id).Take(3).ToList();
           ////////////////////////////////////////////////////////////////////////////////product list
           ViewBag.product=db.Tbl_Product.Where(a=>a.Language==ln).OrderByDescending(a=>a.Id).Take(6).ToList();
           //////////////////////////////////////////////////////////////////////////////////expert list
           ViewBag.expert=db.Tbl_Experts.Where(a=>a.Language==ln).OrderByDescending(a=>a.Id).ToList();


           
            return View();
        }
        


        public IActionResult exit()
        {
             HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("index","home");
        }
        


        public IActionResult orgincheck(string id)
        {
          var orgin=db.Tbl_Originality.Where(a=>a.HologramCodeOri==id).ToList();
          if (orgin.Count() != 0)
          {
               ///////////////////////////////////////////////////////////list
           
            List<Vm_Originality>  originality=new  List<Vm_Originality>();
            foreach (var item in orgin)
            {
                var product=db.Tbl_Product.Where(a=>a.Id==item.IdProductOri).SingleOrDefault();
                 Vm_Originality  origin=new Vm_Originality()
                 {
                     Id=item.Id,
                     nameproduct=product.TitleProductPro,
                     HologramCodeOri=item.HologramCodeOri,
                     NumberProductOri=item.NumberProductOri,
                     Language=item.Language,
                     DateCreateOri=item.DateCreateOri,
                     img=product.ImageMainPro
                 };
                 originality.Add(origin);

            }
            
            ViewBag.listp=originality.OrderByDescending(a=>a.Id).ToList();
            //////////////////////////////////////////////////////////
          }else{
              error="چنین کد هولوگرامی در شرکت سون استار ثبت نشده است";
              return RedirectToAction("orgin");
          }
          return View();
        }
        
        [Authorize]
        public IActionResult orgin()
        {
            if (error != null)
            {
                ViewBag.e=error;
                error=null;
            }
            return View();
        }

    }
}
