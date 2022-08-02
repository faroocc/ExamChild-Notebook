using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using testapp.business.Concrete;
using testapp.data.EntityFrameCore;
using testapp.entity.Concrete;
using testapp.ui.Models;

namespace testapp.ui.Controllers;

    [AllowAnonymous]
public class HomeController : Controller
{
    private readonly UserManager<AppUser> _userManager;

    public HomeController(UserManager<AppUser> userManager)
    {
       _userManager=userManager;
    }
    public IActionResult Index()
    {
        // var values = tm.TGetByID(id);
        return View();
    }
    
    public async Task<PartialViewResult> Navbar()
    {
      var values = await _userManager.FindByNameAsync(User.Identity.Name);
      

      return PartialView();
    }
    
    public async Task<PartialViewResult> _sidenavbar()
    {
      var values = await _userManager.FindByNameAsync(User.Identity.Name);
      

      return PartialView();
    }
    

  
}
