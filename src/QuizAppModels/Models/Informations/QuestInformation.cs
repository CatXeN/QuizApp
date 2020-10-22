using QuizAppModels.Models.Entities;

namespace QuizAppModels.Models.Informations
{
    public class QuestInformation
    {
        public int QuestId { get; set; }
        public string  Content { get; set; }
        public int Time { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
    }
}