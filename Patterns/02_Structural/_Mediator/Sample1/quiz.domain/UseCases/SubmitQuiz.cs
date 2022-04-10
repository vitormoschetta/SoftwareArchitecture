using quiz.domain.Contracts;
using quiz.domain.Mediator;

namespace quiz.domain.UseCases
{
    public class SubmitQuiz
    {
        private readonly MyMediator _mediator;

        public SubmitQuiz(MyMediator mediator)
        {
            _mediator = mediator;
        }

        public void Execute(ICommand command)
        {
            _mediator.Send(command);
        }
    }
}