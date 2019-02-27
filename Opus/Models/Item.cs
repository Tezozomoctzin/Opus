using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Opus.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public decimal Price { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public Customer Customer { get; set; }
    }
}