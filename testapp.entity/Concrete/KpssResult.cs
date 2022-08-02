using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testapp.entity.Concrete
{
    public class KpssResult
    {
        [Key]
        public int KpssResultId { get; set; }
        public float ResultGY { get; set; }
        public float ResultGK { get; set; }
        public float ResultPoint { get; set; }
        public List<GKLesson>? GKLesson { get; set; }
        public List<GYLesson>? GYLesson { get; set; }
        public int AppUserId { get; set; } 
        public AppUser? AppUsers { get; set; } 
       
        
    }
}