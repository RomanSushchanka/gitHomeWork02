using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;


namespace HW03
{
    public static class ArrayExtensions
    {
        public static int MaxValue(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            
            if (array.Length == 0)
            {
                throw new InvalidOperationException("The array is empty.");
            }

            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }
    }
}
