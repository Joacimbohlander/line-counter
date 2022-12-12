using System.IO;
using System;
using System.Collections.Generic;

namespace lineCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("");
            double total = 0;
            int count = 0;

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();

                total += double.Parse(line);

                count++;
            }
            double average = total / count;

            Console.WriteLine("The average of all the numbers in this file is :" + average);
        }
    }
}
