using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MontanoP4
{
    class DoubleDepreciation:DepreciationStraightLine
    {
        public override void Calc()
        {
            decimal doubleDeclineRate = 2 * (1 / LifeTime) * (StartValue);
        }

        public override string ToString()
        {
            return Title + ": Starting value of:  " + StartValue 
                + ". Ending vaalue of:  " + EndValue + ". This will depreciate at double declining rate.";
        }
    }
}
