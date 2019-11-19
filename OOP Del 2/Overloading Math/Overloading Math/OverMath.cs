using System;
using System.Collections.Generic;
using System.Text;

namespace Overloading_Math
{
    class OverMath
    {
        private int StringToInt(string s)
        {
            int n;
            if (Int32.TryParse(s, out n) != true)
            {
                n = 0;
            }
            return n;
        }
        //Plus
        public int Plus(int n1, int n2)
        {
            return n1 + n2;
        }
        public float Plus(float n1, float n2)
        {
            return n1 + n2;
        }
        public int Plus(string s1, string s2)
        {
            int n1 = StringToInt(s1);
            int n2 = StringToInt(s2);
            return n1 + n2;
        }
        //Minus
        public int Minus(int n1, int n2)
        {
            return n1 - n2;
        }
        public float Minus(float n1, float n2)
        {
            return n1 - n2;
        }
        public int Minus(string s1, string s2)
        {
            int n1 = StringToInt(s1);
            int n2 = StringToInt(s2);
            return n1 - n2;
        }
        //Gange
        public int Gange(int n1, int n2)
        {
            return n1 * n2;
        }
        public float Gange(float n1, float n2)
        {
            return n1 * n2;
        }
        public int Gange(string s1, string s2)
        {
            int n1 = StringToInt(s1);
            int n2 = StringToInt(s2);
            return n1 * n2;
        }
        //Dividere
        public int Dividere(int n1, int n2)
        {
            return n1 / n2;
        }
        public float Dividere(float n1, float n2)
        {
            return n1 / n2;
        }
        public int Dividere(string s1, string s2)
        {
            int n1 = StringToInt(s1);
            int n2 = StringToInt(s2);
            return n1 / n2;
        }
        //Kvadratrod
        public int Kvadratrod(int n)
        {
            int i = 1;
            while (i * i >= n)
            {
                i += 1;
            }
            return i;
        }
        public float Kvadratrod(float n)
        {
            return Kvadratrod(n);
        }
        public int Kvadratrod(string s)
        {
            int n = StringToInt(s);
            return Kvadratrod(n);
        }
        //Potens
        public int Potens(int n1, int n2)
        {
            int i = 1;
            int j = n1;
            while (i < n2)
            {
                j = j * n1;
                i += 1;
            }
            return j;
        }
        public float Potens(float n1, float n2)
        {
            return Potens(n1, n2);
        }
        public int Potens(string s1, string s2)
        {
            int n1 = StringToInt(s1);
            int n2 = StringToInt(s2);
            return Potens(n1, n2);
        }
       
    }
}
