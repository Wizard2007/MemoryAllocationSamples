using System;

namespace MemoryAllocationSamples.Event
{
    public class EventHandlerAsAnonymouseDelegate
    {
        public event EventHandler<string> Event;

        public void Subscribe()
            => Event += delegate(object sender, string s) { Console.WriteLine(s); };
    }
}
