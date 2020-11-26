using System;
using System.Globalization;

namespace RelocationElementsTask
{
    /// <summary>
    /// Class for operations with array.
    /// </summary>
    public static class ArrayExtension
    {
        /// <summary>
        /// Moves all of the elements with set value to the end, preserving the order of the other elements.
        /// </summary>
        /// <param name="source"> Source array. </param>
        /// <param name="value">Source value.</param>
        /// <exception cref="ArgumentNullException">Thrown when source array is null.</exception>
        /// <exception cref="ArgumentException">Thrown when source array is empty.</exception>
        public static void MoveToTail(int[] source, int value)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source), "array is null");
            }

            if (source.Length == 0)
            {
                throw new ArgumentException(nameof(source), "array is empty");
            }

            int len = source.Length;
            int i = 0;
            while (i < len)
            {
                if (source[i] == value)
                {
                    var temp = source[i];
                    int j = i;
                    while (j < len - 1)
                    {
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                        j++;
                    }

                    len--;
                    i--;
                }

                i++;
            }
        }
    }
}
