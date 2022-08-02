using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using testapp.business.Concrete;
using testapp.data.EntityFrameCore;
using testapp.entity.Concrete;

namespace testapp.ui.ViewComponents.Login
{
    public class _navbarPartial: ViewComponent
    {
        
       

        public IViewComponentResult Invoke()
        {
            return View();
        }

        // [HttpPost]
        // public IViewComponentResult Invoke(GKLesson gk)
        // {
        //     gk.GKTotalNet= 25;
        //     gk.GKTotalPoint = 250;
        //     gk.KpssResultId=1;
        //     gm.TAdd(gk);
        //     return View();
        // }
        
    }
}