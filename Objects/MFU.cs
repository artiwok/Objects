using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Objects
{
    class MFU
    {
        public void Scan()
        {
            Console.WriteLine("Enter some text:\n");

            string text = Console.ReadLine();

            var file = new StreamWriter(@"E:\scanner.txt");

            file.Write(text);

            file.Close();

            Console.WriteLine("\n");

            Console.ReadKey();
        }

        public void Print()
        {
            Console.WriteLine("The file contains the following text:");

            Console.WriteLine("\n");

            var fileContent = new StreamReader(@"E:\scanner.txt");

            Console.WriteLine(fileContent.ReadToEnd()); 

            Console.ReadKey();
        }

    }
}
