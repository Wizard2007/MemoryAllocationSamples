using System;
using System.Collections.Generic;

namespace MemoryAllocationSamples.Foreach
{
    public class ForeachFroEnamerable
    {
        public void IterateList()
        {
            var array = GetItems();

            foreach (var val in array)
            {
                Console.WriteLine(val.ToString());
            }
        }
        public IEnumerable<int> GetItems()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
        }

    }
}
