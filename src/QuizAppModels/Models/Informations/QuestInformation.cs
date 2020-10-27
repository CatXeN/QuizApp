using QuizAppModels.Models.Entities;

namespace QuizAppModels.Models.Informations
{
    public class QuestInformation
    {
        public int QuestId { get; set; }
        public string  Content { get; set; }
        public int Time { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public int CorrectAnswer { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }
}