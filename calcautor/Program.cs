
using System.Security.Cryptography.X509Certificates;

namespace Calculator;

public  class Program
{
     static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                Console.WriteLine("Calculator");
//
                Console.WriteLine("enter first number");
                double number1 = double.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine("enter second number");
                double number2 = double.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine("select the operation  +   -   *   /  ");
                string ?op = Console.ReadLine();
                if (op == null)
                {
                    Console.WriteLine("wrong");
                    return;
                }
                double result = cal(number1, number2, op);
                Console.WriteLine(result);
                Console.WriteLine("add a new operation Y/N");
                if (Console.ReadLine() != "y")
                    return;
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    
    }

    public static double cal(double n1, double n2, string op)
    {

        //return op switch
        //{
        //    "+" => n1 +n2,
        //    "-" => n1 -n2,
        //    "*" => n1 * n2,
        //    "/" => n2==0 ?throw new InvalidOperationException(op) : n1/n2,
        //    _=> throw new InvalidOperationException(op)

        //};



        switch (op)
        {
            case "+":
                return n1 + n2;

            case "-":
                return n1 - n2;

            case "*":
                return n1 * n2;
                

            case "/":
                if (n2 == 0)
                    throw new InvalidOperationException("no valid");
                return n1 / n2;


            default:
                throw new InvalidOperationException("non valid opeation");
        }


    }
            
         
}
