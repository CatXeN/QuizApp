using System;
using System.Collections.Generic;
using System.Text;

namespace QuizAppModels.Models.Informations
{
    public class QuizHistoryInformation
    {
        public Guid QuizHistoryId { get; set; }
        public Guid QuizId { get; set; }
        public Guid UserId { get; set; }
        public Guid Score { get; set; }
        public Guid Date { get; set; }
    }
}
