using System;

namespace Overloading_Math
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
            Overload();
            Delegates();
            DelegatesMath();
        }
        static void Overload()
        {
            OverMath math = new OverMath();
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
            Console.WriteLine("Kvadratroden af 9 = " + math.Kvadratrod((float) 9));
            Console.WriteLine("Kvadratroden af 625 = " + math.Kvadratrod("625"));
        }
        public delegate void Del1();
        public delegate float Del2();
        public delegate void Del3(string name, int age, float height);
        static void Delegates()
        {
            Del1 del1;
            Del2 del2;
            Del3 del3;
        }
        public delegate int MathInt(int n1, int n2);
        public delegate float MathFloat(float n1, float n2);
        public delegate int MathString(String n1, String n2);
        public delegate int Math1Int(int n1);
        public delegate float Math1Float(float n1);
        public delegate int Math1String(String n1);
        static void DelegatesMath()
        {
            OverMath math = new OverMath();
            MathInt mathInt = math.Plus;
            Console.WriteLine(n1 + " + " + n2 + " = " + mathInt(n1, n2));
            mathInt = math.Minus;
            Console.WriteLine(n1 + " - " + n2 + " = " + mathInt(n1, n2));
            mathInt = math.Gange;
            Console.WriteLine(n1 + " * " + n2 + " = " + mathInt(n1, n2));
            mathInt = math.Dividere;
            Console.WriteLine(n1 + " / " + n2 + " = " + mathInt(n1, n2));
            mathInt = math.Potens;
            Console.WriteLine(n1 + "^" + n2 + " = " + mathInt(n1, n2)); 
            MathFloat mathFloat = math.Plus;
            Console.WriteLine(n3 + " + " + n4 + " = " + mathFloat(n3, n4));
            mathFloat = math.Minus;
            Console.WriteLine(n3 + " - " + n4 + " = " + mathFloat(n3, n4));
            mathFloat = math.Gange;
            Console.WriteLine(n3 + " * " + n4 + " = " + mathFloat(n3, n4));
            mathFloat = math.Dividere;
            Console.WriteLine(n3 + " / " + n4 + " = " + mathFloat(n3, n4));
            mathFloat = math.Potens;
            Console.WriteLine(n3 + "^" + n4 + " = " + mathFloat(n3, n4));
            MathString mathString = math.Plus;
            Console.WriteLine(n5 + " + " + n6 + " = " + mathString(n5, n6));
            mathString = math.Minus;
            Console.WriteLine(n5 + " - " + n6 + " = " + mathString(n5, n6));
            mathString = math.Gange;
            Console.WriteLine(n5 + " * " + n6 + " = " + mathString(n5, n6));
            mathString = math.Dividere;
            Console.WriteLine(n5 + " / " + n6 + " = " + mathString(n5, n6));
            mathString = math.Potens;
            Console.WriteLine(n5 + "^" + n6 + " = " + mathString(n5, n6));
            Math1Int math1Int = math.Kvadratrod;
            Math1Float math1Float = math.Kvadratrod;
            Math1String math1String = math.Kvadratrod;
            Console.WriteLine("Kvadratroden af 64 = " + math1Int((int)64));
            Console.WriteLine("Kvadratroden af 9 = " + math1Float((float)9));
            Console.WriteLine("Kvadratroden af 625 = " + math1String("625"));
        }
    }
}
