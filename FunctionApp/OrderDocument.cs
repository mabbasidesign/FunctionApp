using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionApp
{
    public class OrderDocument
    {
        public string id { get; set; } = String.Empty;
        public int productId { get; set; }
        public int quantity { get; set; }
        public string customerName { get; set; } = string.Empty;
        public string customerEmail { get; set; } = string.Empty;
        public decimal purchasePrice { get; set; }
    }
}
