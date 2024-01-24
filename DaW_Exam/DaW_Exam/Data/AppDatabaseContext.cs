using DaW_Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace DaW_Exam.Data
{
    public class AppDatabaseContext : DbContext
    {
        public DbSet<Example> Examples { get; set; }
        public AppDatabaseContext(DbContextOptions<AppDatabaseContext> options) : base(options) { }
    }
}
