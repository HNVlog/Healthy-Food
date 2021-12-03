using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Healthy_Food.Models
{
    public class Products
    {
        [Key]
        public int Id { get; set; }
        public int Product_category_id { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public int Price { get; set; }
        public int Brand_id { get; set; }
        public int Discount { get; set; }
        public string Featured { get; set; }
        public string Status { get; set; }


        public virtual ICollection<Product_images> Product_image { get; set; }
        public virtual ICollection<Orders> Order { get; set; }
        public virtual Brands Brand { get; set; }
        public virtual Product_categories Product_category { get; set; }
    }
}