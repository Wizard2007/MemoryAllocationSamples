using System;

namespace MemoryAllocationSamples.Event
{
    public class EventAsAnonymouseDelegate
    {
        public delegate void EventDelegate(string val);

        public event EventDelegate Event;

        public void Subscribe()
            => Event += delegate(string s) { Console.WriteLine(s); };
    }
}
