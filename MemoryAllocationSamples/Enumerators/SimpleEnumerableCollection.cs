using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryAllocationSamples.Enumerators
{
    public class SimpleEnumerableCollection
    {
        public void InitEnumerable()
        {
            var enumerator = GetItems();
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
