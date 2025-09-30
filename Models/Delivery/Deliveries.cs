using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models.Delivery
{
    internal class Deliveries
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateTime PlannedDate { get; set; }
        public DateTime ActualDate { get; set; }
        public string DelayReason { get; set; }
    }
}
