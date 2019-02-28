using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Opus.Models;

namespace Opus.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<FinancialStability> FinancialStabilities { get; set; }
        public Customer Customer { get; set; }

    }
}