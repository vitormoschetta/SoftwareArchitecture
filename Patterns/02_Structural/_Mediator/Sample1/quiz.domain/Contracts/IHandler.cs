using System.Collections.Generic;

namespace quiz.domain.Contracts
{
    public interface IHandler
    {
        IList<string> ObservedCommands { get; set; }
        void Handle(ICommand command);
    }
}