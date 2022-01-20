using System;

namespace Sample1
{
    public class Subscriber
    {
        public string Name { get; private set; }

        public Subscriber(Magazine magazine, string name)
        {
            magazine.AddSubscriber(this);
            Name = name;
        }

        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}