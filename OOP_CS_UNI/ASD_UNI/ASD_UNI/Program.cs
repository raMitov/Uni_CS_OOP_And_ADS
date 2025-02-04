using System;
using System.ComponentModel;

namespace ASD_UNI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool[] n = new bool[100];
            
            int[,] m = new int[100, 100];
            int[,] m2 = {{1,2,3,4,5,6,7,8,9,10}, {1,2,3,4,5,6,7,8,9,10}};
           
            findSmallerAndBigger(arr2);
            findSmaller(arr);
            AndBigger(arr);
            Console.WriteLine(findMid(arr));
            Console.WriteLine(findClosestToMiddle(arr));
            
            printMatrix(m2);
        }

        static void printaray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                
            }
        }

        static void findSmallerAndBigger(int[] arr)
        {
            int smallest = arr[0];
            int biggest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > biggest)
                {
                    biggest = arr[i];
                }
                else if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            Console.WriteLine(smallest);
            Console.WriteLine(biggest);
        }
        static void findSmaller(int[] arr)
        {
            int smallest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                }
            }
            Console.WriteLine(smallest);
        }
        static void AndBigger(int[] arr)
        {
            int biggest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > biggest)
                {
                    biggest = arr[i];
                }
               
            }
            Console.WriteLine(biggest);
        }

        public static int findMid(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum / arr.Length;
        }

        static int findClosestToMiddle(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double average = sum / arr.Length;
            double diff = sum;
            int find = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i] - average) < diff)
                {
                    diff = Math.Abs(arr[i] - average);
                    find = arr[i];
                }
            }

            return find;
        }

        static void Primes(bool[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    for (int j = i + i; j < arr.Length; j++)
                    {
                        arr[j] = false;
                    }
                }
               
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    Console.WriteLine(i);
                }
            }
            //za vkushti opravi go
        }

        static void printMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write((matrix[i, j] + " "));
                }
                Console.WriteLine();

            }
        }

        static void TransponateMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write((matrix[i, j] + " "));
                }
                Console.WriteLine();

            }
            //finish at home
        }

        static int BinarySearch(int[] arr, int key)
        {
            //find mid between beginning and ending of an array
            // google binary search
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                
                int middle = (left + right) / 2;
                if (arr[middle] == key)
                {
                    return middle;
                }
                else if (arr[middle] < key)
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;
                }


            }
            return -1;
        }

        static int[] bubbleSort(int[] arr)
        {
            //DO AT HOME SEARCH BUBBLE SORT
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                                    
                }
            }
            return arr;         
        }
        //insertion sort
        //selection sort
    }

    
    
}