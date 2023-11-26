using System;


    class Program
{


    public static void QuaEquat(double a, double b, double c)
    {
        if (a == 0)
            if (b == 0)
                if (c == 0)
                    Console.WriteLine("x - любое");
                else
                    Console.WriteLine("нет корней");
            else
                Console.WriteLine("x = {0}", -c / b);
        else
        {
            double d = b * b - 4 * a * c;
            if (d >= 0)
            {
                d = Math.Sqrt(d);
                Console.WriteLine("x1 = {0}", (-b + d) / (2 * a));
                Console.WriteLine("x2 = {0}", (-b - d) / (2 * a));
                
            }
            else
                Console.WriteLine("нет вещ-ных корней");
        }
        Console.ReadKey();
    }




    static void Main(string[] args)
    {

        Console.WriteLine("Решение уравнения типа A×x2 + B×x + C = 0 ");

        double a, b, c;
        Console.WriteLine("a ="); 
        a=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("b =");
        b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("c =");
        c = Convert.ToDouble(Console.ReadLine());


        QuaEquat (a, b, c);



    }



}