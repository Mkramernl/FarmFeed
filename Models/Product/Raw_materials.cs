using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models.Product
{
    internal class raw_materials
    {
        public int MaterialId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal StockQuantity { get; set; }
        public bool IsActive { get; set; }
    }
}
