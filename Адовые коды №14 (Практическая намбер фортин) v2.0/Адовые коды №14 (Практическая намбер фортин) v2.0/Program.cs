using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Бирюков Георгий, ИСП-23, 10.02.2022г.
//Описать процедуру RectPS(x1, y1, x2, y2, P, S), вычисляющую периметр P и площадь S прямоугольника со сторонами, параллельными осям координат, по координатам (x1, y1), (x2, y2) 
//Его противоположных вершин (x1, y1, x2, y2 — входные, P и S — выходные параметры вещественного типа).
//С помощью этой процедуры найти периметры и площади трех прямоугольников с данными противоположными вершинами.

namespace Адовые_коды__14__Практическая_намбер_фортин__v2._0
{
    class Program
    {
        static void RectPS(double x1, double x2, double y1, double y2)
        {
            double p, s;
            Console.WriteLine("Полученные значения P, S: ");
            p = (Math.Abs(x2 - x1) + Math.Abs(y2 - y1)) * 2; //Вычисление периметра
            s = Math.Abs(x2 - x1) * Math.Abs(y2 - y1); //Вычисление площади           
            Console.WriteLine(p);
            Console.WriteLine(s);
        }

        static void Main(string[] args)
        {
            double x1, x2, y1, y2; //Ввод значений
            Console.Write("Введите значение x1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение x2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            RectPS(x1, x2, y1, y2); //Обращение к функции
            Console.ReadKey(); //Пауза
        }

        




    }
}   
