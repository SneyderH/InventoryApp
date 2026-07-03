using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioApp.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string BarCode { get; set; } = string.Empty;

        [Required]
        public string Name { get; set; } = string.Empty;

        public string? Category {  get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock {  get; set; }
        public int MinStock { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
