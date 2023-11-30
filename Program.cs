using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;


class Program
{


    public static (int flag, double x1, double x2)  QuaEquat(double a, double b, double c)
    {

        double d = b * b - 4 * a * c;
        (int flag, double x1, double x2) result;
       result = (0, 0, 0);


        if (d == 0)
        {
            result.x1 = -b/(2 * a);
            result.flag = 0;
        }
        else
        {
            result.flag = -1;
        }

        if (d > 0)
        {
            result.x1 = (-b + Math.Sqrt(d)) / (2 * a);
            result.x2 = (-b - Math.Sqrt(d)) / (2 * a);
            result.flag = 1;


        }


        return result;

    }


    static void Main(string[] args)
    {

        double a, b, c;

        try
        {

            Console.WriteLine("Решение уравнения типа A×x2 + B×x + C = 0 ");

            Console.WriteLine("a =");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("b =");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine("c =");
            c = double.Parse(Console.ReadLine());


            var result = QuaEquat(a, b, c);

            switch (result.flag)
            {

                case 0:
                    Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} один x1=x2={3}", a, b, c, Convert.ToString(result.x1));
                    break;
                case 1:
                    Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2}  равны x1={3: 0.0} , x2 = {4: 0.0}", a, b, c, Convert.ToString(result.x1), Convert.ToString(result.x2));
                    break;
                case -1:
                    Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет.", a, b, c);
                    break;
                default:
                    Console.WriteLine("Ошибка расчета");
                    break;

            }


        }


        catch
        {
            Console.WriteLine("Ошибка ");
        }




    }

}