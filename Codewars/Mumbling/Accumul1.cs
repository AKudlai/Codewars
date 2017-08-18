namespace Codewars.Mumbling
{
    public class Accumul1
    {
        public static string Accum(string s)
        {
            string resullt = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                string q = string.Empty;
                for (int j = 0; j < i; j++)
                {
                    q += s[i];
                }

                resullt += s[i].ToString().ToUpper() + q.ToLower() + "-";
            }

            return resullt.Trim('-');
        }
    }
}