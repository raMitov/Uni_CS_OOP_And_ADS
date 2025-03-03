static void ex3()
{
    
    Console.WriteLine("How Big will the square be?");
    int sizeOfSquare = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[sizeOfSquare, sizeOfSquare];
    Console.WriteLine("Fill in the square number by number.");
    for (int i = 0; i < sizeOfSquare; i++)
    {
        for (int j = 0; j < sizeOfSquare; j++)
        {
            while (true)
            {
                Console.WriteLine("Write a number between 1 and 20!");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num >= 1 && num <= 20)
                {
                    matrix[i, j] = num;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid number! Try again.");
                }
            }
        }
    }
    int diagonalSum1 = 0;
    int diagonalSum2 = 0;
    for (int i = 0; i < sizeOfSquare; i++)
    {
        diagonalSum1 += matrix[i, i];
        diagonalSum2 += matrix[i, sizeOfSquare - 1 - i];
    }

    bool isMagic = (diagonalSum1 == diagonalSum2);

    
    for (int i = 0; i < sizeOfSquare && isMagic; i++)
    {
        int rowSum = 0;
        int colSum = 0;
        for (int j = 0; j < sizeOfSquare; j++)
        {
            rowSum += matrix[i, j];
            colSum += matrix[j, i];
        }
        if (rowSum != diagonalSum1 || colSum != diagonalSum1)
        {
            isMagic = false;
        }
    }
    string result = isMagic ? "The square is Magic!" : "The square is not Magic!";
    Console.WriteLine(result);
    
    for (int i = 0; i < sizeOfSquare; i++)
    {
        for (int j = 0; j < sizeOfSquare; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

static int[] findMostRepeatedInArr(int[] array)
{
    int mostRepeated = 0;
    int mostRepeatedCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int current = array[i];
        int currentCount = 0;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] == current)
            {
                currentCount++;
            }
        }

        if (mostRepeatedCount < currentCount)
        {
            mostRepeatedCount = currentCount;
            mostRepeated = current;
        }
    }
    int[] nums = { mostRepeated, mostRepeatedCount };
    return nums;
}

static void ex2()
{
    int numbers = Convert.ToInt32(Console.ReadLine());
    int[] numArr = new int[numbers];
    for (int i = 0; i < numbers; i++)
    {
        numbers = Convert.ToInt32(Console.ReadLine());
        if (numArr[i] < 10 || numArr[i] > 99)
        {
            Console.WriteLine("Error, try again");
            i--;
        }
    }
    int[] num = findMostRepeatedInArr(numArr);
    Console.WriteLine($"The most repeated num is {num[0]} which appeared {num[1]} times");
}



static double getSumOfArrNums(int n, double[] numbers)
{
    double sum = 0;
    for (int i = 0; n > i; i++)
    {
        sum += numbers[i];
    }
    return sum;
}
static void ex1()
{
    int numbers = Convert.ToInt32(Console.ReadLine());
    double[] numbersArray = new double[numbers];
    for (int i = 0; i < numbers; i++)
    {
        numbersArray[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine(getSumOfArrNums(5, numbersArray));
}



namespace ASD_Homework_One
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}