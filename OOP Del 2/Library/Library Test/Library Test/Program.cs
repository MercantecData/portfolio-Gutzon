using System;
using MathLibrary;

namespace Library_Test
{
    class Program
    {
        public static int n1 = 2;
        public static int n2 = 3;
        public static float n3 = 1;
        public static float n4 = 4;
        public static string n5 = "3";
        public static string n6 = "3";
        static void Main(string[] args)
        {
            Mathtest();
        }
        static void Mathtest()
        {
            LibraryMath math = new LibraryMath();
            Console.WriteLine(n1 + " + " + n2 + " = " + math.Plus(n1, n2));
            Console.WriteLine(n3 + " + " + n4 + " = " + math.Plus(n3, n4));
            Console.WriteLine(n5 + " + " + n6 + " = " + math.Plus(n5, n6));
            Console.WriteLine(n1 + " - " + n2 + " = " + math.Minus(n1, n2));
            Console.WriteLine(n3 + " - " + n4 + " = " + math.Minus(n3, n4));
            Console.WriteLine(n5 + " - " + n6 + " = " + math.Minus(n5, n6));
            Console.WriteLine(n1 + " * " + n2 + " = " + math.Gange(n1, n2));
            Console.WriteLine(n3 + " * " + n4 + " = " + math.Gange(n3, n4));
            Console.WriteLine(n5 + " * " + n6 + " = " + math.Gange(n5, n6));
            Console.WriteLine(n1 + " / " + n2 + " = " + math.Dividere(n1, n2));
            Console.WriteLine(n3 + " / " + n4 + " = " + math.Dividere(n3, n4));
            Console.WriteLine(n5 + " / " + n6 + " = " + math.Dividere(n5, n6));
            Console.WriteLine(n1 + "^" + n2 + " = " + math.Potens(n1, n2));
            Console.WriteLine(n3 + "^" + n4 + " = " + math.Potens(n3, n4));
            Console.WriteLine(n5 + "^" + n6 + " = " + math.Potens(n5, n6));
            Console.WriteLine("Kvadratroden af 64 = " + math.Kvadratrod((int)64));
            Console.WriteLine("Kvadratroden af 9 = " + math.Kvadratrod((float)9));
            Console.WriteLine("Kvadratroden af 625 = " + math.Kvadratrod("625"));
        }
    }
}
