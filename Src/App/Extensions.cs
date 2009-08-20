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

        public static bool MoveItem<T>(this BindingList<T> list, T item, MoveDirection direction)
        {
            int index = list.IndexOf(item);
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
                throw new ArgumentException("Invalid MoveDirection.");
            }

            // swap items
            list[index] = list[otherIndex];
            list[otherIndex] = item;

            // success
            return true;
        }
    }
}
