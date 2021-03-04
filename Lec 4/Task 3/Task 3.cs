Program.CS
-------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            TestArry obj = new TestArry();
            obj.MyArray();

            Console.ReadLine();
        }
    }
}


TestArray.CS
---------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class TestArry
    {
        public void MyArray()
        {
            int[] Numbers = new int[10];

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Enter the Number " + (x + 1));
                Numbers[x] = int.Parse(Console.ReadLine());
            }
            for (int y = 0; y < 10; y++)
            {
                Console.WriteLine(Numbers[y]);
            }
            Console.ReadLine();
        }


    }
}
