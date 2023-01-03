using System.IO;
using System;
using System.Collections.Generic;

namespace lineCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter file location:");
            string path = Console.ReadLine();

            using var reader = new StreamReader(path);
            double total = 0;
            int count = 0;

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine(); 
                
                try
                {
                    // If line is int
                    double number = double.Parse(line);
                    total += number;
                    count++;
                }
                catch (FormatException)
                {
                    // If line isn't int.
                }
               
            }
            double average = total / count;

            Console.WriteLine("The average of all the numbers in this file is :" + average);
        }
    }
}
