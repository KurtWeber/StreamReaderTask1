using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;    

namespace StreamReaderTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of StreamReader to read from a file
            StreamReader reader = new StreamReader("..\\..\\..\\Shakespeare.txt");

            // Read first line from the text file
            string line = reader.ReadLine();

            Console.WriteLine(line);

            // Close the resource after you've finished using it
            reader.Close();            
        }
    }
}
