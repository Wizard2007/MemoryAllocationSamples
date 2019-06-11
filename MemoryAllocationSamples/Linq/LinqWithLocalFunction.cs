using System.Collections.Generic;
using System.Linq;

namespace MemoryAllocationSamples.Linq
{
    public class LinqWithLocalFunction
    {
        void linq(string name)
        {
            var list = new List<string>() { "test1", "test2", "test3" };

            var result = list.Where(x => isEqual(x, name));

            bool isEqual(string x, string y) => x == y;
        }
    }
}
