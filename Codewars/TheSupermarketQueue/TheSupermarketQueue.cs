namespace Codewars.TheSupermarketQueue
{
    using System;
    using System.Linq;

    public class TheSupermarketQueue
    {
        public static long QueueTime(int[] customers, int n)
        {
            if (customers == null || customers.Length == 0)
            {
                return 0;
            }

            if (n > customers.Length)
            {
                return customers.Max();
            }

            int[] temp = new int[n];
            for (int i = 0; i < n; i++)
            {
                temp[i] = customers[i];
            }
            for (int i = n; i < customers.Length; i++)
            {
                temp[Array.IndexOf(temp, temp.Min())] += customers[i];
            }

            return temp.Max();
        }
    }
}
