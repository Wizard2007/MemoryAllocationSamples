using System;

namespace MemoryAllocationSamples.LocalFunction
{
    public class LocalFunctionWithArgs
    {
        public void CallLocalFuncWithArgs()
        {
            LocalFunctionWithArgs("test");

            void LocalFunctionWithArgs(string arg) 
                => Console.WriteLine(arg);
        }
    }
}
