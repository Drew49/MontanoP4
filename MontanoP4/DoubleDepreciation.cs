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

        public override void Calc()
        {
            decimal annualDep, totalDep;
            annualDep = 0;
            totalDep = 0;
            decimal salvageVal = StartVal - EndVal;
            annualDep = salvageVal / Lifetime;
            for (int years = 0; years <= Lifetime; years++)
            {
                salvageVal = salvageVal - (2* annualDep);
                totalDep = totalDep + annualDep;
            }
            

        }

        public override string ToString()
        {
            return Title + ": Starting value of:  " + StartVal
                + ". Ending value of:  " + EndVal + ". Added on: " + DateInInventory  +". Lifetime is : "
                +Lifetime + " years." + ". This will depreciate at double declining rate.";
        }
    }
}
