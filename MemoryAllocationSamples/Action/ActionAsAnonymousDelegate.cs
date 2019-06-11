using System;

namespace MemoryAllocationSamples.Action
{
    public class ActionAsAnonymousDelegate
    {
        public void TestAction(Action<string> action)
            => action("test");

        public void CallAsAnonymousDelegate(int arg)
            => TestAction(delegate(string s) { Console.Write(s); });
    }
}
