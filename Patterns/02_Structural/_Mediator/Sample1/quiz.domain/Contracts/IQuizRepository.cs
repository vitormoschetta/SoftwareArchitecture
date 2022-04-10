using quiz.domain.Models;

namespace quiz.domain.Contracts
{
    public interface IQuizRepository
    {
        Quiz Get(int id);
    }
}