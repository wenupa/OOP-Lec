using System;
using System.Collections.Generic;
using System.Text;

namespace question_2
{
    class FindValues
    {
        public double findArea(double r)
        {
            double area = 3.14 * r * r;
            Console.WriteLine("Area : " + area);
            return area;
        }

        public double findCircumference(double r)
        {
            double circumference = 2 * 3.14 * r;
            Console.WriteLine("Circumference : " + circumference);
            return circumference;
        }
        
    }
}
