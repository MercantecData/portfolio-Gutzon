using System;

namespace Lambda_Math
{
    class Program
    {
        public static int n1 = 2;
        public static int n2 = 3;
        public static float n3 = 1;
        public static float n4 = 4;
        public static string n5 = "3";
        public static string n6 = "3";

        private static Func<string, int> stringToInt = s =>
        {
            if (Int32.TryParse(s, out int n) != true) { n = 0; }
            return n;
        };
        //Plus
        public static Func<int, int, int> intPlus = (n1, n2) => n1 + n2;
        public static Func<float, float, float> floatPlus = (n1, n2) => n1 + n2;
        public static Func<string, string, int> stringPlus = (s1, s2) => stringToInt(s1) + stringToInt(s2);
        //Minus
        public static Func<int, int, int> intMinus = (n1, n2) => n1 - n2;
        public static Func<float, float, float> floatMinus = (n1, n2) => n1 - n2;
        public static Func<string, string, int> stringMinus = (s1, s2) => stringToInt(s1) - stringToInt(s2);
        //Gange
        public static Func<int, int, int> intGange = (n1, n2) => n1 * n2;
        public static Func<float, float, float> floatGange = (n1, n2) => n1 * n2;
        public static Func<string, string, int> stringGange = (s1, s2) => stringToInt(s1) * stringToInt(s2);
        //Divider
        public static Func<int, int, int> intDivider = (n1, n2) => n1 / n2;
        public static Func<float, float, float> floatDivider = (n1, n2) => n1 / n2;
        public static Func<string, string, int> stringDivider = (s1, s2) => stringToInt(s1) / stringToInt(s2);
        //Potens
        public static Func<int, int, int> intPotens = (n1, n2) =>
        {
            int i = 1;
            int j = n1;
            while (i < n2)
            {
                j *= n1;
                i += 1;
            }
            return j;
        };
        public static Func<float, float, float> floatPotens = (n1, n2) => intPotens((int) n1, (int) n2);
        public static Func<string, string, int> stringPotens = (s1, s2) => intPotens(stringToInt(s1), stringToInt(s2));
        //Kvadratrod
        public static Func<int, int> intKvadratrod = (n) =>
        {
            int i = 1;
            while (i * i < n)
            {
                i += 1;
            }
            return i;
        };
        public static Func<float, float> floatKvadratrod = (n) => intKvadratrod((int)n);
        public static Func<string, int> stringKvadratrod = (s) => intKvadratrod(stringToInt(s));
        static void Main(string[] args)
        {
            Console.WriteLine(n1 + " + " + n2 + " = " + intPlus(n1, n2));
            Console.WriteLine(n1 + " - " + n2 + " = " + intMinus(n1, n2));
            Console.WriteLine(n1 + " * " + n2 + " = " + intGange(n1, n2));
            Console.WriteLine(n1 + " / " + n2 + " = " + intDivider(n1, n2));
            Console.WriteLine(n1 + "^" + n2 + " = " + intPotens(n1, n2));
            Console.WriteLine(n3 + " + " + n4 + " = " + floatPlus(n3, n4));
            Console.WriteLine(n3 + " - " + n4 + " = " + floatMinus(n3, n4));
            Console.WriteLine(n3 + " * " + n4 + " = " + floatGange(n3, n4));
            Console.WriteLine(n3 + " / " + n4 + " = " + floatDivider(n3, n4));
            Console.WriteLine(n3 + "^" + n4 + " = " + floatPotens(n3, n4));
            Console.WriteLine(n5 + " + " + n6 + " = " + stringPlus(n5, n6));
            Console.WriteLine(n5 + " - " + n6 + " = " + stringMinus(n5, n6));
            Console.WriteLine(n5 + " * " + n6 + " = " + stringGange(n5, n6));
            Console.WriteLine(n5 + " / " + n6 + " = " + stringDivider(n5, n6));
            Console.WriteLine(n5 + "^" + n6 + " = " + stringPotens(n5, n6));
            Console.WriteLine("Kvadratroden af 64 = " + intKvadratrod((int)64));
            Console.WriteLine("Kvadratroden af 9 = " + floatKvadratrod((float)9));
            Console.WriteLine("Kvadratroden af 625 = " + stringKvadratrod("625"));
        }
    }
}
