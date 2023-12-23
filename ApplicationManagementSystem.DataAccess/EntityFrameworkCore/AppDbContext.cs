using ApplicationManagementSystem.Core.DbModels;
using ApplicationManagementSystem.DataAccess.EntityFrameworkCore.Configurations;
using Microsoft.EntityFrameworkCore;

namespace ApplicationManagementSystem.DataAccess.EntityFrameworkCore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<ApplicationDocument> ApplicationDocuments { get; set; }
        public DbSet<Application> Applications { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationDocumentConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationConfiguration());

        }
    }
}
