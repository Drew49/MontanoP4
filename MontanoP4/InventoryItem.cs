using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP4
{
    public abstract class InventoryItem
    {
        public string Title { get; set; }
        public decimal StartVal { get; set; }
        public decimal EndVal { get; set; }
        public int Lifetime { get; set; }
        public string DateInInventory { get; set; }
        public string DateOutOfInventory { get; set; }
        //public abstract string ToString();
        public abstract void Calc();

        

    }
}
