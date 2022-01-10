using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_basics
{
    class Subprogram
    {
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        public static float Average(float a, float b)
        {
            float aver = (a + b) / 2;
            return aver;
        }

        static char[] action = new char[4] { '+', '-', '*', '/' };
        public static void CalcMur(float a, float b, char oper)
        {
            //Проверка https://ru.stackoverflow.com/questions/557945/%D0%A3%D1%81%D1%82%D0%B0%D0%BD%D0%BE%D0%B2%D0%B8%D1%82%D1%8C-%D0%BF%D1%80%D0%B8%D1%81%D1%83%D1%82%D1%81%D1%82%D0%B2%D1%83%D0%B5%D1%82-%D0%BB%D0%B8-%D1%8D%D0%BB%D0%B5%D0%BC%D0%B5%D0%BD%D1%82-%D0%B2-%D0%BC%D0%B0%D1%81%D1%81%D0%B8%D0%B2%D0%B5-%D0%A1
            float total = a / b;
            if (action.Contains(oper))
            {
                if (oper == '+')
                {
                    total = a + b;
                }
                else if (oper == '-')
                {
                    total = a - b;
                }
                else if (oper == '*')
                {
                    total = a * b;
                }
                else if (oper == '/')
                {
                    total = a / b;
                }
                int tot = (int)total;
                for (int i = 0; i < total; i++)
                {
                    Console.Write("Murr ");
                }
            }
            else
            {
                Console.WriteLine("Неизвестный оператор.");
            }
        }
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int x = 5;
            Console.WriteLine("Введи число: ");
            int y = int.Parse(Console.ReadLine());
            int z = Multiplication(x, y);
            Console.WriteLine("{0}*{1}={2}", x, y, z);
            Console.WriteLine(Multiplication(x, y));
            Console.ReadLine();
        }
    }
}