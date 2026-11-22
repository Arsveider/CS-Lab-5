using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        int z = 0;
        Console.WriteLine("Лабораторная работа #5 Бужлаков Арсений 6102-020302D");
        do
        {
            Console.WriteLine("Выберите желаемую программу: ");
            Console.WriteLine("1.Правильная дробь");
            Console.WriteLine("2.Выход из программы");
            Console.Write("Введите число (1,2): ");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    {
                        Console.WriteLine("Вы выбрали программу 'Правильная дробь'");
                        Console.Write("Введите целый числитель 1 дроби: ");
                        int numerator1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите целый знаменатель 1 дроби: ");
                        int denominator1 = Convert.ToInt32(Console.ReadLine());
                        Fraction fraction1 = new Fraction(numerator1, denominator1);
                        fraction1.FractionReduction();
                        FractionStatic fractionStatic1 = new FractionStatic(numerator1, denominator1);
                        fractionStatic1.FractionReduction();
                        Console.WriteLine("Ваша  1 дробь: ");
                        Console.WriteLine(fraction1.PrintFraction());
                        Console.Write("Введите целый числитель 2 дроби: ");
                        int numerator2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите целый знаменатель 2 дроби: ");
                        int denominator2 = Convert.ToInt32(Console.ReadLine());
                        Fraction fraction2 = new Fraction(numerator2, denominator2);
                        fraction2.FractionReduction();
                        FractionStatic fractionStatic2 = new FractionStatic(numerator2, denominator2);
                        fractionStatic2.FractionReduction();
                        Console.WriteLine("Ваша  2 дробь: ");
                        Console.WriteLine(fraction2.PrintFraction());
                        int y = 0;
                        while (y != 1)
                        {
                            Console.WriteLine("Выберите метод выполнения операции: ");
                            Console.WriteLine("1. Метод экземпляра");
                            Console.WriteLine("2. Статический метод");
                            Console.Write("Введите число (1,2): ");
                            int p = Convert.ToInt32(Console.ReadLine());
                            switch (p)
                            {
                                case 1:
                                    {
                                        int q = 0;
                                        while (q != 1)
                                        {
                                            Console.WriteLine("Введите нужное действие с дробями: ");
                                            Console.WriteLine("1. Сложение");
                                            Console.WriteLine("2. Вычитание");
                                            Console.WriteLine("3. Умножение");
                                            Console.WriteLine("4. Деление");
                                            Console.Write("Введите число (1,2,3,4): ");
                                            int op = Convert.ToInt32(Console.ReadLine());
                                            switch (op)
                                            {
                                                case 1:
                                                    {
                                                        fraction1.Sum(fraction2);
                                                        fraction1.FractionReduction();
                                                        Console.WriteLine("Результат сложения:");
                                                        Console.WriteLine(fraction1.PrintFraction());
                                                        q = 1;
                                                        y = 1;
                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                        fraction1.Diff(fraction2);
                                                        fraction1.FractionReduction();
                                                        Console.WriteLine("Результат вычитания:");
                                                        Console.WriteLine(fraction1.PrintFraction());
                                                        q = 1;
                                                        y = 1;
                                                        break;
                                                    }
                                                case 3:
                                                    {
                                                        fraction1.Prod(fraction2);
                                                        fraction1.FractionReduction();
                                                        Console.WriteLine("Результат умножения:");
                                                        Console.WriteLine(fraction1.PrintFraction());
                                                        q = 1;
                                                        y = 1;
                                                        break;
                                                    }
                                                case 4:
                                                    {
                                                        fraction1.Div(fraction2);
                                                        fraction1.FractionReduction();
                                                        Console.WriteLine("Результат деления: ");
                                                        Console.WriteLine(fraction1.PrintFraction());
                                                        q = 1;
                                                        y = 1;
                                                        break;
                                                    }
                                                default:
                                                    {
                                                        Console.WriteLine("Ошибка ввода");
                                                        break;
                                                    }
                                            }
                                        }
                                        break;
                                    }
                                case 2:
                                    {
                                        int q = 0;
                                        while (q != 1)
                                        {
                                            Console.WriteLine("Введите нужное действие с дробями: ");
                                            Console.WriteLine("1. Сложение");
                                            Console.WriteLine("2. Вычитание");
                                            Console.WriteLine("3. Умножение");
                                            Console.WriteLine("4. Деление");
                                            Console.Write("Введите число (1,2,3,4): ");
                                            int op = Convert.ToInt32(Console.ReadLine());
                                            switch (op)
                                            {
                                                case 1:
                                                    {
                                                        FractionStatic result = fractionStatic1 + fractionStatic2;
                                                        result.FractionReduction();
                                                        Console.WriteLine("Результат сложения:");
                                                        Console.WriteLine(result.PrintFraction());
                                                        q = 1;
                                                        y = 1;
                                                        break;
                                                    }
                                                case 2:
                                                    {
                                                        FractionStatic result = fractionStatic1 - fractionStatic2;
                                                        result.FractionReduction();
                                                        Console.WriteLine("Результат вычитания:");
                                                        Console.WriteLine(result.PrintFraction());
                                                        q = 1;
                                                        y = 1;
                                                        break;
                                                    }
                                                case 3:
                                                    {
                                                        FractionStatic result = fractionStatic1 * fractionStatic2;
                                                        result.FractionReduction();
                                                        Console.WriteLine("Результат умножения:");
                                                        Console.WriteLine(result.PrintFraction());
                                                        q = 1;
                                                        y = 1;
                                                        break;
                                                    }
                                                case 4:
                                                    {
                                                        FractionStatic result = fractionStatic1 / fractionStatic2;
                                                        result.FractionReduction();
                                                        Console.WriteLine("Результат деления: ");
                                                        Console.WriteLine(result.PrintFraction());
                                                        q = 1;
                                                        y = 1;
                                                        break;
                                                    }
                                                default:
                                                    {
                                                        Console.WriteLine("Ошибка ввода");
                                                        break;
                                                    }
                                            }
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Ошибка ввода");
                                        break;
                                    }
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Выполнен выход из программы");
                        z = z + 1;
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Ошибка ввода");
                        break;
                    }
            }
        } while (z != 1);
    }
}