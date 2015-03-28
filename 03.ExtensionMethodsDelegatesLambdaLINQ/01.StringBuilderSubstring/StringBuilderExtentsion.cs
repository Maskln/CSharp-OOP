namespace _01.StringBuilderSubstring
{
    using System;
    using System.Linq;
    using System.Text;


    public static class StringBuilderExtentsion
    {
        public static StringBuilder Substring(this StringBuilder input, int index, int length)
        {
            StringBuilder result = new StringBuilder();

            if ((index == 0) && (length == input.Length))
            {
                return input;
            }

            try
            {
                for (int i = index; i < index + length; i++)
                {
                    result.Append(input[i]);
                }
            }
            catch (IndexOutOfRangeException ix)
            {

                Console.WriteLine(ix.Message);
            }
            catch (ArgumentOutOfRangeException ax)
            {
                Console.WriteLine(ax.Message);
            }

            return result;

        }
    }
}
