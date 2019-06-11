using System;

namespace MemoryAllocationSamples.Lambda
{
    public class LambdaWithArgs
    {
        public void CreateLambdaWithArgs()
        {
            Action<int> l = (int i) => Console.WriteLine($"i = {i}");
        }
    }
}
