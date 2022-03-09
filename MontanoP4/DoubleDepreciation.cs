using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP4
{
    public class DoubleDepreciation:InventoryItem
    {
        public DoubleDepreciation(string title, decimal startVal, decimal endVal)
        {
            Title = title;
            StartVal = startVal;
            EndVal = endVal;
        }

        public void Calc()
        {
            decimal doubleDeclineRate = 2 * (1 / Lifetime) * (StartVal);
        }

        public override string ToString()
        {
            return Title + ": Starting value of:  " + StartVal
                + ". Ending value of:  " + EndVal + ". Added on: " + DateInInventory  +". Lifetime is : "
                +Lifetime + " years." + ". This will depreciate at double declining rate.";
        }
    }
}
