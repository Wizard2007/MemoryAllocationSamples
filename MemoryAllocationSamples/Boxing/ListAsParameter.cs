using System;
using System.Collections.Generic;

namespace MemoryAllocationSamples.Boxing
{
    public class ListAsParameter
    {
        public void TestPrintItems()
        {
            var items = new List<int> { 1, 2, 3, 4, 5 };

            PrintItems(items);
        }

        public void PrintItems(List<int> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine("item = {0}", item.ToString());
            }
        }
    }
}
