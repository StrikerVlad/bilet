using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int spaceValue = 0;
            ConsoleKeyInfo Symbol;
            Console.WriteLine("Программа подсчета веденных пробелов");
            do
            {
                Console.WriteLine("Введите символ");
                Console.WriteLine("Для окончания ввода нажмите точку ");
                Symbol = Console.ReadKey();
                Console.WriteLine();
                Console.Clear();
               

                Console.WriteLine(Symbol.Key);
                if (Symbol.KeyChar == ' ')
                {
                    Console.WriteLine("Пробел");
                    spaceValue++;
                }
                if (Symbol.KeyChar == '.')
                {
                    break;
                }
            } while (true);
            Console.WriteLine("Количество введенных пробелов = " + spaceValue);


            Console.WriteLine("Введите 6 значный билет");
            try
            {
                string ticket = Console.ReadLine();
                if (ticket.Length < 0 && ticket.Length > 6)
                {
                    throw new IndexOutOfRangeException();
                }
                int Iticket = Convert.ToInt32(ticket);
                Console.WriteLine((Convert.ToInt32(Convert.ToString(ticket)[0].ToString()) +
                                   Convert.ToInt32(Convert.ToString(ticket)[1].ToString()) +
                                   Convert.ToInt32(Convert.ToString(ticket)[2].ToString())) ==
                                  (Convert.ToInt32(Convert.ToString(ticket)[3].ToString()) +
                                   Convert.ToInt32(Convert.ToString(ticket)[4].ToString()) +
                                   Convert.ToInt32(Convert.ToString(ticket)[5].ToString()))
                    ? "Билет счастливый"
                    : "Билет не является счастливым");
            }
            catch (Exception)
            {
                Console.WriteLine("Вы ввели не шесть символов");
            }

            Console.WriteLine("Необходимо ввести А и В, причем А<B");
            try
            {
                Console.WriteLine("Введите А");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите B");
                int B = Convert.ToInt32(Console.ReadLine());
                if (A >= B || A <= 0 || B <= 0)
                {
                    Console.WriteLine("Не соблюдено условие А<B либо числа A и B не положительные");
                    return;
                }
                Console.Clear();
                for (int i = A; i <= B; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Завершение программы");
            }

            Console.WriteLine("Введите расстояние в сантиметрах");
            double santi = Convert.ToDouble(Console.ReadLine());
            double metr = santi / 100;
            Console.WriteLine("В {0} сантиметров {1} метров", santi, metr);



        }
    }
}
