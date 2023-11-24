using Microsoft.EntityFrameworkCore;
using TaskWithYou.Server.Models.Cards;

namespace TaskWithYou.Server.Data
{
    public class TaskWithYouAppDbContext :DbContext
    {
        public TaskWithYouAppDbContext(DbContextOptions<TaskWithYouAppDbContext>options) : base(options) 
        {
        }

        DbSet<CardContent> CardContents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
