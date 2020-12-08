using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace QuizAppModels.Models.Entities
{
    public class QuizHistory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid QuizHistoryId { get; set; }
        public Guid QuizId { get; set; }
        public Guid UserId { get; set; }
        public Guid Score { get; set; }
        public Guid Date { get; set; }
    }
}
