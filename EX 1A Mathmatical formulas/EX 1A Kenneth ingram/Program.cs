using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EX_1A_Kenneth_ingram
{
    class Program
    {
        static void Main(string[] args)
        {
            Part1();
            Part2();
            Part3();
            Part4();
        }
        private static void Part1()
        {
            Console.WriteLine("\nLets find the circumference,");
        beginning:
            Console.Write("Enter an integer for the radius: ");
            int radius = int.Parse(Console.ReadLine());
            if (radius >= 0)
            {
            }
            else
            {
                Console.WriteLine("please put in a positive integar");
                goto beginning;
            }
            double circumference = 2 * Math.PI * radius;
            Console.WriteLine($"The circumference is {circumference}");

            Console.WriteLine("\nLets find the area,");
            Console.Write("\nPress enter key for the area ");
            Console.ReadKey();
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area is {area}");
            Console.ReadKey();
        }
        private static void Part2()
        {
            Console.WriteLine("\nPart 2");
            Console.WriteLine("Solving for the  volume of a hemisphere");
        beginning:
            Console.Write("Enter an integer for the radius: ");
            int radius = int.Parse(Console.ReadLine());
            if (radius >= 0)
            {
            }
            else
            {
                Console.WriteLine("please put in a positive integar");
                goto beginning;
            }
            double numerator = 1.3333 * Math.PI * Math.Pow(radius, 3);
            double volume = numerator / 2;
            Console.Write($"Now using the radius you just input, the volume of a hemishpere is {volume}");
            Console.ReadKey();
        }
        private static void Part3()
        {
            Console.WriteLine("\nPart 3");
            Console.WriteLine("Area of triangle given the length of the sides");
        beginning:
            Console.Write("Enter an integer for side A: ");
            int sideA = int.Parse(Console.ReadLine());
            if (sideA >= 0)
            {

            }
            else
            {
                Console.WriteLine("please put in a positive integar");
                goto beginning;
            }
        step2:
            Console.Write("Enter an integer for side B: ");
            int sideB = int.Parse(Console.ReadLine());
            if (sideB >= 0)
            {

            }
            else
            {
                Console.WriteLine("please put in a positive integar");
                goto step2;
            }
        step3:
            Console.Write("\nEnter an integer for side C: ");
            int sideC = int.Parse(Console.ReadLine());
            if (sideC >= 0)
            {

            }
            else
            {
                Console.WriteLine("please put in a positive integar");
                goto step3;
            }
            double p1 = (sideA + sideB + sideC);
            double p2 = p1 / 2;
            double Area = Math.Sqrt(p2 * (p2 - sideA) * (p2 - sideB) * (p2 - sideC));
            Console.WriteLine($"The Area of the triangle is {Area}");
            Console.ReadKey();
        }
        private static void Part4()
        {
            Console.WriteLine("\nPart 4");
            Console.Write("Quadratic Equation");
        beginning:
            Console.Write("Enter an integer for A: ");
            double intA = Convert.ToDouble(Console.ReadLine());
            if (intA >= 0)
            {

            }
            else
            {
                Console.WriteLine("please put in a positive integar");
                goto beginning;
            }
        step2:
            Console.Write("Enter an integer for B: ");
            double intB = Convert.ToDouble(Console.ReadLine());
            if (intB >= 0)
            {

            }
            else
            {
                Console.WriteLine("please put in a positive integar");
                goto step2;
            }
        step3:
            Console.Write("\nEnter an integer for C: ");
            double intC = Convert.ToDouble(Console.ReadLine());
            if (intC >= 0)
            {

            }
            else
            {
                Console.WriteLine("please put in a positive integar");
                goto step3;
            }
            double dis = Math.Sqrt(Math.Pow(intB, 2) - (4 * intA * intC));
            if (dis >= 0)
            {
                double vert1 = (-intB + dis) / (2 * intA);
                double vert2 = (-intB - dis) / (2 * intA);
                Console.WriteLine($"good {vert1}, {vert2}");
                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("bad");
                goto beginning;
            }


        }

    }    }

