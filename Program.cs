using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;


class Program
{


    public static double QuaEquat(double a, double b, double c, ref double x1, ref double x2)
    {

        double d = b * b - 4 * a * c;

        if (d < 0)
        {
            return -1;

        }

        if (d == 0)
        {
            x1 = -c / b;
            x2 = x1;
            return 0;
        }

        if (d > 0)
        {
            d = Math.Sqrt(d);
            x1 = (-b + d) / (2 * a);
            x2 = (-b - d) / (2 * a);

            if ((-b + d) / (2 * a) == (-b - d) / (2 * a))
            {
                x1 = x2;
                return 1;
            }
            return 1;

        }

        return 0;

    }


    static void Main(string[] args)
    {
        Console.WriteLine("Решение уравнения типа A×x2 + B×x + C = 0 ");

        double a, b, c;
        Console.WriteLine("a =");
        a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("b =");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("c =");
        c = Convert.ToDouble(Console.ReadLine());


        double x1 = 0;

        double x2 = 0;


        QuaEquat(a, b, c, ref x1, ref x2);


        switch (QuaEquat(a, b, c, ref x1, ref x2))
        {
            case 0:
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} один x1=x2={3}", a, b, c, x1);
                break;
            case 1:
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2}  равны x1={3: 0.0} , x2 = {4: 0.0}", a, b, c, x1, x2);
                break;
            case -1:
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет.", a, b, c);
                break;
        }
    }

}