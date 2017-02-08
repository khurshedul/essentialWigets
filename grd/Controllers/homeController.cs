using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using grd.Models;
using System.Collections.Specialized;

using System.Web.Caching;

namespace grd.Controllers
{
    public class homeController : Controller
    {
        //
        // GET: /home/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AutoComplete(string prefix)
        {
            bookDbContext entities = new bookDbContext();
            var customers = (from customer in entities.categories
                             where customer.catName.StartsWith(prefix)
                             select new
                             {
                                 label = customer.catName,
                                 val = customer.catName
                             }).ToList();

            return Json(customers);
        }

        [HttpPost]
        public ActionResult Index(string CustomerName, string CustomerId)
        {
           // ViewBag.Message = "CustomerName: " + CustomerName + " CustomerId: " + CustomerId;
            
            return View();
        }
 

    }
}
