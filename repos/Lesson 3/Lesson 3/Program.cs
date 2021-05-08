using System; // а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.

struct Complex
{
    public double im;
    public double re;
    //  в C# в структурах могут храниться также действия над данными
    public Complex Plus(Complex x)
    {
        Complex y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }
    //  Пример произведения двух комплексных чисел
    public Complex Multi(Complex x)
    {
        Complex y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }
    //  Дописать структуру Complex, добавив метод вычитания комплексных чисел.
    public Complex Minus(Complex x)
    {
        Complex y;
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }
    public string ToString()
    {
        return re + "+" + im + "i";
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число 1 (сложение), 2 (умножение) или 3 (вычитание): ");
        Complex complex1;
        complex1.re = 3;
        complex1.im = 3;

        Complex complex2;
        complex2.re = 2;
        complex2.im = 2;
        int caseSwitch = int.Parse(Console.ReadLine()); // в) Добавить диалог с использованием switch демонстрирующий работу класса.
        switch (caseSwitch)
        {
            case 1:
                Complex result = complex1.Plus(complex2);
                Console.WriteLine(result.ToString());
                goto case 4;
            case 2:
                result = complex1.Multi(complex2);
                Console.WriteLine(result.ToString());
                goto case 4;
            case 3:
                result = complex1.Minus(complex2);
                Console.WriteLine(result.ToString());
                goto case 4;
            case 4:
                Console.WriteLine("Демонстрация работы структуры:");  // Продемонстрировать работу структуры.
                Complex result1 = complex1.Plus(complex2);
                Console.WriteLine($"Результом операции сложения чисел: {complex1.ToString()}  и {complex2.ToString()}  является {result1.ToString()}");
                Complex result2 = complex1.Multi(complex2);
                Console.WriteLine($"Результом операции умножения чисел: {complex1.ToString()}  и {complex2.ToString()}  является {result2.ToString()}");
                Complex result3 = complex1.Minus(complex2);
                Console.WriteLine($"Результом операции вычитания чисел: {complex1.ToString()}  и {complex2.ToString()}  является {result3.ToString()}");

                break;
        }
    }
}
