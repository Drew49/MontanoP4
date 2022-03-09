using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP4
{
    class DepreciationStraightLine:InventoryItem
    {

      

        public override string ToString()
        {
            return Title + ": Starting value of:  " + StartVal + ". Ending vaalue of:  " + EndVal
                + ". Added on: " + DateInInventory + ". Lifetime is : " + Lifetime + " years.";

        }

        public void Calc()
        {
            decimal annualDepreciation = (StartVal- EndVal) * (1 / Lifetime);
        }
       
              
    


    }





}
