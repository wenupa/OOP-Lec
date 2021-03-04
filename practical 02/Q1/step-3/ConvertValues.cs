using System;
using System.Collections.Generic;
using System.Text;

namespace step_03
{
    class ConvertValues
    {
        public int kilometerTOmeter(int d)
        {
            int InMeters = d * 1000;
            Console.WriteLine(InMeters + "km =>" + d +"m");

            return InMeters;
        }
    }
}
