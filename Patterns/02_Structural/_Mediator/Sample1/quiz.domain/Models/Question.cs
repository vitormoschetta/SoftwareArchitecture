namespace quiz.domain.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string[] Answers { get; set; }
        public string CorrectAnswer { get; set; }
    }
}