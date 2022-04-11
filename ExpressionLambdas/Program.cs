using System;

namespace ExpressionLambdas
{
    public delegate void HelloDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            HelloDelegate hD = () => Console.WriteLine("hello");

            hD();

            Console.ReadKey();
        }
    }
}
