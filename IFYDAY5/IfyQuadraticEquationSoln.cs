using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class QuadraticEquationSoln
    {
        public double GetDeterminant(double a, double b, double c)
        {
            return (Math.Pow(b, 2) - (4 * a * c));
        }

        public double CalculateForLinearRoots(double a, double b)
        {
            return -b / (2 * a);
        }

        public double[] CalculateForQuadRoots(double a, double b, double d)
        {
            var root1 = (-b + Math.Sqrt(d)) / (2 * a);
            var root2 = (-b - Math.Sqrt(d)) / (2 * a);
            return new double[] { root1, root2 };
        }
    }
}
