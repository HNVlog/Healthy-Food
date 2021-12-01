using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Healthy_Food.Models
{
    public class Blog_comments
    {
        [Key]
        public int Id { get; set; }
        public int Blog_id { get; set; }
        public int User_id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Messages { get; set; }

        public virtual Blogs Blog { get; set; }
        public virtual Users User { get; set; }

    }
}