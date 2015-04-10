using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Equation
{
    public class QuadraticEquation : IQuadraticEquation
    {
        private double a;
        private double b;
        private double c;
     
        //konstruktor
      public QuadraticEquation()
        {
            a = 1;
            b = -5;
            c = 4;
        }

        public QuadraticEquation(double a, double b, double c)
      {
          this.a = a;
          this.b = b;
          this.c = c;
      }
      //metoda
       private void Validate()
      {
          if (a == 0)
          {
             throw new Exception("This is not quadratic equation, because A=0!");
          }        
      }
       //metoda
      public EquationResult Calculate()
      {
          Validate();

          EquationResult myResult = new EquationResult();
          myResult.Delta = (Math.Pow(b, 2) - (4 * a * c));          
          myResult.X = -b / (2 * a);
          myResult.X1 = (-b + Math.Sqrt(myResult.Delta)) / (2 * a);
          myResult.X2 = (-b - Math.Sqrt(myResult.Delta)) / (2 * a);

          return myResult;
      }
    }    
}
