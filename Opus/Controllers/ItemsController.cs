using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Opus.Models;
using Opus.ViewModels;

namespace Opus.Controllers
{
    public class ItemsController : Controller
    {
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

            var items = new List<Item>
            {
                new Item() {Id = 1, Name = "Kettle", Weight = 5.5},
                new Item() {Id = 2, Name = "TV", Weight = 10.0},
                new Item() {Id = 3, Name = "Bike", Weight = 22.7}
            };
            var viewModel = new ItemsViewModel
            {
                Items = items
            };
            return View(viewModel);
        }

        [Route("items/manufactured/{year:regex(\\d{4)}/{month:regex(\\d{2}:range{1,12})}")]
        public ActionResult ByManufactureDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}