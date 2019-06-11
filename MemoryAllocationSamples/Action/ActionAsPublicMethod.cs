using System;

namespace MemoryAllocationSamples.Action
{
    public class ActionAsPublicMethod
    {
        public void TestAction(Action<string> action) 
            => action("test");

        public void CallAsPublicMethod(int arg)
            => TestAction(PublicFunc);

        public void PublicFunc(string s) 
            => Console.Write(s);
    }
}
