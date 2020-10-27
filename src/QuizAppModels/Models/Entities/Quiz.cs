using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuizAppModels.Models.Entities
{
    public class Quiz
    {
        [Key]
        public int QuizId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public string ImageUrl { get; set; }
        public virtual User User { get; set; }
        public int CategoryId { get; set; }
        public virtual  Category Category { get; set; }
    }
}
