using System;
using System.Collections.Generic;

namespace Strategy
{
    public class MergeShort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Merge sort list ");
        }
    }
}