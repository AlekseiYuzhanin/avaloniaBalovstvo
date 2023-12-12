using Microsoft.EntityFrameworkCore;
 
public class ApplicationContext : DbContext
{
    public ApplicationContext() => Database.EnsureCreated();
 
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

    }
}