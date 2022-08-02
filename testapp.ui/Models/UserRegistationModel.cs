using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testapp.ui.Models
{
    public class UserRegistationModel
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz") ]
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? UserName { get; set; }
        public string? phonenumber { get; set; }
        public string? Mail { get; set; }
        [Required(ErrorMessage ="Lütfen şifre giriniz")]
        public string? Password { get; set; }
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }
        public string? imageUrl{get;set;}
        public IFormFile? Image {get;set;}
    }
}