using System.Collections.Generic;
using System.Linq;
using quiz.domain.Contracts;

namespace quiz.domain.Mediator
{
    public class MyMediator
    {
        private readonly List<IHandler> _handlers;

        public MyMediator()
        {
            _handlers = new List<IHandler>();
        }

        public void RegisterHandler(IHandler handler)
        {
            _handlers.Add(handler);
        }

        public void RegisterHandler(List<IHandler> handlers)
        {
            _handlers.AddRange(handlers);
        }

        public void Send(ICommand command)
        {
            foreach (var handler in _handlers.Where(x => x.ObservedCommands.Contains(command.GetType().Name)))
            {
                handler.Handle(command);
            }
        }
    }
}