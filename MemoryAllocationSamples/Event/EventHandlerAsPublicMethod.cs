using System;

namespace MemoryAllocationSamples.Event
{
    public class EventHandlerAsPublicMethod
    {
        public event EventHandler<string> Event;

        public void Subscribe()
            => Event += OnEvent;

        public void OnEvent(object sender, string s)
            => Console.WriteLine(s);
    }
}
