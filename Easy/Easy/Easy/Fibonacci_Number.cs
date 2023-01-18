using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * https://leetcode.com/problems/fibonacci-number/
 */
namespace Easy
{
    public class Fibonacci_Number
    {
        public int Fib(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            int n1 = 0, n2 = 1, fib = 1;
            for (int i = 1; i < n; i++)
            {
                fib = n1 + n2;
                n1 = n2;
                n2 = fib;
            }
            return fib;
        }
    }
}
