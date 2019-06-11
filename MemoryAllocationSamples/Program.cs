using System;
using MemoryAllocationSamples.Boxing;

namespace MemoryAllocationSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxingValueType = new BoxingValueType();
            boxingValueType.WriteToConsole();
            Console.ReadKey();
        }
    }
}
