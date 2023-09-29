using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static double a;
        static double b;
        static char d;
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте! Вы пользуетесь калькулятором.");
            Console.WriteLine("Доступные операции: + - * / ^");
            Console.WriteLine("Помните: я - студент. Если Вы вмсето цифры введёте букву - это не моя проблема. Код умрёт(((");
            Console.WriteLine("Введите I число:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите нужное действие:");
            d = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Введите II число:");
            b = Convert.ToDouble(Console.ReadLine());
            if (d == '+')
            {
                summa();
            }
            else if (d == '-')
            {
                raznost();
            }
            else if (d == '*')
            {
                umnojit();
            }
            else if (d == '/')
            {
                delenie();
            }
            else if (d == '^')
            {
                stepen();
            }
            Console.ReadKey();
        }

        static void summa()
        {
            Console.WriteLine("Выбранное действие - сумма");
            Console.WriteLine("Результат:" +  (a + b));
        }
        static void raznost()
        {
            Console.WriteLine("Выбранное действие - разность");
            Console.WriteLine("Результат:" + (a - b));
        }
        static void umnojit()
        {
            Console.WriteLine("Выбранное действие - умножение");
            Console.WriteLine("Результат:" + (a * b));
        }
        static void delenie()
        {
            if (b == 0)
            {
                Console.WriteLine("Зачем вам делить на 0?");
            }
            else
            {
                Console.WriteLine("Выбранное действие - деление");
                Console.WriteLine("Результат:" + (a / b));
            }
        }
        static void stepen()
        {
            Console.WriteLine("Выбранное действие - степень");
            Console.WriteLine("Результат:" + Math.Pow(a,b));
        }
    }
}
        
