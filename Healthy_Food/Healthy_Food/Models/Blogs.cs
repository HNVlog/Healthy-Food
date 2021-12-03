using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Healthy_Food.Models
{
    public class Blogs
    {
        [Key]
        public int Id { get; set; }
        public int User_id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
     

        public virtual ICollection<Blog_comments> Blog_comment { get; set; }
        
        public virtual Users User { get; set; }
    }
}