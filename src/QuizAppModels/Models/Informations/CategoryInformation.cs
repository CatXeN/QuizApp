using System;

namespace QuizAppModels.Models.Informations
{
    public class CategoryInformation
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public long DoneQuizzess { get; set; }
    }
}
