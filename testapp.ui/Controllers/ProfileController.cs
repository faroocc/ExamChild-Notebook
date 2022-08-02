using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using testapp.business.Concrete;
using testapp.data.EntityFrameCore;
using testapp.entity.Concrete;
using testapp.ui.Models;

namespace testapp.ui.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly  SignInManager<AppUser> _signManager;
        KpssResultManager kpm = new KpssResultManager(new EfKpssResultDal());
        UserManager um = new UserManager(new EfUserDal());
        public ProfileController(UserManager<AppUser> userManager,SignInManager<AppUser> signManager)
        {
             _signManager=signManager;
            _userManager = userManager;
        }
        
        public async Task<IActionResult> Index()
        {

          var values = await _userManager.FindByNameAsync(User.Identity.Name);
          var valuesList= kpm.GetListWithAppUser(values.Id); 
          return View(valuesList);
        }
        [HttpGet]
        public async Task<IActionResult> ProfileDetail()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserRegistationModel userRegistationModel=new UserRegistationModel();
            userRegistationModel.Name=values.Name; 
            userRegistationModel.SurName=values.Surname; 
            userRegistationModel.phonenumber=values.PhoneNumber; 
            userRegistationModel.Mail=values.Email; 
            
            if (values.PhoneNumber == null)
            {
                userRegistationModel.phonenumber="(XXX)- XXX XXX XX XX"; 
            }
            return View(userRegistationModel);
        }
        [HttpPost]
        public async Task<IActionResult> ProfileDetail(UserRegistationModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension= Path.GetExtension(p.Image.FileName);
                var image= Guid.NewGuid() + extension;
                var saveLocation = resource + "/wwwroot/userimages/" + image;
                var stream = new FileStream(saveLocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl=image;
            }
            user.Name=p.Name;
            user.Surname=p.SurName;
            
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                await _signManager.SignOutAsync();
                return RedirectToAction("Login","Account");
            } 
            return View();
          
        }             
        [HttpGet]
        public async Task<IActionResult> PasswordChange()
        {
          var values = await _userManager.FindByNameAsync(User.Identity.Name);
          
          return View();
        }
        [HttpPost]
        public async Task<IActionResult> PasswordChange(PasswordChange p)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            PasswordChange passwordChange = new PasswordChange();
          //if ( values.PasswordHash == _userManager.PasswordHasher.HashPassword(values, p.formerPassword))
          //{
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values,p.NewPassword);
            var result = await _userManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                await _signManager.SignOutAsync();
                return RedirectToAction("Login","Account");
            } 
         // }
          
          return View();
        }
    }
}