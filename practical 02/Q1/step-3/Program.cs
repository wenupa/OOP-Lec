﻿using System;

namespace step_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distence in Kilo Meters : ");
            int distence = int.Parse(Console.ReadLine());

            ConvertValues obj = new ConvertValues();
            obj.kilometerTOmeter(distence);


            Console.ReadKey();
        }
    }
}

