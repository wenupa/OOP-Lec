Method - 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};
            Console.WriteLine(numbers[0]); 
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);
            Console.WriteLine(numbers[3]);
            Console.WriteLine(numbers[4]);
            Console.WriteLine(numbers[5]);
            Console.WriteLine(numbers[6]);
            Console.WriteLine(numbers[7]);
            Console.WriteLine(numbers[8]);
            Console.WriteLine(numbers[9]);
            
            Console.ReadLine(); 
        }
    }
}

----------------------------------------------------------------------------------------------------------------------------------------


Method - 2


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10};
            
            for(int x = 0; x<=10;x++)
            {
                Console.WriteLine(x);
            }
            
            Console.ReadLine(); 
        }
    }
}
