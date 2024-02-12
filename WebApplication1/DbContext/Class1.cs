using Microsoft.EntityFrameworkCore;
using Repository.Entity;
using Repository.Interface;

namespace DBContext
{
    public class Db : DbContext, IContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get ; set ; }
        public DbSet<Response> Responses { get; set; }

        public async Task  save()
        {
            await SaveChangesAsync();
            }
   
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=myDataBase;trusted_connection=true");
        }
    }
}