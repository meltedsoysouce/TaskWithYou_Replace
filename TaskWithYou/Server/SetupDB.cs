using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.EntityFrameworkCore.Internal;
using TaskWithYou.Server.Data;
using TaskWithYou.Server.Models.Cards;

namespace TaskWithYou.Server
{
    public static class SetupDB
    {
        public static void GenerateDemoData(string connectionString)
        {
            var dbContextOptions = BuildDbContext(connectionString);
            TaskWithYouAppDbContext context = new(dbContextOptions);

            var cards = Enumerable.Range(0, 10)
                .Select(a =>
                {
                    return new CardContent()
                    {
                        Uid = Guid.NewGuid(),
                        Title = $"Generated Test #${a}",
                        CreateAt = 20230101,
                        DeadLine = null,
                        Description = "DB Setup"
                    };
                })
                .ToList();

            context.AddRange(cards);
            context.SaveChanges();
        }

        private static DbContextOptions<TaskWithYouAppDbContext> BuildDbContext(string connectionString)
        {
            DbContextOptionsBuilder<TaskWithYouAppDbContext> optionsBuilder = new();
            optionsBuilder.UseNpgsql(connectionString);
            return optionsBuilder.Options;
        }
    }
}
