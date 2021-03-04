using System;
using System.Collections.Generic;
using System.Text;

namespace practical_02
{
    class ConvertValues
    {
        public void kilometerTOmeter()
        {
            Console.WriteLine("Enter distence in Kilo Meters : ");
            int distence = int.Parse(Console.ReadLine());

            int InMeters = distence * 1000;
            Console.WriteLine(distence + "=>" + InMeters);
        }
    }
}
