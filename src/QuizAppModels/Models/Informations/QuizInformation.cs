using QuizAppModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizAppModels.Models.Informations
{
    public class QuizInformation
    {
        public Guid QuizId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Guid UserId { get; set; }
        public UserInformation User { get; set; }
        public Guid CategoryId { get; set; }
        public CategoryInformation Category { get; set; }
    }
}
