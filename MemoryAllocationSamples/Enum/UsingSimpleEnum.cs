using System;

namespace MemoryAllocationSamples.Enum
{
    public class UsingSimpleEnum
    {
        public void UseSimpleEnum()
        {
            var condition = SimpleEnum.No;

            if (SimpleEnum.Yes == condition)
            {
                Console.WriteLine("Yes.");
            }
        }
    }
}
