namespace Codewars.FindTheCapitals
{
    using System.Collections.Generic;
    using System.Linq;

    using static System.Char;

    public class FindTheCapitals
    {
        public static int[] Capitals(string word)
        {
            List<int> res = new List<int>();
            for (int position = 0; position < word.Length; position++)
            {
                if (IsUpper(word[position]))
                {
                    res.Add(position);
                }
            }

            return res.ToArray();
        }

        public static int[] CapitalsLinq(string word)
        {
            return word.Select((c, index) => new { c, index }).Where(o => IsUpper(o.c)).Select(o => o.index).ToArray();
        }
    }
}
