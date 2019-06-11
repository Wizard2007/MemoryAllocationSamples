using System;

namespace MemoryAllocationSamples.LocalFunction
{
    public class LocalFunctionWithOutParams
    {
        public void CallLocalFunc(int arg)
        {
            LocalFuncWithOutParams();

            void LocalFuncWithOutParams()
            {
                arg = arg + 10;
                Console.WriteLine(arg);
            }
        }
    }
}
