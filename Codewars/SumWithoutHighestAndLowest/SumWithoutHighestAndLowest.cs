namespace Codewars.SumWithoutHighestAndLowest
{
    using System.Linq;

    public static class Kata
    {
        public static int Sum(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0 || numbers.Length == 1)
            {
                return 0;
            }
            int i = 0;
            int arrayMax = numbers[i];
            int arrayMin = numbers[i];

            for (; i <= (numbers.Length - 1); i++)
            {
                if (arrayMax <= numbers[i])
                {
                    arrayMax = numbers[i];
                }

                if (arrayMin >= numbers[i])
                {
                    arrayMin = numbers[i];
                }
            }

            return numbers.Sum() - arrayMax - arrayMin;
        }
    }
}
