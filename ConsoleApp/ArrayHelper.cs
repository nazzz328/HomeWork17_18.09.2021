using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class ArrayHelper
    {
        public static T Pop<T>(ref T[] array)
        {
            T lastElement = default(T);
            try
            {
                var lastElementEx = array[array.Length - 1];
                List<T> list = new List<T>(array);
                Array.Resize<T>(ref array, array.Length - 1);
                lastElement = lastElementEx;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return lastElement;



        }

        public static int Push<T>(ref T[] array, T elementFromTheEnd)
        {
            Array.Resize<T>(ref array, array.Length + 1);
            array[array.Length - 1] = elementFromTheEnd;
            return array.Length;

        }

        public static T Shift<T>(ref T[] array)
        {
            T firstElement = default(T);
            try
            {
                T firstElementEx = array[0];
                List<T> list = new List<T>(array);
                list.RemoveAt(0);
                array = list.ToArray();
                firstElement = firstElementEx;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            return firstElement;
        }

        public static int UnShift<T> (ref T[] array, T elementFromTheBeginning)
            {
            List<T> list = new List<T>(array);
            list.Reverse();
            list.Add(elementFromTheBeginning);
            list.Reverse();
            array = list.ToArray();
            return array.Length;
            }

        public static T[] Slice <T> (T[] array, int beginArray, int endArray)
        {
            T[] tempArray = new T[0];
            if (beginArray >= (array.Length)-1)
            {
                T[] newArray = new T[array.Length];
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = default(T);
                }
                tempArray = newArray;
            }

            if (endArray < 0 && beginArray < 0)
            {
                Console.WriteLine("At least one of the index must be >= 0");
                Console.ReadKey();
            }

            if (beginArray < (-1 * array.Length))
            {
                Console.WriteLine("Negative begin index must not be lower than (-)length of array");
                Console.ReadKey();
            }

            if (endArray > array.Length - 1)
            {
                Console.WriteLine("End index must not be greater than array length");
                Console.ReadKey();
            }
            if (beginArray < 0 && beginArray >= (-1 * array.Length) && endArray >= 0)
            {
                T[] newArray = new T[-1 * beginArray];
                Array.Copy(array, (array.Length + beginArray), newArray, 0, (-1 * beginArray));
                tempArray = newArray;
            }

            if (endArray < 0 && beginArray < array.Length - 1 && beginArray >=0)
            {
                T[] newArray = new T[array.Length + (endArray - beginArray)];
                Array.Copy(array, beginArray, newArray, 0, newArray.Length);
                tempArray = newArray;
            }


            if (beginArray < (array.Length -1) && beginArray >=0 && endArray <= (array.Length-1) && endArray >=0)
            {
                T[] newArray = new T[(endArray + 1) - beginArray];
                Array.Copy(array, beginArray, newArray, 0, newArray.Length);
                tempArray = newArray;
            }
            return tempArray;
        }

        public static T[] Slice<T>(T[] array, int endArray)
        {
            T[] newArray = new T[endArray + 1];
            Array.Copy(array, 0, newArray, 0, endArray + 1);
            return newArray;
        }

        public static void ShowArray<T> (ref T [] array)
        {
            Console.WriteLine("Elements of the array: \n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}  |  ");
            }
        }
    }
}
