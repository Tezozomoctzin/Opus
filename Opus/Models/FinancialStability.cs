using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Opus.Models
{
    public class FinancialStability
    {
        public int Id { get; set; }
        public string StabilityType { get; set; }
        public decimal PeakLoanValue { get; set; }
        public bool CouldBeADebtor { get; set; }
    }
}