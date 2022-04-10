using System.Collections.Generic;
using quiz.domain.Command;
using quiz.domain.Command.Handlers;
using quiz.domain.Contracts;
using quiz.domain.Mediator;
using quiz.domain.Models;
using quiz.domain.UseCases;
using quiz.infrastructure.Repository;
using quiz.infrastructure.Services;
using Xunit;

namespace tests.quiz.domain
{
    public class SubmitQuizTest
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var command = new QuizSubmittedCommand()
            {
                Username = "Vitor",
                Email = "vitormoschetta@gmail.com",
                QuizId = 1,
                Answers = new List<Answer>()
                {
                    new Answer()
                    {
                        QuestionId = 1,
                        AnswerText = "Paris"
                    },
                    new Answer()
                    {
                        QuestionId = 2,
                        AnswerText = "Madrid"
                    }
                }
            };

            var mediator = new MyMediator();
            var repository = new QuizRepositoryMemory();
            var mailer = new MailerMemory();

            mediator.RegisterHandler(new List<IHandler>()
            {
                new QuizCorrectorHandler(mediator, repository),
                new QuizCommunicatorHandler(mailer)
            });

            var submitQuiz = new SubmitQuiz(mediator);

            // Act
            submitQuiz.Execute(command);

            // Assert            
        }
    }
}