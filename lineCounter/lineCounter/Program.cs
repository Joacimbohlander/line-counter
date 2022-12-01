using System.IO;
using System;
using System.Collections.Generic;

namespace lineCounter
{
    class Program
    {
        List<int> ints;
        static void Main(string[] args)
        {
            List<int> linesArr = new List<int>();

            // This opens the file at path and counts the line
            var lineCount = 0;
            string line;
            path = @"";
            using StreamReader sr = new StreamReader(path);

            while  (sr.ReadLine() != null) 
            {
                for (int i = 0; i < linesArr.Count; i++)
                {
                    int line = linesArr[i];
                }


                lineCount++;
            }
            // sum = lineCount(lineCount+1)/2

        }
    }
}
