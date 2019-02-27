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
    }
}