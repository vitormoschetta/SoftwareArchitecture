using quiz.domain.Contracts;

namespace quiz.domain.Command
{
    public class QuizCorrectedCommand : ICommand
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public decimal Grade { get; set; }
    }
}