using System;
using System.Collections.Generic;
using quiz.domain.Contracts;

namespace quiz.domain.Command.Handlers
{
    public class QuizCommunicatorHandler : IHandler
    {
        private readonly IMailer _mailer;
        IList<string> IHandler.ObservedCommands
        {
            get { return new List<string> { "QuizCorrectedCommand" }; }
            set { }
        }

        public QuizCommunicatorHandler(IMailer mailer)
        {
            _mailer = mailer;
        }

        public void Handle(ICommand command)
        {
            Console.WriteLine(GetType().Name);

            var quizCorrectedCommand = command as QuizCorrectedCommand;
            if (quizCorrectedCommand != null)
            {
                _mailer.Send(quizCorrectedCommand.Email, "Your grade is " + quizCorrectedCommand.Grade);
            }
        }
    }
}