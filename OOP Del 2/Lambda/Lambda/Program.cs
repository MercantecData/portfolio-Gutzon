using System;

namespace Lambda
{
    class Program
    {
        public static Func<int, int> fordobler = x => x * 2;
        public static Func<float, float, float, float> sumOfThree = (n1, n2, n3) => n1 + n2 + n3 ;
        public static Func<string> hello = () => "Hello World!!!";
        static void Main(string[] args)
        {
            Console.WriteLine(fordobler(2));
            Console.WriteLine(sumOfThree(2, 6, 1));
            Console.WriteLine(hello());
        }
    }
}
