using System;

namespace WinFormClient.Models
{
    public class Listener
    {
        public string Name { get; }
        public int Target { get; }
        public int Counter { get; private set; }

        private static int _listenerIdCounter;
        public event Action<Listener> CounterChanged;

        public Listener()
        {
            var newListenerCounter = ++_listenerIdCounter;
            Name = $"Listener {newListenerCounter}";
            Target = newListenerCounter;
        }

        public void HandlePayload(int payload)
        {
            Console.WriteLine(payload);
            if (payload == Target)
            {
                Counter++;
                CounterChanged?.Invoke(this);
            }
        }
    }
}