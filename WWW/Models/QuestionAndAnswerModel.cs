namespace WWW.Models
{
    public class QuestionAndAnswerModel
    {
        public string? Question { get; set; }
        public List<string> Answers { get; set; }
        public int CorrectAnswerIndex { get; set; }

        public QuestionAndAnswerModel()
        {
            this.Answers = new List<string>();
        }
    }
}
