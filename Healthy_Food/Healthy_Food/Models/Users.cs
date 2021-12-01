using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Healthy_Food.Models
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Avatar { get; set; }
        public string Level { get; set; }

        public virtual ICollection<Blog_comments> Blog_comment { get; set; }
        public virtual ICollection<Blogs> Blog { get; set; }
        public virtual ICollection<Orders> Order { get; set; }

        

    }
}