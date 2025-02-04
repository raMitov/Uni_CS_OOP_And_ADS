using System;

class Time
{
    private int hour;
    private int minute;
    private int second;
    
    public Time(int hour, int minute, int second)
    {
        this.hour = hour;
        this.minute = minute;
        this.second = second;
    }

    public void getTime()
    {
        Console.WriteLine($"{hour.ToString("D2")}:{minute:d2}:{second:d2}");
    }

   
}
namespace OOP_CS_UNI
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int year = 1800;
            Console.WriteLine(year);
            Console.WriteLine(getYear(year));
            int n = 13;
            getPrimeNums(n);
            Time t = new Time(12, 12, 9);
            t.getTime();
            Book book = new Book("ivo", "ivo", "222", "12.50");
            book.getInfo();
            
        }
        static bool getYear (int year)
        {
            if ((year % 4 == 0 && year % 100 != 0)  || year % 400 == 0)
            {

                return true;
            }
            return false;
        }

        static void getPrimeNums(int n)
        {
            bool[] arr = new bool[n + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    for (int j = i*i; j < arr.Length; j+=i)
                    {
                        arr[j] = false;
                    }
                }
            }
            for (int i = 2; i < arr.Length; i++)
            {
                if (arr[i] == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}