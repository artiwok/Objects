using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //// 1. Move some methods to a class and try to call them:

            //ArrayTasks arrayTasks = new ArrayTasks();

            //arrayTasks.FindIndexOfSortedArrayElement();
            //arrayTasks.FindArrayMaxValue();
            //arrayTasks.InitArray();
            //arrayTasks.PrintArrayReverse();

            //PrimeNumber primeNumber = new PrimeNumber();

            //primeNumber.SetPrimeNumberRange(0);
            //primeNumber.PrintPrimeNumberRange();



            //// 2. Create a Printer class with Print method that outputs a string argument to console:

            //Printer printer = new Printer();

            //printer.Print("Hello");



            //// 3. Create a Scanner class with Scan method that reads some text from console 
            //// and makes a new txt file on a computer disk:
            //Scanner scanner = new Scanner();

            //scanner.Scan();



            // 4. Create a MFU class and combine Scanner class and Print class:

            MFU multifunction = new MFU();

            multifunction.Scan();
            multifunction.Print();

        }
    }
}
