using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP4
{
    class DepreciationStraightLine:InventoryItem
    {
        private decimal startVal;
        public decimal StartVal
        {
            get { return startVal; }
            set
            {
                startVal = value;
                Calc();
            }
        }
        private decimal endVal;
        public decimal EndVal
        {
            get { return endVal; }
            set
            {
                endVal = value;
                Calc();
            }
        }
        private int lifetime;

        public int Lifetime
        {
            get { return lifetime; }
            set
            {
                lifetime = value;
                Calc();
            }
        }




        public override void Calc()
        {
            decimal annualDep, totalDep;
            annualDep = 0;
            totalDep = 0;
            decimal salvageVal = StartVal - EndVal;
            annualDep = salvageVal / Lifetime;
            for (int years =0;years <= Lifetime;years++)
            {
                salvageVal = salvageVal - annualDep;
                totalDep = totalDep + annualDep;
            }
        }

            


        


        public override string ToString()
        {
            return Title + ": Starting value of:  " + StartVal + ". Ending vaalue of:  " + EndVal
                + ". Added on: " + DateInInventory + ". Lifetime is : " + Lifetime + " years.";

        }










    }





}
