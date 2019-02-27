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
    public class ItemsController : Controller
    {
        private OpusDbContext _context;

        public ItemsController()
        {
            _context = new OpusDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Items
        public ActionResult Random()
        {
            var item = new Item() {Name = "Kettle"};
            var customers = new List<Customer>
            {
                new Customer() {Name = "Vasily"},
                new Customer() {Name = "Elena"}
            };

            var viewModel = new RandomItemViewModel
            {
                Item = item,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("Id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var items = _context.Items.Include(c=>c.Customer).ToList();
            return View(items);
        }

        [Route("items/details/{id}")]
        public ActionResult Details(int id)
        {
            var item = _context.Items.Include(c => c.Customer).SingleOrDefault(c => c.Id == id);
            return View(item);
        }

        [Route("items/manufactured/{year:regex(\\d{4)}/{month:regex(\\d{2}:range{1,12})}")]
        public ActionResult ByManufactureDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}