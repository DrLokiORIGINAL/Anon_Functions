using System;

namespace ExpressionLambdas2
{
    public delegate string StrDelegate(string s, int x);
    class Program
    {
        static void Main(string[] args)
        {
            StrDelegate sD = (string str, int a) => str + Convert.ToString(a);
            Console.WriteLine(sD("gdhsidhgl", 99123897));
            Console.ReadKey();
        }
    }
}
