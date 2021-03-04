using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
                double[] Marks = new double[10];

                for (int x = 0; x < 10; x++)
                {
                    Console.WriteLine("Enter Number" + (x + 1));
                    Marks[x] = double.Parse(Console.ReadLine());
                }

                for (int y = 0; y < 10; y++)
                {
                    Console.WriteLine(Marks[y]);
                }
                Console.ReadLine();
            }
        }
    }
