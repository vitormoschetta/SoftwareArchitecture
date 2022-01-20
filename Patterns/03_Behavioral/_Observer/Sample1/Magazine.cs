using System.Collections.Generic;

namespace Sample1
{
    public class Magazine
    {
        public string Name { get; set; }
        private IList<Subscriber> subscribers;

        public Magazine(string name)
        {
            Name = name;
            subscribers = new List<Subscriber>();
        }

        public void AddSubscriber(Subscriber subscriber)
        {
            subscribers.Add(subscriber);
        }

        public void PublishEdit(string editNumber)
        {
            // persist data
            NotifySubscribers(editNumber);
        }

        private void NotifySubscribers(string editNumber)
        {
            foreach (var subscriber in subscribers)
            {
                subscriber.Notify($"Caro(a) Sr(a) {subscriber.Name}, temos uma nova edição da {this.Name} publicada: " + editNumber);
            }
        }
    }
}