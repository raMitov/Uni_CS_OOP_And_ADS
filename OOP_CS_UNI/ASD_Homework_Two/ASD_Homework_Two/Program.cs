using System;

namespace ASD_Homework_Two
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //For prime
            int num = 98;
            int biggerPrime = FindBiggerPrime(num);
            Console.WriteLine(biggerPrime);
            //For monotonous increase
            /*double[] arr = new double[10];
            for (int i = 0; i < 9; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
            }*/
            //For sum of digits
            int n = 1234;
            int nSum = sumOfDigits(n);
            Console.WriteLine(nSum);
        }

        static int FindBiggerPrime(int number)
        { 
            while (true)
            {
                    number += 1;
                    double tmp = Math.Sqrt(number);
                    tmp = Math.Floor(tmp);
                    bool prime = true;
                    for (int i = 2; i <= tmp; i++)
                    {
                        if (number % i == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                    if (prime)
                    {
                        return number;
                    }
            }
            return number;
        }

        static bool monotonousIncrease(double[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                return true;
            }

            if (arr[index] > arr[index + 1])
            {
                return false;
            }
            return monotonousIncrease(arr, index + 1);
        }

        static int sumOfDigits(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            int digit = num % 10;
            int sum = num / 10;
            return digit + sumOfDigits(sum);
        }
    }
}