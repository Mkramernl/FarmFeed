using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models.Product
{
    internal class Production_order_materials
    {
        public int ProductionOrderId { get; set; }
        public int MaterialId { get; set; }
        public decimal QuantityUsed { get; set; }
    }
}
