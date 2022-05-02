using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SecondTryAlis
{
    internal class Program
    {
        static void Main()
        {
            /*  
              int num = 8;
              float bruh = 8.8f;
              string sas = "восемь";
              */
            //Console.WriteLine($"Павел писька {bruh * 10т}sm, Хуй Даши {num * 2}");

            //  Console.WriteLine("Мои {2} сиськи {0} cm, Сиськи Павла {1} cm", bruh * 2, num / 2, "ахуенные");

            /*
            Console.Write("Введите что нибудь числовое, пожажда... \n> ");
            float x = 10;
            float y = Convert.ToSingle(Console.ReadLine());

            Console.Clear();
            if (x < y)  // если
                Console.WriteLine($"Спасибо. а терь вот те ответ {x} < {y}");

            else if (x > y)     // иначе если
            {
                Console.WriteLine($"Ну чё. вот те ответ {x} > {y}");

            }
            else
                Console.WriteLine("Ну, это небыло задуманно...");

            Console.ReadLine();
            Console.Clear();
            */

            float x;

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Введите пожажда любое первое число \n>");
                    x = Convert.ToSingle(Console.ReadLine());
                    break;

                }
                catch (Exception)
                {
                    Console.WriteLine("ÒnÓ \n Чё, умный самый сука \n UwU \n  Вы ввели не число, введите число:");
                    Console.ReadLine();
                }
            }

            float y;

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("пасиба,\n Теперь\n Введите второе число \n>");
                    y = Convert.ToSingle(Console.ReadLine());
                    break ;
                }
                catch (Exception)
                {
                    Console.WriteLine("ÒnÓ \n Чё, умный самый сука \n UwU \n  Вы ввели не число, введите число:");
                    Console.ReadLine();
                }
            }
            
            if (x > y)
                Console.WriteLine($"OwO \n ответешко: \n {x} > {y}");

            else if (y > x)
                Console.WriteLine($"UwU \n отвечёнчик: \n {y} > {x}");
            
            else
            {
                int xPos = Console.CursorLeft;
                int yPos = Console.CursorTop;

                Console.WriteLine($"OnO \n Ну... ");

                Thread.Sleep(1500);

                Console.SetCursorPosition(xPos, yPos);

                Console.WriteLine("OvO \n");

                Console.WriteLine($"Так вот, вот: \n {x} = {y}");
            }
                

        }
    }
}
