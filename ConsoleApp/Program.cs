using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter the desired array type and array elements:

            string[] array = new string[5] {"one", "two", "three", "four", "five"};

            //Enter the desired element type and array element to put from the end (method Push):

            string pushElement = "twenty";

            //Enter the desired element type and array element to put from the beginning (method Unshift):

            string UnShiftElement = "null";

            
            Console.WriteLine();
            var loop = true;
            while (loop)
            {
                Console.WriteLine("Array: ");
                Console.WriteLine("\n");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write($"{array[i]}  |  ");
                }
                Console.WriteLine("\n");
                Console.WriteLine($"Push element = {pushElement}");
                Console.WriteLine("\n");
                Console.WriteLine($"UnShift element = {UnShiftElement}");
                Console.WriteLine("\n");
                Console.Write("Select the desired method:\n" +
                    "\n1. Pop - deletes the last array element and returns it;" +
                    "\n2. Push - adds an array element from the end and returns the updated array size;" +
                    "\n3. Shift - deletes the first array element and returns it;" +
                    "\n4. Unshift - adds an array element from the beginning and returns the updated array size;" +
                    "\n5. Slice - returns a new array that contains a part of the previous array;" +
                    "\n6. Slice without begin index;" +
                    "\nChoice: ");
                int.TryParse(Console.ReadLine(), out var choice);
                Console.WriteLine();
                switch (choice)    
                {
                    case 1:
                        var lastElement = ArrayHelper.Pop(ref array);
                        Console.WriteLine($"Deleted last element = {lastElement}");
                        break;

                    case 2:
                        var pushArraySize = ArrayHelper.Push(ref array, pushElement);
                        Console.WriteLine($"New array size = {pushArraySize}");
                        break;

                    case 3:
                        var firstElement = ArrayHelper.Shift(ref array);                      
                        Console.WriteLine($"Deleted first element = {firstElement}");
                        break;

                    case 4:
                        var UnShiftArraySize = ArrayHelper.UnShift(ref array, UnShiftElement);
                        Console.WriteLine($"New array size = {UnShiftArraySize}");
                        break;

                    case 5:
                        Console.WriteLine("Enter a begin index: ");
                        var beginIndex = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter an end index: ");
                        var endIndex = int.Parse(Console.ReadLine());
                        var sliceArray = ArrayHelper.Slice(array, beginIndex, endIndex);
                        Console.WriteLine();
                        for (int i = 0; i < sliceArray.Length; i++)
                        {
                            Console.WriteLine(sliceArray[i]);
                        }
                        break;

                    case 6:
                        Console.WriteLine("Enter an end index: ");
                        var endIndex2 = int.Parse(Console.ReadLine());
                        var sliceArray2 = ArrayHelper.Slice(array, endIndex2);
                        Console.WriteLine();
                        for (int i = 0; i < sliceArray2.Length; i++)
                        {
                            Console.WriteLine(sliceArray2[i]);
                        }
                        break;

                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadLine();
                Console.Clear();
            }
           
        }
    }
}
