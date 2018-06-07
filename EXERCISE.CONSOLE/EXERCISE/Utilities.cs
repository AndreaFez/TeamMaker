using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCISE
{
    public static class Utilities
    {
        public static void Swap<T>(List<T> l1, List<T> l2, int index)
        {
            T tmp1 = l1.GetRange(index, 1).First();
            T tmp2 = l2.GetRange(index, 1).First();
            l1[index] = tmp2;
            l2[index] = tmp1;
        }

        private static int[] _greyIndexes = new int[] { 0, 1, 0, 2, 0, 1, 0, 3, 0, 1, 0, 2, 0, 1, 0 };
        public static int[] GreyIndexs
        {
            get
            {
                return _greyIndexes;
            }
        }
    }
}
