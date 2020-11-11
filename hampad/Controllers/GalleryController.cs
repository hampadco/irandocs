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

namespace hampad.Controllers
{
       public class GalleryController : BaseController
    {
       ////////////////////////////////////////////////////type db
         public GalleryController(ContextHampadco _db,IWebHostEnvironment env):base(_db,env)
        {
            
        }
         
        //////////////////////////////////////////////////////////
        public IActionResult Index()
        {
           ////////////////////////////////////////////////////////////////////////////////////////////////address
          
           var gallery=db.Tbl_Gallery.Where(a=>a.Language==ln).OrderByDescending(a=>a.Id).ToList();
            if (gallery != null)
            {
                  ViewBag.gallery=gallery;
                 
            }else
            {
                 ViewBag.gallery=null;
            }
           return View();
        }


        public IActionResult details(int id)
        {
           ////////////////////////////////////////////////////////////////////////////////////////////////address
          
           var gallery=db.tb_ImageGalleries.Where(a=> a.Language==ln &&  a.IdGallery==id).OrderByDescending(a=>a.Id).ToList();
            if (gallery != null)
            {
                  ViewBag.gallery=gallery;
                 
            }else
            {
                 ViewBag.gallery=null;
            }
           return View();
        }
        
        

    }
}
