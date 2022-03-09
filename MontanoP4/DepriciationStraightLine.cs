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
        /*private decimal annualDep;
        public override decimal AnnualDep
        {
            get { return annualDep; }
            set
            {
                annualDep = value;
                Calc();
            }
        }





        public override void Calc()
        {
            
            
            decimal salvageVal = StartVal - EndVal;
            AnnualDep = salvageVal / Lifetime;
            int years;
            /*for (years = 0 ;years <= lifetime; years++)
            {
                salvageVal = salvageVal - annualDep;
                totalDep = totalDep + annualDep;
            }
        }*/

            


        


        public override string ToString()
        {
            return Title + ": Starting value of:  " + StartVal + ". Ending vaalue of:  " + EndVal
                + ". Added on: " + DateInInventory + ". Lifetime is : " + Lifetime + " years.";

        }










    }





}
