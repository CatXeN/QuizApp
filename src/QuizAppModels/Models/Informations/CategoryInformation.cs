using System;
using System.Collections.Generic;
using System.Text;

namespace QuizAppModels.Models.Informations
{
    public class CategoryInformation
    {
        public Guid CategoryId { get; set; }
        public string Name { get; set; }
        public long DoneQuizzess { get; set; }
    }
}
