using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using testapp.business.Concrete;
using testapp.data.EntityFrameCore;
using testapp.entity.Concrete;
using testapp.ui.Models;

namespace testapp.ui.Controllers
{
    [AllowAnonymous]
    
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly  SignInManager<AppUser> _signManager;
        public AccountController(SignInManager<AppUser> signManager, UserManager<AppUser> userManager)
        {
            _signManager=signManager;
            _userManager=userManager;
        }

    
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegistationModel p)
        {
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                Surname = p.SurName,
                Email = p.Mail,
                UserName = p.UserName
            };
            if (p.Password == p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, p.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("",item.Description);
                    }
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }
         [HttpPost]
        public async Task<IActionResult> Login(LoginUserModel p)
        {
          if (ModelState.IsValid)
          {
            var result = await _signManager.PasswordSignInAsync(p.UserName,p.PassWord,false,true);
            if (result.Succeeded)
            {
                return RedirectToAction("index","Home");
            }else{
                return View();
            }
          }  
          return View();
        }
        public async Task<IActionResult> Logout()
        {
          await _signManager.SignOutAsync();
          return RedirectToAction("index","Home");
        }

    }
}