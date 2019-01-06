using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(1 + "  " + 21 + "  " + 17);
            Console.WriteLine("**************************************");
            Console.ReadLine();

            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
            Console.WriteLine("**************************************");
            Console.ReadLine();

            int centimeter = 512;
            int meter = centimeter / 100;
            Console.Write(centimeter + " sm = ");
            Console.WriteLine(meter + " m");
            Console.WriteLine("**************************************");
            Console.ReadLine();

            int day = 234;
            int week = day / 7;
            Console.Write("In " + day + " days = ");
            Console.WriteLine(week + " weeks");
            Console.WriteLine("**************************************");
            Console.ReadLine();

            int numbers = 48;
            int second_numbers_in_numbers = numbers % 10;
            int decade = numbers / 10;
            int unit = numbers / 1;
            int sum = decade + second_numbers_in_numbers;
            int multiplication = decade * second_numbers_in_numbers;
            Console.WriteLine("In " + numbers + " :");
            Console.WriteLine("Decade = " + decade);
            Console.WriteLine("Unit = " + unit);
            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Multip = " + multiplication);
            Console.WriteLine("**************************************");
            Console.ReadLine();

            bool A = true;
            bool B = false;
            bool C = false;
            Console.WriteLine(A || B);
            Console.WriteLine(A && B);
            Console.WriteLine(B || C);
            Console.WriteLine("**************************************");
            Console.ReadLine();

            int radius = 5;
            int a_square = 7;
            double area_circle = Math.Pow(a_square, 2);
            double area_square = 3.14 * Math.Pow(radius, 2);
            if (area_circle > area_square)
            {
                Console.WriteLine("Circle > Square");
                Console.WriteLine("**************************************");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Circle < Square");
                Console.WriteLine("**************************************");
                Console.ReadLine();
            }


            int massa1 = 15;
            int massa2 = 21;
            int volume1 = 4;
            int volume2 = 5;
            double density1 = massa1 / volume1;
            double density2 = massa2 / volume2;
            if (density1 > density2)
            {
                Console.WriteLine("density1 > density2");
                Console.WriteLine("**************************************");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("density1 < density2");
                Console.WriteLine("**************************************");
                Console.ReadLine();
            }


            int resistance1 = 25;
            int resistance2 = 40;
            int voltage1 = 120;
            int voltage2 = 130;
            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;
            if (current1 > current2)
            {
                Console.WriteLine("LESS - " + current2);
                Console.WriteLine("**************************************");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("LESS - " + current1);
                Console.WriteLine("**************************************");
                Console.ReadLine();
            }


            int min_a = 20;
            int max_a = 35;
            for(int i=min_a; i<=max_a; i++)
            {
                Console.WriteLine(i);
            }
            Console.Write("-----------------------------");
            Console.ReadLine();
            
            int full_numbers1 = 10;
            Console.WriteLine("a = " + full_numbers1);
            Console.Write("Enter b: ");
            int full_numbers2 = int.Parse(Console.ReadLine());
            for (int i = full_numbers1; i <= full_numbers2; i++)
            {
                Console.WriteLine(Math.Pow(i,2));
            }
            Console.Write("-----------------------------");
            Console.ReadLine();

            int entire2 = 50;
            Console.WriteLine("b = " + entire2);
            Console.Write("Enter a: ");
            int entire1 = int.Parse(Console.ReadLine()); 
            for (int i = entire1; i <= entire2; i++)
            {
                Console.WriteLine(Math.Pow(i, 3));
            }
            Console.Write("-----------------------------");
            Console.ReadLine();

            Console.Write("Enter a: ");
            int whole1 = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int whole2 = int.Parse(Console.ReadLine());
            for (int i = whole1; i <= whole2; i++)
            {
                Console.WriteLine(i);
            }
            Console.Write("-----------------------------");
            Console.ReadLine();
        }
    }
}
