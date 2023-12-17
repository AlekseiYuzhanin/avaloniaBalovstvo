using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;

public class ApplicationContext : DbContext
{
    public ApplicationContext()
    {
        Database.EnsureCreated();
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=qweasd123");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    modelBuilder.Entity<OrderDish>()
        .HasKey(od => new { od.OrderId, od.DishId });

    modelBuilder.Entity<Role>().HasData(
        new {RoleId = 1,RoleTitle = "Admin"},
        new {RoleId = 2, RoleTitle = "Cooker"},
        new {RoleId = 3, RoleTitle = "Waiter"}
    );

    modelBuilder.Entity<User>().HasData(
        new {UserId = 1, UserName = "Tom", UserLogin = "LoginTom", UserPassword="PasswordTom", Fired= false, RoleId=1},
        new {UserId = 2, UserName = "John", UserLogin = "JohnTom", UserPassword="PasswordJohn", Fired= false, RoleId=2},
        new {UserId = 3, UserName = "Peter", UserLogin = "LoginPeter", UserPassword="PasswordPeter", Fired= false, RoleId=2},
        new {UserId = 4, UserName = "Sam", UserLogin = "LoginSam", UserPassword="PasswordSam", Fired= false, RoleId=2},
        new {UserId = 5, UserName = "Marry", UserLogin = "LoginMarry", UserPassword="PasswordMarry", Fired= false, RoleId=2},
        new {UserId = 6, UserName = "Sue", UserLogin = "LoginSue", UserPassword="PasswordSue", Fired= false, RoleId=2},
        new {UserId = 7, UserName = "Jessy", UserLogin = "LoginJessy", UserPassword="PasswordJessy", Fired= false, RoleId=3},
        new {UserId = 8, UserName = "Dominic", UserLogin = "LoginDominic", UserPassword="PasswordDominic", Fired= false, RoleId=3},
        new {UserId = 9, UserName = "Kennedy", UserLogin = "LoginKennedy", UserPassword="PasswordKennedy", Fired= false, RoleId=3},
        new {UserId = 10, UserName = "Vitya", UserLogin = "LoginVitya", UserPassword="PasswordVitya", Fired= false, RoleId=3},
        new {UserId = 11, UserName = "Daniel", UserLogin = "LoginDaniel", UserPassword="PasswordDaniel", Fired= true, RoleId=3}
    );

    modelBuilder.Entity<Shift>().HasData(
        new { ShiftId = 1, ShiftDate = DateTime.Now.Date, ShiftTimeStart = new TimeSpan(8, 0, 0), ShiftTimeEnd = new TimeSpan(16, 0, 0) },
        new  { ShiftId = 2, ShiftDate = DateTime.Now.Date, ShiftTimeStart = new TimeSpan(16, 0, 0), ShiftTimeEnd = new TimeSpan(0, 0, 0) },
        new  { ShiftId = 3, ShiftDate = DateTime.Now.Date, ShiftTimeStart = new TimeSpan(8, 0, 0), ShiftTimeEnd = new TimeSpan(16, 0, 0) },
        new  { ShiftId = 4, ShiftDate = DateTime.Now.Date, ShiftTimeStart = new TimeSpan(16, 0, 0), ShiftTimeEnd = new TimeSpan(0, 0, 0) },
        new  { ShiftId = 5, ShiftDate = DateTime.Now.Date, ShiftTimeStart = new TimeSpan(8, 0, 0), ShiftTimeEnd = new TimeSpan(16, 0, 0) },
        new  { ShiftId = 6, ShiftDate = DateTime.Now.Date, ShiftTimeStart = new TimeSpan(16, 0, 0), ShiftTimeEnd = new TimeSpan(0, 0, 0) }
    );

    modelBuilder.Entity<Dish>().HasData(
        new {DishId = 1, DishTitle = "Картошка", DishPrice = 200.00},
        new {DishId = 2, DishTitle = "Котлета", DishPrice = 200.00},
        new {DishId = 3, DishTitle = "Кола", DishPrice = 200.00},
        new {DishId = 4, DishTitle = "Квас", DishPrice = 200.00},
        new {DishId = 5, DishTitle = "Морс", DishPrice = 200.00},
        new {DishId = 6, DishTitle = "Плов", DishPrice = 200.00},
        new {DishId = 7, DishTitle = "Пицца", DishPrice = 200.00},
        new {DishId = 8, DishTitle = "Доширак", DishPrice = 200.00},
        new {DishId = 9, DishTitle = "Ролтон", DishPrice = 200.00},
        new {DishId = 10, DishTitle = "Пепси", DishPrice = 200.00}
    );
    }

    public DbSet<Role> Roles {get;set;} = null!;
    public DbSet<User> Users {get;set;} = null!;
    public DbSet<Shift> Shift {get;set;} = null!;
    public DbSet<ShiftAssignment> ShiftAssignments {get;set;} = null!;
    public DbSet<Order> Orders {get;set;} = null!;
    public DbSet<Dish> Dishes {get;set;} = null!;
    public DbSet<OrderDish> OrderDishes {get;set;} = null!;

}