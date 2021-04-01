using System;
using System.Numerics;

namespace BigIntegerSqrt
{
    public class Program
    {
        public static void Main()
        {
            BigInteger input;
			
            //Converting input into BigInteger using TryParse method, to avoid FormatException
            bool parsed = BigInteger.TryParse(Console.ReadLine(), out input);

            if(parsed) Console.WriteLine(BigIntegerSqrt.Sqrt(input));
            else Console.WriteLine("Invalid Input");
        }
    }
}
