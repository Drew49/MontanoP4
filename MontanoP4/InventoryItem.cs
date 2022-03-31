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
        public abstract decimal StartVal { get; set; }
        public abstract decimal EndVal { get; set; }
        public abstract int Lifetime { get; set; }
        public abstract decimal AnnualDep { get; set; }
        public string DateInInventory { get; set; }
        public string DateOutOfInventory { get; set; }
       
        public abstract string ToString();
        protected abstract void Calc();

        

    }
}
