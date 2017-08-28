namespace Codewars.ReverseOrRotate
{
    using System;
    using System.Linq;
    using static System.String;

    public class Revrot
    {
        public static string RevRot(string strng, int sz)
        {
            string res = Empty;
            if (sz == 0)
            {
                return res;
            }

            int splitCount = strng.Length / sz;
            string[] substrings = new string[splitCount];

            for (int i = 0; i < splitCount; i++)
            {
                substrings[i] = strng.Substring(i * sz, sz);
            }

            foreach (var s in substrings)
            {
                if (SumOfCube(s))
                {
                    res += Rev(s);
                }
                else
                {
                    res += Rot(s);
                }
            }

            return res;
        }

        public static string Rev(string s)
        {
            char[] tempArr = new char[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                tempArr[i] = s[i];
            }

            return Concat<char>(tempArr.Reverse());
        }

        public static string Rot(string s)
        {
            return s.Substring(1) + s[0];
        }

        public static bool SumOfCube(string substring)
        {
            double res = 0;
            bool ctr = false;
            foreach (char c in substring)
            {              
                res += Math.Pow(Convert.ToInt32(c), 3);
            }

            if (res % 2 == 0)
            {
                ctr = true;
            }
            return ctr;
        }
    }
}
