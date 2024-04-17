using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    internal class Order
    {
        public required string ID { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        public decimal Value { get {  return Count * Price; } }
    }
}
