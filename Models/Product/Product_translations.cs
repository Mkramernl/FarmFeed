using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmFeed.Models
{
    internal class Product_translations
    {
        public int TranslationId { get; set; }
        public int ProductId { get; set; }
        public string LanguageCode { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
    }
}
