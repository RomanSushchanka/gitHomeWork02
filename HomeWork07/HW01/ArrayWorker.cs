using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW01
{
    internal class ArrayWorker
    {
        public int[] InvertArray(int[] array)
        {
            int length = array.Length;
            int[] inverted = new int[length];

            for (int i = 0; i < length; i++)
            {
                inverted[i] = array[length - 1 - i];
            }

            return inverted;
        }
    }
}
