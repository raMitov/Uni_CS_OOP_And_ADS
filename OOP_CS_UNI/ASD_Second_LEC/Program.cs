using System;
using System.Collections.Generic;

namespace ASD_Second_LEC
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 3, 1, 8, 4, 7, 5 };
            int number = 14;
            factoriel(number);
            Console.WriteLine(fibonacci(number));
            Console.WriteLine(Convert10ToBase(16,1516));
            

        }

        static int factoriel(int n) //Recursion on factoriel
        {
            if (n == 0)
            {
                return 1;
            }
            return n * factoriel(n - 1);
        }

        static int fibonacci(int n) //Recursion on Fibonacci
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        static int[] QuickSort(int[] arr, int left, int right) //recursion quicksort check form home!!! doesnt work
        {
            int i;
            if (left < right)
            {
                i = Partition(arr, left, right);
            }
            QuickSort(arr, left, right - 1);
            QuickSort(arr, left + 1, right);
            return arr;

        }

        static int Partition(int[] arr, int left, int right)
        {
            int temp;
            int p = arr[right];
            int i = left - 1;

            for (int j = left; j <= right; j++)
            {
                if (arr[j] <= p)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[i + 1];
            arr[i + 1] = arr[right];
            arr[right] = temp;
            return i + 1;
        }
        //Mergesort at home!!
        static string ToBinary(int n)
        {
            string binary = "";
            while (n != 0)
            {
                binary += n % 2;
                n = n / 2;
            }
            char[] arr = binary.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        static string Convert10ToBase(int baseNumber, int n)
        {
            string binary = "";
            while (n != 0)
            {
                int rem = n % baseNumber;
                if (rem >= 10)
                {
                    binary += (char)('A' + (rem-10));
                }
                else
                {
                    binary += n % baseNumber;
                }
                n = n / baseNumber;
            }
            char[] arr = binary.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        

    }
}