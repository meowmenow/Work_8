using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Практическая работа №14. ИСП-23, Биркюов Георгий, 27.01.2022
//Описать функцию SumRange(A, B) целого типа, находящую сумму всех целых чисел от A до B включительно (A и B — целые). 
//Если A > B, то функция возвращает 0. С помощью этой функции найти суммы чисел от A до B и от B до C, если даны числа A, B, C. 

namespace Адовые_коды__14__Практическая_работа_намбер_фортин_
{
    class Program
    {
        static int SumRange(int A, int B) //Нахождение суммы A, B
        {
            int sum = 0;
            if (A > B) //Если А больше B, то ретарн 0
                return 0; //Возвращение нуля
            else
            {
                for (int i = A; i <= B; i++)
                    sum += i;
                return sum; //Возврат ответа
            }
        }
        static int SumRange(int A, int B, int C) //Нахождение суммы от A до B и от B до C
        {
            int sum = 0; //Сумма чисел

            if (A > B || B > C) //от A до B и от B до С 
                return 0; //Возвращение нуля
            else
            {
                for (int i = A; i <= B; i++)
                    sum += i;
                for (int i = B; i <= C; i++)
                    sum += i;
                return sum;
            }
        }
        static void Main(string[] args) //Главная программа
        {
           
            Console.Write("Введите значение A: ");
            int A = int.Parse(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int B = int.Parse(Console.ReadLine());
            Console.Write("Введите значение C: ");
            int C = int.Parse(Console.ReadLine());
            Console.WriteLine(SumRange(A, B)); //Вызов функции
            Console.WriteLine(SumRange(A, B, C)); //Вызов функции
            Console.ReadKey(); //
            Console.ReadKey(); //Пауза

        }
    }
}
