using System;

namespace QuizAppModels.Models.Informations
{
    public class QuizHistoryInformation
    {
        public Guid QuizHistoryId { get; set; }
        public Guid QuizId { get; set; }
        public Guid UserId { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}
