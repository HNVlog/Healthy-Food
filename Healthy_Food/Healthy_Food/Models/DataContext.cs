using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Healthy_Food.Areas.Admin.Models;
namespace Healthy_Food.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("Healthy_Food") { }
        //public DbSet<Blog_comments> Blog_comment { get; set; }
        
        //public DbSet<Blogs> Blog { get; set; }
        //public DbSet<Brands> Brand { get; set; }
        
        //public DbSet<Orders> Order { get; set; }
        //public DbSet<Product_categories> Product_category { get; set; }
        //public DbSet<Product_images> Product_image { get; set; }
        //public DbSet<Products> Product { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Admin> Admins { get; set; }
    }
}