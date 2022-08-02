using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testapp.entity.Concrete
{
    public class GYLesson
    {
        [Key]
        public int GYLessonId { get; set; }
        public int GYCorrect { get; set; }
        public int GYINCorrect { get; set; }
        public int GYTotalNet { get; set; }
        public int GYTotalPoint { get; set; }
        public int KpssResultId { get; set; } 
        public KpssResult? KpssResult { get; set; } 
        // public List<GKandGY>? GKandGYs { get; set; }
    }
}