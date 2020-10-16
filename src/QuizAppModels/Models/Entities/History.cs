using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuizAppModels.Models.Entities
{
    public class History
    {
        [Key]
        public int HistoryId { get; set; }
        public int CorrectAnswer { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
