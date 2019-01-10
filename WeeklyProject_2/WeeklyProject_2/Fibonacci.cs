using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject_2
{
    class Fibonacci
    {
        List<long> FibonacciList = new List<long>();
        int temp = 0;
        int a = 1;
        int b = 1;
        public long FibonacciCalc(float result)
        {
            if (result > 0)//we can't have fibonacci below zero
            {
                for (int i = 1; i <= result; i++)
                {
                    a = temp - a;
                    b = a + b;
                    temp = b;
                    FibonacciList.Add(b);//I add all fibonacci numbers in this list
                }
            }
            else
                b = 0;
            return b;

        }
        public bool IsResultFibonacci(float result)
        {
            return FibonacciList.Contains(Convert.ToInt64(result));//With list.Contains(result) I check if the result is in the list of Fibonacci numbers
           
        }
    }
}
