﻿using Microsoft.EntityFrameworkCore;
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
    }
}
