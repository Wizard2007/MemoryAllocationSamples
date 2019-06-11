using System;

namespace MemoryAllocationSamples.Lambda
{
    public class LambdaWithOutArgs
    {
        public void CreateLambdaWithArgs()
        {
            int i = 10;
            System.Action action = () => Console.WriteLine($"i = {i}");
            action();
        }
    }
}
