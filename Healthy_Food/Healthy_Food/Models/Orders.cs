using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Healthy_Food.Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public int User_id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }

        public virtual Order_details Order_detail { get; set; }
        public virtual Users User { get; set; }
    }
}