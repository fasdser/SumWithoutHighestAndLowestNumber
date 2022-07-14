using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWithoutHighestAndLowestNumber
{
    internal class Program
    {

        /*  Sum all the numbers of a given array(cq.list ), except the highest and the lowest element(by value, not by index!).

            The highest or lowest element respectively is a single element at each edge, even if there are more than one with the same value.

            Mind the input validation.

       Example
               { 6, 2, 1, 8, 10 }  => 16
               { 1, 1, 11, 2, 3 } => 6
            Input validation
            If an empty value( null, None, Nothing etc. ) is given instead of an array, or the given array is an empty list or a list with only 1 element, return 0.*/

        /* Суммируем все числа заданного массива (cq.list), кроме самого высокого и самого низкого элемента (по значению, а не по индексу!).

            Самый высокий или самый низкий элемент соответственно — это один элемент на каждом ребре, даже если их несколько с одинаковым значением.

            Помните о проверке ввода.

       Пример
               {6, 2, 1, 8, 10} => 16
               {1, 1, 11, 2, 3} => 6
            Проверка ввода
            Если вместо массива задано пустое значение (null, None, Nothing и т. д.), или данный массив является пустым списком или списком только с 1 элементом, вернуть 0.*/

        static void Main(string[] args)
        {
            int[] array = { 6, 2, 1, 8, 10 };
            Sum(array);
            Console.WriteLine(Sum(array));
            Console.ReadKey();
        }

        public static int Sum(int[] numbers)
        {

            if (numbers == null || numbers.Length == 1)
            {
                return 0;   
            }

            int sum = 0;
            int max = numbers.Max();
            int min = numbers.Min();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == max || numbers[i] == min)
                {
                    sum += 0;
                }
                else sum += numbers[i];                
            }
           

            return sum;
        }

        public static int Sum1(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;

            foreach (var x in numbers)
            {
                if (x > max) max = x;
                if (x < min) min = x;
                sum += x;
            }

            return sum - min - max;
        }

        public static int Sum3(int[] numbers)
        {
            return numbers == null || numbers.Length < 2
                ? 0
                : numbers.Sum() - numbers.Max() - numbers.Min();
        }
    }
}
