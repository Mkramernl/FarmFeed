using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models
{
    internal class production_order_materials
    {
        public int ProductionOrderId { get; set; }
        public int MaterialId { get; set; }
        public decimal QuantityUsed { get; set; }
    }
}
