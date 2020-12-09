using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuizAppModels.Models.Entities
{
    public class Quest
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid QuestId { get; set; }
        public string  Description { get; set; }
        public int Time { get; set; }
        public string AnswerA { get; set; }
        public string AnswerB { get; set; }
        public string AnswerC { get; set; }
        public string AnswerD { get; set; }
        public int CorrectAnswer { get; set; }
        public string ImageUrl { get; set; }
        public Guid QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
