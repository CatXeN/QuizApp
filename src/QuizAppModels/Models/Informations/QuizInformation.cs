using QuizAppModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizAppModels.Models.Informations
{
    public class QuizInformation
    {
        public int QuizId { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
