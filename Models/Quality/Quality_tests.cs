using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models.Quality
{
    internal class Quality_tests
    {
        public int QualityTestId { get; set; }
        public int ProductId { get; set; }
        public int TestTypeId { get; set; }
        public int UserId { get; set; }
        public DateTime TestDate { get; set; }
        public string ResultSummary { get; set; }
        public bool Passed { get; set; }
    }
}
