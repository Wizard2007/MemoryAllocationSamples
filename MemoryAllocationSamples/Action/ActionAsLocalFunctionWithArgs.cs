using System;

namespace MemoryAllocationSamples.Action
{
    public class ActionAsLocalFunctionWithArgs
    {
        public void TestAction(Action<string> action) 
            => action("test");
        public void CallActionAsLocalFuncWithArgs(int arg)
        {
            void LocalFuncWithArgs(string s) => Console.Write(s);

            TestAction(LocalFuncWithArgs);
        }
    }
}
