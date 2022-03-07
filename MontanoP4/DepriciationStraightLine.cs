using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP4
{
    public abstract class DepreciationStraightLine
    {
        public string Title { get; set; }
        public decimal StartValue
        {
            get { return StartValue; }
            set { StartValue = value; Calc(); }
          
        }
        public decimal EndValue
        {
            get { return EndValue; }
            set { EndValue = value; Calc(); }
        }
        public int LifeTime
        {
            get { return LifeTime; }
            set { LifeTime = value; Calc(); }
        }

        public DateTime DateInInventory { get; set; }
        public DateTime DateOutOfInventory { get; set; }

        public override string ToString()
        {
            return Title + ": Starting value of:  " + StartValue + ". Ending vaalue of:  " + EndValue;
        }

        public virtual void Calc()
        {
            decimal annualDepreciation = (StartValue - EndValue) * (1 / LifeTime);
        }
       
              
    


    }





}
