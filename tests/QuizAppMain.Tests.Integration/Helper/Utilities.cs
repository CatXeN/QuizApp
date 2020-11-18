using Microsoft.EntityFrameworkCore;
using QuizAppModels.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuizAppMain.Tests.Integration.Helper
{
    public static class Utilities
    {
        public static void InitDb(DbContext db)
        {
            db.Add(new Category { Name = "Example Name" });
            db.SaveChangesAsync();
        }
    }
}
