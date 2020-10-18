﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace QuizAppModels.Models.Entities
{
    public class Quest
    {
        [Key]
        public int QuestId { get; set; }
        public string  Content { get; set; }
        public int Time { get; set; }
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}