using System;
using System.Collections.Generic;

namespace SortListKata
{
    public class ListSorter
    {
        public static IEnumerable<int> BubbleSort(List<int> list)
        {
            if(list.Count < 2)
                return list;

            var sorted = false;
            while (!sorted)
            {
                sorted = true;
                var count = list.Count;
                for (int index = 0; index < count - 1; index++)
                {
                    if (list[index] > list[index + 1])
                    {
                        var temp = list[index];
                        list[index] = list[index + 1];
                        list[index + 1] = temp;
                        sorted = false;
                    }
                }
                count--;
            }

            return list;
        }
    }
}