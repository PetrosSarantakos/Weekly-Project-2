using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyProject_2
{
    public class Calculator
    {
        public Calculator()
        {
        }
        private int _num1;
        private int _num2;
        private string _symbol;
        public float Result;
        public List<int> Mcd = new List<int>();

        public void Operators()
        {
            Console.WriteLine("Input + for addition, - for substraction, * for multiplication," +
                                " * for division, % for modulo, r for square root");

            _symbol = Convert.ToString(Console.ReadLine());

            //validity check
            while (_symbol != "+" && _symbol != "-" && _symbol != "*" && _symbol != "/" && _symbol != "%" && _symbol != "r" && _symbol != "R")
            {
                Console.WriteLine("Enter a valid input");
                _symbol = Console.ReadLine();
            }

            Console.WriteLine("Enter first number");
            _num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number");
            _num2 = Convert.ToInt32(Console.ReadLine());
        }
        public int Addition()
        {
            return _num1 + _num2;
        }

        public int Substraction()
        {
            return _num1 - _num2;
        }
        public float Division()
        {
            try
            {
                return _num1 / _num2;
            }
            catch (DivideByZeroException message)
            {
                Console.WriteLine(message);
                return 0;
            }
        }

        public int Multipication()
        {
            return _num1 * _num2;
        }

        public int Modulo()
        {
            return _num1 % _num2;
        }

        public float Operation()
        {
            switch (_symbol)
            {

                case "+":
                    Result = Addition();
                    break;
                case "-":
                    Result = Substraction();
                    break;
                case "*":
                    Result = Multipication();
                    break;
                case "/":
                    Result = Division();
                    break;
                case "%":
                    Result = Modulo();
                    break;
                case "r":
                case "R":
                    Result = Convert.ToSingle(Math.Sqrt(_num1));
                    break;
            }

            return Result;
        }

        public bool IsPrimeNumber()
        {
            int count = 0;
            for (int i = 1; i <= Result; i++)
                if (Result % i == 0)
                {
                    count = count + 1;//I add how many times a divisor is found
                }

            if (count == 2)//if the divisors are exactly too (1 and the same number), the number is prime
            {
                return true;
            }
            else//if there are more than 2 divisors, the number is not prime
            {
                return false;
            }

        }
        public List<int> Divisors()
        {
            if (Result > 0)
            {
                for (int i = 1; i <= Result; i++)
                {
                    if (Result % i == 0)
                    {
                        Mcd.Add(i);//this creates a list with the exact divisors

                    }
                }
            }
            else if (Result < 0)
                for (int i = -1; i >= Result; i--)
                {
                    if (Result % i == 0)
                    {
                        Mcd.Add(i);//this creates a list with the exact divisors

                    }
                }
            return Mcd;
        }

    }
}
    



