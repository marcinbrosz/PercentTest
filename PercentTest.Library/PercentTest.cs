using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentTest.Library
{
    public class PercentTest
    {
        public static int Evaporator(double content, double evap_per_day, double threshold)
        {
                
            double min = content * (threshold / 100);
            int CountDay = 0;
            while (content > min)
            {
                content -= content * (evap_per_day / 100);
                CountDay++;
            }
            return CountDay;
        }
    }
}
