using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models
{
    public class Comment
    {
        [Key]
        public int comment_id { get; set; }
        public string user_name { get; set; }
        public string contact_email { get; set; }
        public string feedback { get; set; }
    }
}
