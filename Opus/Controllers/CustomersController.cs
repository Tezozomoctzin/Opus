using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Opus.Models;
using Opus.ViewModels;

namespace Opus.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>
        {
            new Customer() {Name = "Vasily Pantsuhenko", Id = 1},
            new Customer() {Name = "Grover IV", Id = 2},
            new Customer() {Name = "Chef Boyardee", Id = 3}
        };
        // GET: Customers
        public ActionResult Index()
        {
          
            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            Customer customer = customers[id-1];
            return View(customer);
        }
    }
}