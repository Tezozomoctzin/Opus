using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Opus.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public int NumberOfTransactions { get; set; }
        public FinancialStability FinancialStability { get; set; }
        public int FinancialStabilityId { get; set; }       
        public DateTime? BirthDate { get; set; }

    }
}