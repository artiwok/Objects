using System;
using System.Collections.Generic;
using System.Text;

namespace Objects
{
    class ArrayTasks
    {
       public void InitArray()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nThe array values are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine("\n");
        }

       public void PrintArrayReverse()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nThe array values are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine("\n");

            Console.Write("The reverse array is: ");

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.WriteLine("\n");
        }

       public void FindArrayEvenSum()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            // Console output of even elements' values of the array and of their sum

            int sumEven = 0;

            Console.Write("Even elements' values of the array are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumEven += arr[i];
                    Console.Write($"{arr[i]} ");
                }
            }

            Console.WriteLine($"\n\nThe sum of even elements' values of the array is: {sumEven}\n");
        }

       public void FindArrayOddSum()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            // Console output of odd elements' values of the array and of their sum

            int sumOdd = 0;

            Console.Write("Odd elements' values of the array are: ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sumOdd += arr[i];
                    Console.Write($"{arr[i]} ");
                }
            }

            Console.WriteLine($"\n\nThe sum of odd elements' values of the array is: {sumOdd}\n");
        }

       public void FindArrayMinValue()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            // The minimum value of the array

            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            Console.WriteLine($"The minimum value of the array is: {min}\n");
        }

       public void FindArrayMaxValue()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n");

            // The maximum value of the array

            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.WriteLine($"The maximum value of the array is: {max}\n");
        }

       public void FindIndexOfArrayElement()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // Console output of the array element's index 

            Console.Write("Choose one of the above entered array elements' values: ");

            int value = int.Parse(Console.ReadLine());

            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    Console.WriteLine($"The index of the array element is: {i}\n");
                    break;
                }
            }
        }

       public void AddArrayElement()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // Addition of an element to array

            int[] arrTwo = new int[num + 1];

            Console.Write("Enter additional array element's value: ");

            int element = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                arrTwo[i] = arr[i];
            }

            Console.WriteLine("\nThe updated array elements' values are: ");

            for (int i = 0; i < arrTwo.Length; i++)
            {
                arrTwo[arrTwo.Length - 1] = element;

                Console.WriteLine($"{arrTwo[i]} ");
            }

            Console.WriteLine();
        }

       public void FindIndexOfSortedArrayElement()
        {
            // Array initialization and value assignment from console

            Console.Write("Enter the array size: ");

            int num = int.Parse(Console.ReadLine());

            int[] arr = new int[num];

            Console.WriteLine("\nInput array elements' values: ");

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            // Array sort

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            // Retrieving the necessary element's index of the sorted array

            Console.Write("Choose the element's value: ");

            int value = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("The index of the chosen element's value in the sorted array is: ");

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == value)
                {
                    Console.Write(i);
                    break;
                }
            }

            Console.WriteLine("\n");
        }
    }
}
