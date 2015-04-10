using System;


namespace Quadratic_Equation
{
    class Program
    {       
        static void Main(string[] args)
        {
            QuadraticEquation myEquation = new QuadraticEquation();
            EquationResult result = myEquation.Calculate();

            
            Console.WriteLine("Parameters quadratic equation:");

            if (result.Delta < 0)
            {
                Console.WriteLine("Discriminant = " + result.Delta);
                Console.WriteLine("If the discriminant is negative, then there are no real roots");
            }
            else if (result.Delta == 0)
            {
                Console.WriteLine("Discriminant = " + result.Delta);
                Console.WriteLine("Solution: x = " + result.X);
            }
            else
            {
                Console.WriteLine("Discriminant = " + result.Delta);
                Console.Write("Solution: x1 = " + result.X1 + ", x2 = " + result.X2);
            }
            Console.ReadLine();
         }
     }                  
}


