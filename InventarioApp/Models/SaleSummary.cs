using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioApp.Models
{
    public class SaleSummary
    {
        public int SaleTransactionId { get; set; }
        public DateTime Date {  get; set; }
        public decimal Total { get; set; }
    }
}
