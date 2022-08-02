using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testapp.entity.Concrete
{
    public class GKLesson
    {
        [Key]
        public int GKLessonId { get; set; }
        public int GKCorrect { get; set; }
        public int GKINCorrect { get; set; }
        public int GKTotalNet { get; set; }
        public int GKTotalPoint { get; set; }
        public int KpssResultId { get; set; } 
        public KpssResult? KpssResult { get; set; } 
        // public List<GKandGY>? GKandGYs { get; set; }

    }
}