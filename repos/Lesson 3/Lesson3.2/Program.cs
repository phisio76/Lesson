using System; // С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.

namespace Lesson_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0;
            Console.WriteLine("Вводите различные числа и нажимайте enter:");
            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                    sum += num;

            } while (num != 0);

            Console.WriteLine($"Сумма нечётных чисел равна {sum}");
        }
    }
}

