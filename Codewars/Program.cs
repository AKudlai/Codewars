namespace Codewars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    using Codewars.AlternatingCase;

    public class Program
    {
        public static void Main(string[] args)
        {
            foreach (int capital in FindTheCapitals.FindTheCapitals.Capitals("CodEWaRs"))
            {
                Console.Write(capital);
            }
        }
    }
}
