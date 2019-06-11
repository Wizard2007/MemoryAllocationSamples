using System;

namespace MemoryAllocationSamples.Event
{
    public class EventAsPublicMethod
    {
        public delegate void EventDelegate(string val);
        public event EventDelegate Event;

        public void Subscribe()
            => Event += EventAsPublicMethod_Event;

        public void EventAsPublicMethod_Event(string s) 
            => Console.WriteLine(s);
    }
}
