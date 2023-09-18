using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Сложить 2 числа");
                Console.WriteLine("2. Вычесть первое из второго");
                Console.WriteLine("3. Перемножить два числа");
                Console.WriteLine("4. Разделить первое на второе");
                Console.WriteLine("5. Возвести в степень N первое число");
                Console.WriteLine("6. Найти квадратный корень из числа");
                Console.WriteLine("7. Найти 1 процент от числа");
                Console.WriteLine("8. Найти факториал числа");
                Console.WriteLine("9. Выйти из программы");

                int a = int.Parse(Console.ReadLine()); //Parse я использую для того чтобы не писать 2 строчки когда текст перевожу в числовое значение,потому что пальцы устали

                switch (a)
                {
                    case 1:
                        Console.Write("Введите первое число: ");
                        double sum1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double sum2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат сложения: {sum1 + sum2}");
                        break;
                    case 2:
                        Console.Write("Введите первое число: ");
                        double sub1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double sub2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат вычитания: {sub2 - sub1}");
                        break;
                    case 3:
                        Console.Write("Введите первое число: ");
                        double mul1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double mul2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат умножения: {mul1 * mul2}");
                        break;
                    case 4:
                        Console.Write("Введите первое число: ");
                        double div1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите второе число: ");
                        double div2 = double.Parse(Console.ReadLine());
                        if (div2 != 0)
                        {
                            Console.WriteLine($"Результат деления: {div1 / div2}");
                        }
                        else
                        {
                            Console.WriteLine("На 0 делить нельзя, вернитесь в младшую школу!!!!");
                        }
                        break;
                    case 5:
                        Console.Write("Введите число: ");
                        double num1 = double.Parse(Console.ReadLine());
                        Console.Write("Введите степень: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Результат возведения в степень: {Math.Pow(num1, b)}");//метод Math.Pow возводит в степень
                        break;
                    case 6:
                        Console.Write("Введите число: ");
                        double sqrt = double.Parse(Console.ReadLine());
                        if (sqrt >= 0)
                        {
                            Console.WriteLine($"Результат извлечения квадратного корня: {Math.Sqrt(sqrt)}");//math.sqrt соответственно ищет корень, прям с питона скатали
                        }
                        else
                        {
                            Console.WriteLine("Такое вселенная предусмотрела только в комплексных числах, ради Аллаха выберите другой вариант");
                        }
                        break;
                    case 7:
                        Console.Write("Введите число: ");
                        double с = double.Parse(Console.ReadLine());
                        Console.WriteLine($"1 процент от числа: {с / 100}");//он меркантильный, без знака доллара не считает
                        break;
                    case 8:
                        Console.Write("Введите число: ");
                        int n = int.Parse(Console.ReadLine());
                        int d = 1;
                        for (int i = 2; i <= n; i++)//это я у вас в третьей лекции  нашла)))
                        {
                            d *= i;// умножить и выполнить присвоение
                        }
                        Console.WriteLine($"Факториал числа: {d}");
                        break;
                    case 9:
                        Console.WriteLine("Программа завершена");
                        return;//return завершает выполнение функции
                    default:
                        Console.WriteLine("Выберите число из списка");//это чтобы вы не сломали её выбрав другое число
                        break;
                }
            }
        }
    }
}