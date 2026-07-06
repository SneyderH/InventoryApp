using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioApp.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product? Product { get; set; }

        public string ProductName { get; set; } = string.Empty;
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Subtotal => Amount * UnitPrice;

        public DateTime Date { get; set; } = DateTime.Now;

        public int SaleTransactionId { get; set; }
    }
}
