using System;

namespace LinearRecursiveFib
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input an integer n to calculate the nth fibbonanci number");
            int n = Int32.Parse(Console.ReadLine());
            new FibCalc(n);
            Console.ReadLine();
        }
    }

    class FibCalc
    {
        private long[] fibbonacis;

        public FibCalc(int n)
        {
            fibbonacis = new long[n];
            Console.WriteLine(CalculateNthFib(n));
        }

        private long CalculateNthFib(int n)
        {
            if(n<3)
            {
                return 1;
            }
            if(!(fibbonacis[n-1]>0))
            {
                fibbonacis[n - 1] = CalculateNthFib(n - 1) + CalculateNthFib(n - 2);
            }
            return fibbonacis[n - 1];
        }
    }

}
