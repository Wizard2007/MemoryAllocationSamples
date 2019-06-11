using System;
using System.Collections.Generic;

namespace MemoryAllocationSamples.Lambda
{
    public class LambdaRewriteLocalVariable
    {
        public void CallWithRewriteLocalVariable()
        {
            int i = 10;
            int n = 0;
            System.Action action = () => Console.WriteLine($"i = {i}");
            i++;
            n++;
            Console.WriteLine($"i = {i}");

            foreach (var item in GetItems())
            {
                Console.WriteLine(item);
            }

        }

            public static IEnumerable<string> GetItems()
            {
                yield return "item 1";
                yield return "item 2";
                yield return "item 3";
            }
    }


}


