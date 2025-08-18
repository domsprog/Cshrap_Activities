using ArrayandStringLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;

namespace ArrayandStringLibrary.Methods
{
    public class ArrayManipulation : IArray
    {
        private int[] _array;

        public ArrayManipulation (int[] array)
        {
            _array = array ?? throw new ArgumentNullException(nameof(array));
        }

        public void Output()
        {
            Console.WriteLine("The original array:");
            PrintArray(_array);

            var reversedArray = ReverseArray(_array);
            Console.WriteLine("\nReversed Array:");
            PrintArray(reversedArray);
        }

        public void SearchArray(int? target, bool? findLargestValue)
        {
            if (findLargestValue ?? false)
            {
                Console.WriteLine($"\nThe largest value in the array is: {_array.Max()}");
            }
        }
        public void SetArray(int[] array)
        {
            _array = array;
        }

        private int[] ReverseArray(int[] array)
        {
            int[] tempArray = new int[array.Length];
            int counter = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                tempArray[counter] = array[i];
                counter++;
            }

            return tempArray;
        }
        public void LinearSearch(int target, bool shouldPrint)
        {
            _array = _array ?? throw new ArgumentNullException(nameof(_array));

            if (shouldPrint)
            {
                Console.WriteLine("\nPerforming Linear Search on the array:");
                Console.WriteLine(string.Join(" ", _array));
            }

            int index = SearchArray(target);

            if (index != -1)
            {
                Console.WriteLine($"\nTarget {target} found at index {index}.");
            }
            else
            {
                Console.WriteLine($"\nTarget {target} not found in the array.");
            }
        }

        public int SearchArray(int target)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == target)
                {
                    return i; // Found → return index
                }
            }
            return -1; // Not found
        }

        private void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }

        internal static void Reverse(char[] chars)
        {
            throw new NotImplementedException();
        }
    }
}
