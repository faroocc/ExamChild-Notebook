using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testapp.entity.Concrete
{
    public class GKandGY
    {
        public int GKLessonId { get; set; }
        public GKLesson? GKLessons { get; set; }
        public int GYLessonId { get; set; }
        public GYLesson? GYLessons { get; set; }
    }
}
