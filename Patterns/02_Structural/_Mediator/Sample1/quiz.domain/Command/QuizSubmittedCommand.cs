using System.Collections.Generic;
using quiz.domain.Contracts;
using quiz.domain.Models;

namespace quiz.domain.Command
{
    public class QuizSubmittedCommand : ICommand
    {
        public int QuizId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public IList<Answer> Answers { get; set; }
    }
}