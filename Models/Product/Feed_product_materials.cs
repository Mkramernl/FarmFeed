using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models
{
    internal class Feed_product_materials
    {
        public int ProductId { get; set; }
        public int MaterialId { get; set; }
        public decimal AmountPerUnit { get; set; }
    }
}
