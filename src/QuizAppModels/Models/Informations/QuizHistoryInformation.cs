using System;
using System.Collections.Generic;
using System.Text;

namespace QuizAppModels.Models.Informations
{
    public class QuizHistoryInformation
    {
        public int QuizHistoryId { get; set; }
        public int QuizId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public int dateTime { get; set; }
    }
}
