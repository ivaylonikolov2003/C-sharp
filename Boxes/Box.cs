using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    internal class Box
    {
        public int SerialNumber { get; set; }
        public Item item {  get; set; } = new Item();
        public int Quantity { get; set; }
        public decimal PriceForBox => item.Price * Quantity;
    }
}
