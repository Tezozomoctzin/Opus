using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Opus.Models;

namespace Opus.ViewModels
{
    public class RandomItemViewModel
    {
        public Item Item { get; set; }
        public List<Customer> Customers { get; set; }
    }
}