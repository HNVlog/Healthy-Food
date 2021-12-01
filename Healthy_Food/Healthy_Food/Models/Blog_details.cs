using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Healthy_Food.Models
{
    public class Blog_details
    {
        [Key]
        public int Id { get; set; }
        public int Blog_category_id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }

        public virtual Blogs Blog { get; set; }
    }
}