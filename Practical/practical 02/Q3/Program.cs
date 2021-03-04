using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Choice");
            int symbol = int.Parse(Console.ReadLine());

            Console.Write("Enter Number 1: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Number 2: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Your Answer is : ");
            int ans = int.Parse(Console.ReadLine());

            CalculateValues obj = new CalculateValues();
           

            switch (symbol)
            {
                case 1:
                    obj.addition(num1, num2);
                    break;
                case 2:
                    obj.subtraction(num1, num2);
                    break;
                case 3:
                    obj.multiplication(num1, num2);
                    break;
                case 4:
                    obj.division(num1, num2);
                    break;
                default:
                    Console.WriteLine("!Enter valid values.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
