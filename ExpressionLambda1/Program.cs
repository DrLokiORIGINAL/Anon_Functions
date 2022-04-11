using System;

namespace ExpressionLambda1
{
    public delegate bool CompareDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            CompareDelegate cD = (x, y) => x == y;
            bool result = cD(10, 5);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
