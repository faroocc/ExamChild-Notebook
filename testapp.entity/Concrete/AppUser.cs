using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace testapp.entity.Concrete
{
    public class AppUser: IdentityUser<int>
    {
        public string? ImageUrl { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Gender { get; set; }
        public List<KpssResult>? KpssResults { get; set; }
        
        
    }
}