using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Ysfo.App
{
    public static class Extensions
    {
        public enum MoveDirection
        {
            Up,
            Down
        };

        // moves an object in a list, specified by index
        public static bool MoveItem<T>(this BindingList<T> list, int index, MoveDirection direction)
        {
            if (index == -1)
            {
                // item not found
                return false;
            }

            int otherIndex;

            if (direction == MoveDirection.Up)
            {
                otherIndex = index - 1;

                if (otherIndex < 0)
                {
                    // invalid index, return
                    return false;
                }
            }
            else if (direction == MoveDirection.Down)
            {
                otherIndex = index + 1;

                if (otherIndex >= list.Count)
                {
                    // invalid index, return
                    return false;
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid MoveDirection.");
            }

            // swap items
            T tmp = list[index];
            list[index] = list[otherIndex];
            list[otherIndex] = tmp;

            // success
            return true;
        }

        // moves an item in a list, specified by object type
        public static bool MoveItem<T>(this BindingList<T> list, T item, MoveDirection direction)
        {
            int index = list.IndexOf(item);

            // move
            return list.MoveItem(index, direction);
        }

        // adds ForEach to IEnumerable
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action)
        {
            foreach (T item in collection)
            {
                action(item);
            }
        }
    }
}
