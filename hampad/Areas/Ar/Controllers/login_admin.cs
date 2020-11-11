using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hampad.Models;
using DataLayer.Context;
using ViewModels.AdminViewModel.User;
using DataLayer.AdminEntities.User;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;

namespace hampad.Areas.Ar.Controllers
{

       public class Login_adminController : BaseController
    {
        ////////////////////////////////////////////////////type db
         public Login_adminController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
        {
            
        }
         
         
        //////////////////////////////////////////////////////////


        public IActionResult Index()
        {
            
            ///////////////////////////////////////////////////////////////////////////logo & titel
            var logo=db.Tbl_Logo.Where(a=>a.Language==ln).SingleOrDefault();
            if (logo != null)
            {
                  ViewBag.logo=logo.ImageLogo;
                  ViewBag.Title=logo.TitleLogo;
                 
            }else
            {
                ViewBag.logo=null;
                 ViewBag.Title=null;
            }
          
            if (eror != null)
            {
                ViewBag.err=eror;
                eror=null;
            }
            
            return View();
        }
        



         public IActionResult login_check(Vm_User us)
        {

             
             var user = db.Tbl_User.Where(a=>a.UserNameUs == "admin").SingleOrDefault();

             
             
            if (user.PasswordUs == us.PasswordUs && us.UserNameUs=="admin")
            {
                 menu.img=user.ProfileImageUs;
              menu.resiver=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess!="admin").Count();
              menu.sender=db.Tbl_Message.Where(a=>a.StateMess==false && a.SenderMess=="admin").Count();
                if (user.ProfileImageUs == null)
                {
                    var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                    new Claim(ClaimTypes.Name,"admin")
                };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync(principal, properties);
                    return RedirectToAction("Index", "Home", new { area = "admin" });
                }
                else
                {
                    var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                    new Claim(ClaimTypes.Name,"admin")
                };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync(principal, properties);
                    return RedirectToAction("Index", "Home", new { area = "admin" });
                }

            }
            eror = "نام کاربری یا رمز عبور شما نادرست است";
            return RedirectToAction("Index");
        }

    }
}
