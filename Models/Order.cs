using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Order
    {
        [Key]
        public int order_id { get; set; }
        public string user_name { get; set; }
        public string contact_email { get; set; }

        public int workId { get; set; }
        public Work Work { get; set; }
    }
}
