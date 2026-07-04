using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioApp.Data;
using InventarioApp.Models;

namespace InventarioApp.Services
{
    public class SellService
    {
        public Product? SaleResult(string code)
        {
            using var context = new InventoryContext();
            Debug.WriteLine(context);
            return context.Products
                .FirstOrDefault(p => p.BarCode == code);
        }
    }
}
