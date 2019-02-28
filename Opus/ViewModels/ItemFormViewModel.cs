using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Opus.Models;

namespace Opus.ViewModels
{
    public class ItemFormViewModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public Item Item { get; set; }
      
    }
}