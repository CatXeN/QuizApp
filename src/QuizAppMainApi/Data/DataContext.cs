using Microsoft.EntityFrameworkCore;
using QuizAppModels.Models.Entities;

namespace QuizAppMainApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) {}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Quest> Quests { get; set; }
        public DbSet<Quiz> Quizzes{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<QuizHistory> QuizHistories { get; set; }
    }
}
