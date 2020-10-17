﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using QuizAppModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppMainApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options){}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Quiz> Quizzes{ get; set; }
        public DbSet<User> Users { get; set; }
    }
}
