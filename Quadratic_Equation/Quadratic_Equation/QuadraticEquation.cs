using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    class QuadraticEquation : IQuadraticEquation
    {
        public double a;
        public double b;
        public double c;
     
        //konstruktor
      public QuadraticEquation()
        {
            a = 0;
            b = -5;
            c = 4;
        }
      //metoda
       public void Validate()
      {
          if (a == 0)
          {
              Console.WriteLine("This is not quadratic equation, because A=0!");
          }
           else
          {
              Calculate();
          }
          
      }
       //metoda
      public void Calculate()
      {
          
          EquationResult myResult = new EquationResult();
          myResult.Delta = (Math.Pow(b, 2) - (4 * a * c));          
          myResult.X = -b / (2 * a);
          myResult.X1 = (-b + Math.Sqrt(myResult.Delta)) / (2 * a);
          myResult.X2 = (-b - Math.Sqrt(myResult.Delta)) / (2 * a);
   
          
            if (myResult.Delta < 0)
            {
                Console.WriteLine("Discriminant = " + myResult.Delta);
                Console.WriteLine("If the discriminant is negative, then there are no real roots");
            }
            else if (myResult.Delta == 0)
            {
                Console.WriteLine("Discriminant = " + myResult.Delta);
                Console.WriteLine("Solution: x = " + myResult.X);
            }
            else
            {
                Console.WriteLine("Discriminant = " + myResult.Delta);
                Console.Write("Solution: x1 = " + myResult.X1 + ", x2 = " + myResult.X2);
            }
      }
    }

    struct EquationResult
    {
        public double X { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }
        public double Delta { get; set; }       
    }
}
