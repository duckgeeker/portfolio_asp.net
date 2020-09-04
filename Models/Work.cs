using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Work
    {
        [Key]
        public int work_id { get; set; }
        public string desc_short { get; set; }
        public string desc_long { get; set; }
        public string image { get; set; }
        public string tools { get; set; }
        //public string type { get; set; }
    }
}
