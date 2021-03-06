using Microsoft.EntityFrameworkCore;


namespace AppDemoMigration
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
        // Database.EnsureCreated();
 }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=userappdb;Trusted_Connection=True;");
        }
    }

}
