using System;
using System.Collections.Generic;
using System.Text;

namespace Q1
{
    class UserInput
    {
        public void MyFunction()
        {
            string name;
            int age;
            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age : ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name + " welcome & " + age);
        }
    }
}
