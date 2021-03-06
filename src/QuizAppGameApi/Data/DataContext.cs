﻿using Microsoft.EntityFrameworkCore;
using QuizAppModels.Models.Entities;

namespace QuizAppGameApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<QuizHistory> QuizHistories { get; set; }
    }
}
