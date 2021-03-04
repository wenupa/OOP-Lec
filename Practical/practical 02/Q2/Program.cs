using System;

namespace question_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius : ");
            double radius = double.Parse(Console.ReadLine());

            FindValues obj = new FindValues();
            obj.findArea(radius);
            obj.findCircumference(radius);


            Console.ReadKey();

        }
    }
}
