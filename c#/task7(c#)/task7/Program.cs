using System.Runtime.CompilerServices;

namespace task7
{
    internal class Program
    {
        static void Main(string[] args)
        {//task7-2 integer eded,4 simvol//
            var oper = '-';
            var number1 = 35;
            var number2 = 7;
            switch (oper)
            {
                case '+':
                    Console.WriteLine("Addition of two numbers is: " + (number1 + number2));
                    break;
                case '-':
                    Console.WriteLine("Subtraction of two numbers is: " + (number1 - number2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication of two numbers is: " + number1 * number2);
                    break;
                case '/':
                    Console.WriteLine("Division of two numbers is: " + number1 / number2);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }



        }
        }
    }
    