using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Blog;
using DataLayer.Context;
using hampad.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModels.AdminViewModel.Blog;
using ViewModels.AdminViewModel.Comment;
using hampad.Models;
using Extensions;
using Microsoft.AspNetCore.Hosting;

namespace hampad.Areas.Ar.Controllers {
    public class BlogController : BaseController {
        ////////////////////////////////////////////////////type db
        
        public BlogController(ContextHampadco _db, IWebHostEnvironment env):base(_db,env)
        {
            
        }
        //////////////////////////////////////////////////////////
        public IActionResult Index (int id) {

            /////////////////////////////////////////////////////////////////////////////////////////////////////blog

            var qselect = db.tbl_category.Where (a => a.FatherIdCat == id && a.Language==ln).ToList ();
            if (qselect.Count () != 0) {
                var listblog = new List<Tb_Blog> ();
                foreach (var item in qselect) {

                    var blog = db.Tbl_Blog.Where (a => a.IdCtegoryBlo == item.Id && a.Language==ln).OrderByDescending (a => a.Id).ToList ();
                    if (blog != null) {
                        foreach (var item1 in blog) {
                            listblog.Add (item1);
                        }

                    }
                }
                if (listblog != null) {
                    ViewBag.blog = listblog.OrderByDescending (a => a.Id).ToList();
                }
            } else {
                var blog = db.Tbl_Blog.Where (a => a.IdCtegoryBlo == id && a.Language==ln).OrderByDescending (a => a.Id).ToList ();
                if (blog != null) {
                    ViewBag.blog = blog.OrderByDescending (a => a.Id).ToList();
                }

            }

            ////////////////////////////////////////////////////////////////////////////////////////////////////
            return View ();
        }

        public IActionResult details (int id) {

            var qblog = db.Tbl_Blog.Where (a => a.Id == id && a.Language==ln).SingleOrDefault ();
            /////////////////////////////////////////////////////////////////////////////////////////comment
            var qcomit=db.Tbl_Comments.Where(a=>a.blog_id==id && a.State==true && a.Language==ln).ToList();
            
            List<Vm_Comment> com=new  List<Vm_Comment>();
            foreach (var item in qcomit)
            {
                var name=db.Tbl_User.Where(a=>a.Id==Convert.ToInt32(item.User_Id) && a.Language==ln).SingleOrDefault();
                Vm_Comment comm=new Vm_Comment()
            {
                username=name.UserNameUs,
                dateshamsi=item.DateComment.ToPersianDateString(),
                Comment=item.Comment,
                image=name.ProfileImageUs

            };
            com.Add(comm);
            }
            ViewBag.comments=com.OrderByDescending(a=>a.Id).ToList();
            /////////////////////////////////////////////////////////////////////////////////////////////////////// 
            
            return View (qblog);
        }

    }
}