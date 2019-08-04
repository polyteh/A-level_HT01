using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquationClass
{
    public class QuadraticEquation
    {

        static string decompositionEquation;
         
          public static List<double> SolveQuadrEq(double coef_A, double coef_B, double coef_C, out string calclStatus)   //main solver, returtn List of doubles or null, if D<0
        {
            List<double> equationRoots = new List<double>();

            if (equationRoots != null)
            {
                equationRoots.Clear();
            };

            if (coef_A==0)
            {
                equationRoots = null;
                calclStatus = "Coeficient A is equal to zero!";
                return equationRoots;

            }

            double discr_C = Math.Pow(coef_B, 2.0) - 4 * coef_A * coef_C;

            if (discr_C>=0)
            {
                double x1 = (-coef_B + Math.Sqrt(discr_C)) / (2 * coef_A);
                double x2 = (-coef_B - Math.Sqrt(discr_C)) / (2 * coef_A);

                equationRoots.Add(x1);
                equationRoots.Add(x2);
                calclStatus = "Solved";
                //Console.WriteLine("Solved");
                decompositionEquation= coef_A.ToString() + "x^2" + ConvertDoubleToStringPlus(coef_B) + "x" + ConvertDoubleToStringPlus(coef_C)+"=" 
                    + coef_A.ToString()+"(x"+ConvertDoubleToStringMinus(x1)+")(x"+ ConvertDoubleToStringMinus(x2)+")";
                return equationRoots;
            }
            else
            {
                equationRoots = null;
                calclStatus = "Not solved, bad input data";
                return equationRoots;
            }


        }

        public static string DecompositionEquation //double to string, if sum
        {
            get {
                return decompositionEquation;

            }
        }

        public static string ConvertDoubleToStringPlus(double coefDouble) //double to string, if deduct
        {
            return coefDouble >= 0 ? "+"+coefDouble.ToString() : coefDouble.ToString();

        }

        public static string ConvertDoubleToStringMinus(double coefDouble)
        {
            return coefDouble >= 0 ? "-"+coefDouble.ToString() :  "+"+Math.Abs(coefDouble).ToString();

        }

    }
}
