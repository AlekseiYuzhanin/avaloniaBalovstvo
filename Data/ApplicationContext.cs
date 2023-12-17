using Microsoft.EntityFrameworkCore;
 
public class ApplicationContext : DbContext
{
    public ApplicationContext() => Database.EnsureCreated();
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=qweasd123");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    modelBuilder.Entity<OrderDish>()
        .HasKey(od => new { od.OrderId, od.DishId });
    }

    public DbSet<Role> Roles {get;set;} = null!;
    public DbSet<User> Users {get;set;} = null!;
    public DbSet<Shift> Shift {get;set;} = null!;
    public DbSet<ShiftAssignment> ShiftAssignments {get;set;} = null!;
    public DbSet<Order> Orders {get;set;} = null!;
    public DbSet<Dish> Dishes {get;set;} = null!;
    public DbSet<OrderDish> OrderDishes {get;set;} = null!;

}