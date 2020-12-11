using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Objects
{
    class Scanner
    {
        public void Scan() 
        {
            Console.Write("Enter some text: ");

            string str = Console.ReadLine();

            StreamWriter streamWriter = new StreamWriter(@"E:\scanner_file.txt");

            streamWriter.WriteLine(str);

            streamWriter.Close();

            Console.ReadKey();
        }
    }
}
