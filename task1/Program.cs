//принимает на вход число (А) и выдаёт сумму чисел от 1 до А

using System;
using System.Linq;

namespace SEMINAR4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            Console.WriteLine("введите число");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine(GetSumFast(num));
            Console.WriteLine(GetSum(num));

                int GetSum(int a)
                    {
                        sum = 0;
                        for (int i =1; i <= a; i++)
                        {
                            sum += i;
                        }
                        return sum;
                    }

                int GetSumFast(int a)
                    {

                        int sum1 =  a * (a + 1) / 2;
                        return sum1;
                    }
        }
    }
}