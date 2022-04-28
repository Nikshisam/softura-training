using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Product_Table_Task.Models;


namespace Product_Table_Task.Controllers
{
    [Route ("Product/Index")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            
                if (ModelState.IsValid)
                {
                    ProductDBContext dBContext = new ProductDBContext();
                    dBContext.Add(p);
                    dBContext.SaveChanges();
                    return Content("Saved");
                }
                return View("Index");
            }
            
        }
    }

