
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testapp.entity.Concrete
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        public string? LessonName { get; set; }
        public int LessonNumberofQuestions { get; set; }
        public int LessonCorrectAnswer { get; set; }
        public int LessonInCorrectAnswer { get; set; }
        public int LessonEmptyQuesitons { get; set; }
        public int LessonQuestionMultiplier { get; set; }
        public int LessonTotalResult { get; set; }
         
        
    }
}