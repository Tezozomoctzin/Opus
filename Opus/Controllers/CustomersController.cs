using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Opus.Models;
using Opus.ViewModels;

namespace Opus.Controllers
{
    public class CustomersController : Controller
    {
        private OpusDbContext _context;

        public CustomersController()
        {
            _context = new OpusDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var financialStabilities = _context.FinancialStability.ToList();
            var viewModel = new CustomerFormViewModel
            {
                FinancialStabilities = financialStabilities
            };
            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        [Route("customers/create")]
        public ActionResult Save(Customer customer)
        {
            if (customer.Id == 0)
            {
                _context.Customers.Add(customer);
            }
            else
            {
                var customerInDd = _context.Customers.Single(c => c.Id == customer.Id);

                customerInDd.Name = customer.Name;
                customerInDd.BirthDate = customer.BirthDate;
                customerInDd.FinancialStabilityId = customer.FinancialStabilityId;
                customerInDd.IsActiveClient = customer.IsActiveClient;
            }
            
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }

        // GET: Customers
        public ActionResult Index()
        {

            var customers = _context.Customers.Include(c => c.FinancialStability).ToList();
            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(customers);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = _context.Customers.Include(c => c.FinancialStability).SingleOrDefault(c => c.Id == id);
            return View(customers);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                FinancialStabilities = _context.FinancialStability.ToList()
            };
            return View("CustomerForm", viewModel);
        }
    }
}