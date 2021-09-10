using System;

namespace converttobinaryhex
{
    using System;

    public static class Kata
    {
        public static string EvensAndOdds(int num)
        {
            // throw new NotImplementedException();
            //if (num % 2 == 0) return Convert.ToString(num,2);
            //else return Convert.ToString(num,16);

            //return num % 2 == 0 ? Convert.ToString(num, 2) : Convert.ToString(num, 16);

            return Convert.ToString(num, num % 2 == 0 ? 2 : 16);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.EvensAndOdds(2));
            Console.WriteLine(Kata.EvensAndOdds(111));
        }
    }
}
