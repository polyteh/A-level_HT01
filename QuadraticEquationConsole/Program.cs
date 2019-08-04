using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuadraticEquationClass;

namespace QuadraticEquationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double coefA, coefB, coefC;
            string solveStatus;

            while (true)
            {

                try
                {
                    Console.Write("Enter a:");
                    coefA = double.Parse(Console.ReadLine());

                    Console.Write("Enter b:");
                    coefB = double.Parse(Console.ReadLine());

                    Console.Write("Enter c:");
                    coefC = double.Parse(Console.ReadLine());

                    //  Console.WriteLine("Data were read successfully");
                    List<double> calculationResult = QuadraticEquation.SolveQuadrEq(coefA,coefB,coefC,out solveStatus);
                    Console.WriteLine("Result string: {0}", solveStatus);

                    if (calculationResult != null)  //we can see results here, if equation has roots
                    {
                        for (int i = 0; i < calculationResult.Count; i++)
                        {
                            Console.WriteLine("Root x{0}={1}", i+1, calculationResult[i]);
                        }
                        Console.WriteLine("Decomposition of equation: {0}", QuadraticEquation.DecompositionEquation);
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine("Data read failed");
                    Console.WriteLine($"Exception occured: {ex.Message}");
                    //Console.WriteLine($"In the method: {ex.TargetSite}");         
 
                }

                Console.WriteLine("Press x for exit or any key to continue input data");
                if (Console.ReadLine() == "x")
                {
                    break;
                }


            }
           
        }
    }
}
