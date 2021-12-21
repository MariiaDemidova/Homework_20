using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_20
{
    class Program
    {
        delegate double Calculate(double r);
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус");
            double r = Convert.ToDouble(Console.ReadLine());
            Calculate del = Dlina;
            double D = del(r);
            Console.WriteLine($"Длина окружности ={D:F2}") ;
            del = Square;
            double S = del(r);
            Console.WriteLine($"Площадь круга ={S:F2}");
            del = Volume;
            double V = del(r);
            Console.WriteLine($"Объем шара ={V:F2}");
            Console.ReadKey();
        }
        static double Dlina(double r)
        {
            return 2 * Math.PI * r;
        }
        static double Square(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
        static double Volume(double r)
        {
            return 4 / 3 * Math.PI * Math.Pow(r, 3);
        }
    }
}
