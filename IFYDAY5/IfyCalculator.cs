using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class Calculator
    {
        private double ans;

        public double Add(double x, double y)
        {
            ans = x + y;
            return ans;
        }
        public double Add(double x, double y, double z)
        {
            ans = x + y + z;
            return ans;
        }
        public double Add(params double[] nums)
        {
            ans = 0;
            foreach(var num in nums)
            {
                ans += num;
            }
            return ans;
        }

        public double Subtract(double x, double y)
        {
            ans = x - y;
            return ans;
        }
        public double Divide(double x, double y)
        {
            ans = x / y;
            return ans;
        }
        public double Multiply(double x, double y)
        {
            ans = x * y;
            return ans;
        }

        public void Equality()
        {
            Console.WriteLine("From equality " + ans);
        }
    }
}
