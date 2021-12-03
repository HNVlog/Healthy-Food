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
        public int Total { get; set; }
        public DateTime Product_time { get; set; }
        public string Product_id { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public virtual Products Product { get; set; }
        public virtual Users User { get; set; }
    }
}