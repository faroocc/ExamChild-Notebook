using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testapp.ui.Models
{
    public class PasswordChange
    {
        public string? formerPassword { get; set; }
        public string? NewPassword { get; set; }
        [Compare("NewPassword")]
        public string? ConfirmNewPassword { get; set; }
    }
}