using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models.Product
{
    internal class ProductionOrders
    {
        public int Id { get; set; }
        public int FeedProductId { get; set; }
        public DateTime PlannedDate { get; set; }
        public int QuantityUnits { get; set; }
        public string Status { get; set; }
    }
}
