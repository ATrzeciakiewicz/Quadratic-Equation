using System;


namespace Quadratic_Equation
{
    public interface IQuadraticEquation
        {
        void Calculate();
        }
    class Program
    {       
        static void Main(string[] args)
        {
            QuadraticEquation myEquation = new QuadraticEquation();
            
            Console.WriteLine("Parameters quadratic equation:");
            Console.WriteLine("A = " + myEquation.a + ", B = " + myEquation.b + ", C = " + myEquation.c);

            //wywołanie metody
            myEquation.Validate();

            Console.ReadLine();
         }
     }                  
}


