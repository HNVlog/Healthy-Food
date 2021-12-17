using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Healthy_Food.Models;
using System.IO;

namespace Healthy_Food.Controllers
{
    public class ProductsController : Controller
    {
        private DataContext context = new DataContext();
        // GET: Products
        public ActionResult Index()
        {
            
            var list = context.Products.ToList();

            return View(list); // passing data by model
        }

        
        
        
    }
}