﻿using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringInput1 = "";
            string stringInput2 = "";
            string stringInput3 = "";

            Console.WriteLine("Input first string: ");
            stringInput1 = Console.ReadLine().ToUpper();

            Console.WriteLine("Input second string: ");
            stringInput2 = Console.ReadLine().ToUpper();

            Console.WriteLine("Input third string: ");
            stringInput3 = Console.ReadLine().ToUpper();

            bool result1 = stringInput1.StartsWith(stringInput2);
            bool result2 = stringInput1.EndsWith(stringInput3);

            Console.WriteLine("String {0} starts from {1}: {2}", stringInput1, stringInput2, result1);
            Console.WriteLine("String {0} ends with {1}: {2}", stringInput1, stringInput3, result2);
            Console.ReadKey();
        }
    }
}
