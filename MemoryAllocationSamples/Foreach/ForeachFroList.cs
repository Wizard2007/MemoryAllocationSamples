using System;
using System.Collections.Generic;

namespace MemoryAllocationSamples.Foreach
{
    public class ForeachFroList
    {
        public void IterateList()
        {
            var array = new List<int> () { 1, 2, 3, 4, 1, 2, 3, 4, 1, 2, 3, 4 };

            foreach (var val in array)
            {
                Console.WriteLine(val.ToString());
            }
        }
    }
}
