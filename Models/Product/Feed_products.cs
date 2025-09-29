using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models.Product
{
    internal class Feed_products
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal UnitWeight { get; set; }
        public bool IsActive { get; set; }
        public int AnimalTypeId { get; set; }
        public string Description { get; set; }
    }
}
