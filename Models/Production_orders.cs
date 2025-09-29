using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models
{
    internal class Production_orders
    {
        public int ProductionOrderId { get; set; }
        public int FeedProductId { get; set; }
        public DateTime PlannedDate { get; set; }
        public int QuantityUnits { get; set; }
        public string Status { get; set; }
    }
}
