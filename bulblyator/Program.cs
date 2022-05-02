using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bulblyator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    // Предупреждение для пользователя 
                    Console.Write("Введите любое первое число \n> ");
                    // Первая переменая
                    float firstVariable = Convert.ToSingle(Console.ReadLine());

                    // Предупреждение для пользователя
                    Console.Write("Введите любое второе число \n> ");
                    // Вторая переменная
                    float secondVariable = Convert.ToSingle(Console.ReadLine());

                    // Предупреждение для пользователя
                    Console.Write("Введите любой математический символ \n> ");
                    // Математический символ введенный пользователем
                    char userChar = Convert.ToChar(Console.ReadLine());

                    Console.WriteLine();

                    if (userChar == '+')
                    {
                        Console.WriteLine($"{firstVariable} + {secondVariable} = {firstVariable + secondVariable}");
                    }
                    else if (userChar == '-')
                    {
                        Console.WriteLine($"{firstVariable} - {secondVariable} = {firstVariable - secondVariable}");
                    }
                    else if (userChar == '*')
                    {
                        Console.WriteLine($"{firstVariable} * {secondVariable} = {firstVariable * secondVariable}");
                    }
                    else if (userChar == '/')
                    {
                        if (secondVariable == 0)
                            Console.WriteLine("ERROR \ncan't divide by zero");
                        else
                            Console.WriteLine($"{firstVariable} / {secondVariable} = {firstVariable / secondVariable}");
                    }
                    else
                    {
                        Console.WriteLine($"{userChar} не может быть использован");
                    }
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("ERROR");
                    Console.ReadLine();
                }
            }
            

        }
    }
}
