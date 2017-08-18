namespace Codewars.AlternatingCase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using static System.Char;
    using static System.String;

    public static class StringExt
    {
        public static string ToAlternatingCase(this string s)
        {
            string resaultString = Empty;

            for (int i = 0; i < s.Length; i++)
            {
                if (IsUpper(s[i]))
                {
                    resaultString += ToLower(s[i]);
                }
                else
                {
                    resaultString += ToUpper(s[i]);
                }               
            }

            return resaultString;
        }
    }
}
