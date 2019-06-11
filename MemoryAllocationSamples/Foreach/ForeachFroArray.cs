using System;

namespace MemoryAllocationSamples.Foreach
{
    public class ForeachFroArray
    {
        public void IterateArray()
        {
            var array = new int[] {1, 2, 3, 4, 1, 2, 3, 4 , 1, 2, 3, 4 };

            foreach (var val in array)
            {
                Console.WriteLine(val.ToString());
            }
        }
    }
}
