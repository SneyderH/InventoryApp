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
            return context.Products
                .FirstOrDefault(p => p.BarCode == code);
        }

        public int GetNextTransactionId()
        {
            using var context = new InventoryContext();
            
            if (!context.Sales.Any())
            {
                return 1;
            }

            return context.Sales.Max(s => s.SaleTransactionId) + 1;

        }

        public bool SaveSales(List<Sale> sales)
        {
            using var context = new InventoryContext();

            foreach (var sale in sales)
            {
                var product = context.Products.Find(sale.ProductId);

                if (product != null)
                {
                    if (product.Stock < sale.Amount)
                    {
                        return false;
                    }

                    product.Stock -= sale.Amount;
                    sale.ProductName = product.Name;
                    sale.UnitPrice = product.UnitPrice;
                }
                else
                {
                    return false;
                }

            }

            context.Sales.AddRange(sales);
            context.SaveChanges();
            return true;
        }

        public List<SaleSummary> GetTodaySalesSummary()
        {
            using var context = new InventoryContext();

            var todaySales = context.Sales
                .Where(s => s.Date.Date == DateTime.Today)
                .ToList();

            return todaySales
                .GroupBy(s => s.SaleTransactionId)
                .Select(g => new SaleSummary
                {
                    SaleTransactionId = g.Key,
                    Date = g.Min(s => s.Date),
                    Total = g.Sum(s => s.Subtotal)
                })
                .OrderByDescending(s => s.Date)
                .ToList();
        }

        public List<Sale> GetSaleDetails (int saleTransactionId)
        {
            using var context = new InventoryContext();
            return context.Sales
                .Where(s => s.SaleTransactionId == saleTransactionId)
                .OrderBy(s => s.Id)
                .ToList();
        }
    }
}
