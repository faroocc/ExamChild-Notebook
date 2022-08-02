using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using testapp.business.Concrete;
using testapp.data.EntityFrameCore;
using testapp.entity.Concrete;

namespace testapp.ui.Controllers
{
     [AllowAnonymous]
    public class PuanHesaplaController : Controller
    {
       
        KpssResultManager kpm = new KpssResultManager(new EfKpssResultDal());
         private readonly UserManager<AppUser> _userManager;

        public PuanHesaplaController(UserManager<AppUser> userManager)
        {
            _userManager=userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult GKLessonAdd()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult GKLessonAdd(GKLesson a)
        {

            
        
            return PartialView();
        }
        [HttpGet]
        public PartialViewResult GYLessonAdd()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult GYLessonAdd(GYLesson a)
        {
                       
            return PartialView();
        }
         [HttpGet]
        public PartialViewResult Result()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> Result(KpssResult a)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            a.AppUserId=values.Id;
            kpm.TAdd(a);

            return PartialView();
        }
        [HttpPost]
        public IActionResult DeletePoint(int kpssResultId)
        {
          var t = kpm.TGetByID(kpssResultId);
          
          if (t!=null)
          {
            kpm.TDelete(t);
            return RedirectToAction("index","profile");
          }
          return RedirectToAction("index","profile"); 
        }

    }
}