using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator calc1 = new Calculator();

            calc1.Operators();
            float result1 = calc1.Operation();
            Console.WriteLine($"The result is {result1}");
            List<int> Mcd_Result1 = calc1.Divisors(); //I created a list with the divisors of result1

            Console.WriteLine("Let's do another calculation!");

            Calculator calc2 = new Calculator();
            calc2.Operators();
            float result2 = calc2.Operation();
            Console.WriteLine($"The result is {result2}");
            List<int> Mcd_Result2 =calc2.Divisors();//I created a list with the divisors of result2

            var CommonDivisors = Mcd_Result1.Intersect(Mcd_Result2); //I add the common divisors in a new list, so i can get the last element
                                                                     //which is the maximum common divisors

            if (CommonDivisors.Count() == 0)
            {
                Console.WriteLine("There are no common divisors");
            }
            else
            {
                Console.WriteLine($"The maximum common divisor of {result1} and {result2} is {CommonDivisors.Last()}");
            }
            

            Console.WriteLine($"\nIs {result2} a prime number? {calc2.IsPrimeNumber()}");

            Fibonacci fib = new Fibonacci();
            long fibo = fib.FibonacciCalc(result2);
            Console.WriteLine($"\nFibonacci number {result2} is {fibo}");

            Console.WriteLine($"\nIs {result2} a Fibbonaci number? {fib.IsResultFibonacci(result2)}");

            Console.ReadLine();



            
        }
    }
}
