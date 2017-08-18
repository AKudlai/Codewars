namespace Codewars.ArraysInversion
{
    public static class ArraysInversion
    {
        public static int[] InvertValues(int[] input)
        {
            int[] invert = new int[input.Length];
            if (input.Length != 0)
            {
                for (int i = 0; i < input.Length; i++)

                {
                    invert[i] = -input[i];
                }
            }
            else
            {
                invert = input;
            }

            return invert;
        }
    }
}