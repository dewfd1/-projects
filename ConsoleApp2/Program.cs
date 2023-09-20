using System;

class Calculator
{
    static void Main()
    {
        int choice;
        double num1, num2;
        double result;
        bool exit = false;

        Console.WriteLine("Выберите номер операции:");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");
        Console.WriteLine("5. Возвести число в степень N");
        Console.WriteLine("6. Найти квадратный корень из числа");
        Console.WriteLine("7. Найти 1 процент от числа");
        Console.WriteLine("8. Найти факториал числа");
        Console.WriteLine("9. Выйти из программы");

        while (!exit)
        {
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine($"Результат сложения: {result}");
                    Console.WriteLine("Введите номер операции еще раз");
                    break;
                case 2:
                    Console.WriteLine("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine($"Результат вычитания: {result}");
                    Console.WriteLine("Введите номер операции еще раз");
                    break;
                case 3:
                    Console.WriteLine("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine($"Результат умножения: {result}");
                    Console.WriteLine("Введите номер операции еще раз");
                    break;
                case 4:
                    Console.WriteLine("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 / num2;
                    Console.WriteLine($"Результат деления: {result}");
                    Console.WriteLine("Введите номер операции еще раз");
                    break;
                case 5:
                    Console.WriteLine("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите степень числа: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = Math.Pow(num1, num2);
                    Console.WriteLine($"Результат возведения в степень: {result}");
                    Console.WriteLine("Введите номер операции еще раз");
                    break;
                case 6:
                    Console.WriteLine("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = Math.Sqrt(num1);
                    Console.WriteLine($"Результат извлечения корня: {result}");
                    Console.WriteLine("Введите номер операции еще раз");
                    break;
                case 7:
                    Console.WriteLine("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = (num1 / 100) * 1;
                    Console.WriteLine($"Результат нахождения процента: {result}");
                    Console.WriteLine("Введите номер операции еще раз");
                    break;
                case 8:
                    result = 1;
                    Console.WriteLine("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    for (double i = (double)num1; i > 0; i--)
                    {
                        result *= i;
                    }
                    Console.WriteLine($"Результат нахождения факториала: {result}");
                    Console.WriteLine("Введите номер операции еще раз");
                    break;
                case 9:
                    exit = true;
                    Console.WriteLine("Выход из программы...");
                    break;
                default:
                    Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                    break;
            }

            Console.WriteLine();
        }
    }
}