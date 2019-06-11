using System;
using System.Collections.Generic;

namespace MemoryAllocationSamples.Enumerators
{
    public class EnamerableFromArray
    {
        public void InitEnumerable()
        {
            IEnumerable<int> enumerator =  new int[] {1,2,3,4};

            foreach (var val in enumerator)
            {
                Console.WriteLine(val.ToString());
            }
        }
    }
}
