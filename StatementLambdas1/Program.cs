using System;

namespace StatementLambdas1
{
    public delegate int SubDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            SubDelegate sD = (s, d) =>
            {
                int res = s - d;
                return res;
            };
            int c = sD(10, 8);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}
