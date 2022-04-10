using System;
using System.Collections.Generic;
using System.Linq;
using quiz.domain.Contracts;
using quiz.domain.Mediator;

namespace quiz.domain.Command.Handlers
{
    public class QuizCorrectorHandler : IHandler
    {
        private readonly MyMediator _mediator;
        private readonly IQuizRepository _quizRepository;
        IList<string> IHandler.ObservedCommands
        {
            get { return new List<string> { "QuizSubmittedCommand" }; }
            set { }
        }

        public QuizCorrectorHandler(MyMediator mediator, IQuizRepository quizRepository)
        {
            _mediator = mediator;
            _quizRepository = quizRepository;
        }

        public void Handle(ICommand command)
        {
            Console.WriteLine(GetType().Name);

            var quizSubmittedCommand = command as QuizSubmittedCommand;
            if (quizSubmittedCommand != null)
            {
                var quiz = _quizRepository.Get(quizSubmittedCommand.QuizId);

                var correctAnswers = 0;

                foreach (var question in quiz.Questions)
                {
                    var answer = quizSubmittedCommand.Answers.FirstOrDefault(x => x.QuestionId == question.Id);
                    if (answer.AnswerText == question.CorrectAnswer)
                    {
                        correctAnswers++;
                    }
                }

                var grade = (correctAnswers / quiz.Questions.Count) * 100;

                _mediator.Send(new QuizCorrectedCommand()
                {
                    Username = quizSubmittedCommand.Username,
                    Email = quizSubmittedCommand.Email,
                    Grade = grade
                });
            }
        }
    }
}