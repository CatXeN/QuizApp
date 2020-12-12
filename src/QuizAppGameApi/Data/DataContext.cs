using Microsoft.EntityFrameworkCore;
using QuizAppGameApi.Repositories.Quizzes;
using QuizAppModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizAppGameApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<QuizHistory> QuizHistories { get; set; }
        public DbSet<Quiz> Quizzes { get; set; } 
    }
}
