using System;
using System.Threading.Tasks;
using System.Windows;
using System.IO;


class program
{
    static void Main(string[] args)
    {

        // This opens the file at path and counts the line
        var lineCount =0;
        path = @"";
        using (StreamReader sr = new StreamReader(path))
        {
            while (sr.ReadLine() != null)
            {
                lineCount++;
            }
        }
        // sum = lineCount(lineCount+1)/2
        
    }
}
