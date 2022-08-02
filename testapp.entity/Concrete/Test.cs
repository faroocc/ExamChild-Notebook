using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace testapp.entity.Concrete
{
    public class Test
    {
        [Key]
        public int TestId { get; set; }
        public string? TestName { get; set; }
        public string? TestImage { get; set; }
        public bool TestStatus { get; set; }
        public int TestTime { get; set; }
        public string? TestTimeString { get; set; }
        
        
    }
}