//Лабораторная работа 1 
//вариант 16
//Подгорнова Александра Васильевна
//проверить соотношение: cos(2*x') = cos2(x')-sin2(x')

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;
namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xDegrees = 60; // градусы
            double xRadians = xDegrees * PI / 180; // переводим в радианы

            double leftSide = Cos(2 * xRadians);
            double rightSide = Pow(Cos(xRadians), 2) - Pow(Sin(xRadians), 2);

            if (Math.Abs(leftSide - rightSide) < 0.0001)
            {
                Console.WriteLine("Соотношение верно для x = {0} градусов", xDegrees);
            }
            else
            {
                Console.WriteLine("Соотношение НЕ верно для x = {0} градусов", xDegrees);
            }

            Console.ReadKey();
        
    
        }
    }
}
