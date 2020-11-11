using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.AdminEntities.Blog;
using DataLayer.AdminEntities.Comment;
using DataLayer.Context;
using hampad.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewModels.AdminViewModel.Originality;

namespace hampad.Areas.Ar.Controllers {
        [Area("Ar")]

    public class BaseController : Controller {
        ////////////////////////////////////////////////////type db
        public readonly ContextHampadco db;
        public readonly IWebHostEnvironment _env;

        public static string ln = "Ar", error, eror, suc, NewFileName;

        public BaseController (ContextHampadco _db, IWebHostEnvironment env) {
            _env = env;
            db = _db;

        }

    }
}