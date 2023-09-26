using System;
using System.ComponentModel.Design;

 static void Main(string[] args){
double a;
double b;
char operation;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Введите первое число!");
Console.ResetColor();
a = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Введите второе число!");
Console.ResetColor();
b = Convert.ToDouble(Console.ReadLine());
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Введите знак операции, которую хотите произвести с числами!");
Console.ResetColor();
operation = Convert.ToChar(Console.ReadLine());
if (operation == '+')
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Сумма чисел " + a + " и " + b + " равна " + (a + b));
    Console.ResetColor();
}
else if (operation == '-')
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Разность чисел " + a + " и " + b + " равна " + (a - b));
    Console.ResetColor();
}
else if (operation == '*')
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Произведение чисел " + a + " и " + b + " равно " + (a * b));
    Console.ResetColor();
}
else if (b == 0 & operation == '/')
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Ошибка, деление на ноль невозможно!");
    Console.ResetColor();
}
else if (operation == '/')
{
    Console.ForegroundColor = ConsoleColor.Black;
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Частное чисел " + a + " и " + b + " равно " + (a / b));
    Console.ResetColor();
}
else
{
    Console.WriteLine("Неизвестный знак операции!");
}
Console.ReadKey();
 }
