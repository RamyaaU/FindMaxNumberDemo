using System;

namespace FindMaxNumberDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find the max number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            double output1 = MaximumNumberCheck.MaximumDoubleNumber(11.1, 22.2, 33.3);
            Console.WriteLine(output1);
        }
    }
}