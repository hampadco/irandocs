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
       public class LoginController : BaseController
    {
        ////////////////////////////////////////////////////type db
           public LoginController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
        {
            
        }
         
         
        //////////////////////////////////////////////////////////


        public IActionResult Index()
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////////eror message
            if (eror != null)
            {
                ViewBag.err=eror;
                eror=null;
            }
            
            return View();
        }
        
        public IActionResult Register()
        {

            /////////////////////////////////////////////////////////////////////////////////////////////////////message err and success
            if (eror != null)
            {
                ViewBag.err=eror;
                eror=null;
            }
             if (suc != null)
            {
                ViewBag.suc=suc;
                suc=null;
            }
            return View();
        }
         public IActionResult Forget()
        {
            
            
            return View();
        }
        
        


        public IActionResult add(Vm_User us)
        {

            if (us.UserNameUs == "admin")
           {
               eror="نام ورودی غیر قابل قبول است ";
               return RedirectToAction("register");
           }
           if (us.PasswordUs != us.repass)
           {
               eror="رمز های وارد شده با هم مطابقت ندارند ";
               return RedirectToAction("register");
           }
           else if (db.Tbl_User.Any(a=>a.PhoneUs==us.PhoneUs))
           {
                eror="شماره تلفن مورد نظر قبلا ثبت شده است ";
               return RedirectToAction("register");
           }
           else
           {
               Tb_User tb=new Tb_User()
               {
                   UserNameUs=us.UserNameUs,
                   PasswordUs=us.PasswordUs,
                   PhoneUs=us.PhoneUs
                   

               } ;
               db.Tbl_User.Add(tb);
               db.SaveChanges();
               suc="ثبت نام با موفقیت انجام شد";
               return RedirectToAction("register");


           }
        }





         public IActionResult login_check(Vm_User us)
        {

            
            var user = db.Tbl_User.Where(a => a.PhoneUs == us.PhoneUs && a.PasswordUs == us.PasswordUs && a.UserNameUs!="admin").SingleOrDefault();
            if (user != null)
            {
                if (user.ProfileImageUs == null)
                {
                    var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                    new Claim(ClaimTypes.Name,"profile.png")
                };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync(principal, properties);
                    return RedirectToAction("index","profile");
                }
                else
                {
                    var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                    new Claim(ClaimTypes.Name,user.ProfileImageUs)
                };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = true
                    };

                    HttpContext.SignInAsync(principal, properties);
                    return RedirectToAction("index","profile");
                }

            }
            eror = "نام کاربری یا رمز عبور شما نادرست است";
            return RedirectToAction("index");
        }

    }
}
