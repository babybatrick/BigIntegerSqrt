using System;
using System.Numerics;

namespace BigIntegerSqrt
{
    public static class BigIntegerSqrt
    {
        public static BigInteger Sqrt(BigInteger number)
        {
            BigInteger _x = RandomBigIntegerOfLength((number.ToString().ToCharArray().Length / 2) - 1);
			
            try
            {
                for (int i = 0; i < 15; i++)
                {
                    _x = (_x + number / _x) / 2;
                }
                return _x;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }

        private static BigInteger RandomBigIntegerOfLength(int length)
        {
            Random rand = new Random();

            string _randomNumber = "";
			
            _randomNumber = String.Concat(_randomNumber, rand.Next(1, 10));
		
            for (int i = 0; i < length; i++)
            {
                _randomNumber = String.Concat(_randomNumber,rand.Next(10).ToString());
            }
            if (String.IsNullOrEmpty(_randomNumber) == false) return BigInteger.Parse(_randomNumber);
            else return 0;
        }
    }
}
