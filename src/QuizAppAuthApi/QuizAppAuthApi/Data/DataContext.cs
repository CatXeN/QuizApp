using Microsoft.EntityFrameworkCore;
using QuizAppAuthApi.Models.Entities;

namespace QuizAppAuthApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
