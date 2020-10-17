using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace QuizAppModels.Models.Entities
{
    public class Category
    {
        [Key]
        public int CategoryId{ get; set; }
        public string Name { get; set; }
    }
}
