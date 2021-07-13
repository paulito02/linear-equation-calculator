using System;

namespace sam
{
    class Program
    {
        static void Main(string[] args)
        {
            float a,b,c,d,e,f;

            Console.WriteLine("Enter A");
            a = Convert.ToSingle( Console.ReadLine() );

            Console.WriteLine("Enter B");
            b = Convert.ToSingle( Console.ReadLine() );

            Console.WriteLine("Enter C");
            c = Convert.ToSingle( Console.ReadLine() );

            Console.WriteLine("Enter D");
            d = Convert.ToSingle( Console.ReadLine() );

            Console.WriteLine("Enter E");
            e = Convert.ToSingle( Console.ReadLine() );

            Console.WriteLine("Enter F");
            f = Convert.ToSingle( Console.ReadLine() );

            float determinant = (a*d) - (b*c);
            float changeInX   = (e*d) - (b*f);
            float changeInY   = (a*f) - (e*c);

            if (determinant == 0)
            {
                Console.WriteLine("The equation has no solution.");
            }
            else
            {
                float x = changeInX/determinant;
                float y = changeInY/determinant;

                Console.WriteLine("The value Of \n X is {0} \n Y is {1} ", x, y);
            }
        }
    }
}
