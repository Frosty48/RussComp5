using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Sqlite;

/*Migrations allow us to update a deployed database that may already have data in it.
When you create your own database context class,
it is a good idea to go ahead and create your initial migration.*/

/*To make sure you have the proper stuff  ready, right click own  the file, go down to 'open terminal', and  type
'dotnet ef migrations add InitialDatabaseMigration'.  
If there's an error make sure you have it  installed globally and is updated*/
namespace Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        {

        }
    }

    public class MyBlogDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlite("Data Source = data.db");
            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}