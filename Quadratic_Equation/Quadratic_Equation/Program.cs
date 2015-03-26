using System;


namespace Quadratic_Equation
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, result;
            a = 1;
            b = -5;
            c = 4;
            delta = (Math.Pow(b,2) - (4 * a * c));

            Console.WriteLine("Parameters quadratic equation:");
            Console.WriteLine("A = " + a + ", B = " + b + ", C = " + c);
            Console.WriteLine("Discriminant = " + delta); 

            if (a==0)
            {
                Console.WriteLine("This is not quadratic equation, because A=0!");
            }
              else if (delta<0)
               {
                Console.WriteLine("If the discriminant is negative, then there are no real roots");
               }
              else if (delta == 0)
               {                 
                result = -b / (2 * a);
                Console.WriteLine("Solution: x = " + result);               
               }
            else
              {
               result = (-b + Math.Sqrt(delta)) /( 2 * a);
               Console.Write("Solution: x1 = " + result);
               result = (-b - Math.Sqrt(delta)) / (2 * a);
               Console.WriteLine(", x2 = " + result);
              }
            Console.ReadLine();
            }
            
        }
    }

