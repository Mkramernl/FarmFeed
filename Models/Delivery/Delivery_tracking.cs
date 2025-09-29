using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models
{
    internal class Delivery_tracking
    {
        public int TrackingId { get; set; }
        public int DeliveryId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Location { get; set; }
        public string StatusUpdate { get; set; }
    }
}
