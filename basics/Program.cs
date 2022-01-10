using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(Subprogram.Multiplication(4, 5));


            float rand = Cycle.ArraySize(1, 50);
            float rand2 = Cycle.ArraySize(1, 50);
            Console.WriteLine(Subprogram.Average(rand, rand2));

            Console.WriteLine("Введите первый символ:");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите знак действия:");
            char oper = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй символ:");
            float b = float.Parse(Console.ReadLine());

            Subprogram.CalcMur(a, b, oper);
            Console.WriteLine();

            Console.WriteLine("This is Google Chrome!!1");
            Console.WriteLine("Как тебя зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Привет, " + name.ToUpper());
            if (name.ToLower() == "juku")
            {
                Console.WriteLine("Пойдём в кино, {0}? Сколько тебе лет?", name);
                int age = int.Parse(Console.ReadLine());
                double price = 6.50;
                string ticket;
                if (age < 0 || age > 120)
                {
                    Console.WriteLine("Ошибка!");
                }
                else
                {
                    if (age <= 6)
                    {
                        ticket = ("Большая скидка!");
                        price *= 0.5;
                    }
                    else
                    {
                        ticket = ("Обычный билет");
                    }
                    Console.WriteLine("{0}\nСтоимость билета: {1}", ticket, price);
                }
            }
            else
            {
                Console.WriteLine("Я занят.");
            }


            Console.ReadLine();
            /*int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Произведение чисел {1} и {0} равно {2}", number1, number2, number1 * number2);*/
        }
    }
}
