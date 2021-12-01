using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Healthy_Food.Models
{
    public class Product_images
    {
        [Key]
        public int Id { get; set; }
        public int Product_id { get; set; }

        public virtual Products Product { get; set; }
    }
}