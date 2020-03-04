using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] arr = new int[] { -4, 3, -9, 0, 4, 1 };
            plusMinus(arr);
        }
        static void plusMinus(int[] arr)
        {
            int first = 0;
            int second = 0;
            int third = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                    third += 1;
                else if (arr[i] < 0)
                    first += 1;
                else if (arr[i] > 0)
                    second += 1;

            }            
            decimal secondT = Decimal.Divide(second, arr.Length);
            decimal firstT = Decimal.Divide(first, arr.Length);
            decimal thirdT = Decimal.Divide(third, arr.Length);


            Console.WriteLine(firstT.ToString("##0.000000"));
            Console.WriteLine(secondT.ToString("##0.000000"));
            Console.WriteLine(thirdT.ToString("##0.000000"));
        }
    }
}
