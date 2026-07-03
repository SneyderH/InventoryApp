using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventarioApp.Data;
using InventarioApp.Models;
using Microsoft.EntityFrameworkCore;

namespace InventarioApp.Services
{
    public class ProductService
    {
        public List<Product> GetAll()
        {
            using var context = new InventoryContext();
            return context.Products.OrderBy(p => p.Name).ToList();
        }

        public Product? SearchByCode(string barCode)
        {
            using var context = new InventoryContext();
            return context.Products
                .FirstOrDefault(p => p.BarCode == barCode);
        }

        public List<Product> Search(string text)
        {
            using var context = new InventoryContext();
            return context.Products
                .Where(p => p.Name.Contains(text) || p.BarCode.Contains(text))
                .OrderBy(p => p.Name)
                .ToList();
        }

        public void Add(Product product)
        {
            using var context = new InventoryContext();
            context.Products.Add(product);
            context.SaveChanges();
        }

        public void Update(Product product)
        {
            using var context = new InventoryContext();
            context.Products.Update(product);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            using var context = new InventoryContext();
            var product = context.Products.Find(id);
            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }
        }

        public bool ExistingBarCode (string barCode, int idExclude = 0)
        {
            using var context = new InventoryContext();
            return context.Products
                .Any(p => p.BarCode == barCode && p.Id != idExclude);
        }
    }
}
