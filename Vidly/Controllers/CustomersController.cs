using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers/Customers
        
        public ActionResult Customers()
        
        {

            var customers = new List<Customer>
            {
                new Customer { Name = "Pablo", Id=1},
                new Customer { Name = "Picasso", Id=2}
            };

            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}