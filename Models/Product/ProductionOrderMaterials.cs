using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models.Product
{
    internal class ProductionOrderMaterials
    {
        public int Id { get; set; }
        public int MaterialId { get; set; }
        public decimal QuantityUsed { get; set; }
    }
}
