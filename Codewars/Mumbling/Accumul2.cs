namespace Codewars.Mumbling
{
    using System;
    using System.Linq;

    public class Accumul2
    {
        public static string Accum(string s)
        {
            return string.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));
        }
    }
}
