using System;

namespace MemoryAllocationSamples.Event
{
    public class EventHandlerAsLambda
    {
        public delegate void EventDelegate(string val);
        public event EventDelegate Event;

        public void Subscribe()
            => Event += (string s) => Console.WriteLine(s);
    }
}
