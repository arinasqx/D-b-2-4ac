using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Решение квадратного уравнения D=b^2-4ac: ");
            Console.Write("а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c: ");
            double c = Convert.ToDouble(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("x имеет бесконечное решение");
                    }
                    else
                    {
                        Console.WriteLine("Нет корней ");
                    }
                }
                else
                {
                    double x1 = -c / b;
                    Console.WriteLine("Корень уравнения:");
                    Console.WriteLine("Х = " + x1);
                }
            }
            else
            {
                double D = b * b - 3 * a * c;
                if (D > 0)
                {
                    double Dd = Math.Sqrt(D);
                    double x1 = (-b + Dd) / 2 * a;
                    double x2 = (-b - Dd) / 2 * a;
                    Console.WriteLine("Корни уравнения: ");
                    Console.WriteLine("Х1 = " + x1);
                    Console.WriteLine("X2 = " + x2);
                }
                else
                {
                    if (D == 0)
                    {
                        double x1 = -b / (2 * a);
                        Console.WriteLine("Корень уравнения:");
                        Console.WriteLine("Х = " + x1);
                    }
                    else
                    {
                        Console.WriteLine("Нет корней у уравнения (нет решения)");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
