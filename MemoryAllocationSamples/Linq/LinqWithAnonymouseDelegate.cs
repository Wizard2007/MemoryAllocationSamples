using System.Collections.Generic;
using System.Linq;

namespace MemoryAllocationSamples.Linq
{
    public class LinqWithAnonymouseDelegate
    {
        void linq(string name)
        {
            var list = new List<string>() {"test1", "test2", "test3"};

            var result = list.Where(delegate(string s) { return s == name; });
        }
    }
}
