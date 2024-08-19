using Microsoft.EntityFrameworkCore;

namespace LearningLanguageApp.Models
{
    public class LearningLanguageContext : DbContext
    {
        public LearningLanguageContext(DbContextOptions<LearningLanguageContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        // Add other DbSet properties for other models as needed
    }
}
