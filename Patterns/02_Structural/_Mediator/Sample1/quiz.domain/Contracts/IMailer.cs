namespace quiz.domain.Contracts
{
    public interface IMailer
    {
        void Send(string to, string message);
    }
}