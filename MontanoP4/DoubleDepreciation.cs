using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP4
{
    class DoubleDepreciation : InventoryItem
    {
        public DoubleDepreciation() { }
        
        private decimal startVal;
        public override decimal StartVal
        {
            get { return startVal; }
            set
            {
                startVal = value;
                //Calc();
            }
        }
        private decimal endVal;
        public override decimal EndVal
        {
            get { return endVal; }
            set
            {
                endVal = value;
               //Calc();
            }
        }
        private int lifetime;

        public override int Lifetime
        {
            get { return lifetime; }
            set
            {
                lifetime = value;
                //Calc();
            }
        }
        private decimal annualDep;//TODO: Should this property actually be the total? RJG
        public override decimal AnnualDep
        {
            get { return annualDep; }
            set
            {
                annualDep = value;
                Calc();
            }
        }

        protected override void Calc()
        {

            decimal salvageVal = StartVal - EndVal;
            AnnualDep = salvageVal / Lifetime;//TODO: Consider making this a vaiable local to the Calc method. RJG
            int years;
            for (years =  0; years <= lifetime; years++)
            {
                salvageVal = salvageVal - (2* annualDep);
                totalDep = totalDep + annualDep; //TODO: totalDep isn't defined. TotalDep should probably be a property and annualDep a variable declared in this method. RJG
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
