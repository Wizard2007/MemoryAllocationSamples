using System;

namespace MemoryAllocationSamples.Action
{
    public class ActionAsLambda
    {
        public void TestAction(Action<string> action) 
            => action("test");

        public void CallAsLambda(int arg) 
            => TestAction((string s) => Console.Write(s));
    }
}
