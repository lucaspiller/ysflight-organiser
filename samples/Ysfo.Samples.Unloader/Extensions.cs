using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Ysfo.Samples.Unloader
{
    public static class Extensions
    {
        public static void Swap<T>(this BindingList<T> list, int indexA, int indexB)
        {
            if (indexB < 0 || indexB >= list.Count)
                return;

            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

    }
}
