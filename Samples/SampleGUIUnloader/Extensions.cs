using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SampleGUIUnloader
{
    public static class Extensions
    {
        public static void Swap<T>(this List<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

    }
}
