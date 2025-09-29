using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models
{
    internal class Quality_test_details
    {
        public int DetailId { get; set; }
        public int QualityTestId { get; set; }
        public string ParameterName { get; set; }
        public decimal Value { get; set; }
        public string Unit { get; set; }
    }
}
