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

    modelBuilder.Entity<Shift>().HasData(
        new {ShiftId = 1, ShiftDate = DateTime.UtcNow, ShiftTimeStart = DateTime.UtcNow.AddHours(4), ShiftTimeEnd = DateTime.UtcNow.AddHours(10)},
        new {ShiftId = 2, ShiftDate = DateTime.UtcNow, ShiftTimeStart = DateTime.UtcNow.AddHours(4), ShiftTimeEnd = DateTime.UtcNow.AddHours(10)},
        new {ShiftId = 3, ShiftDate = DateTime.UtcNow, ShiftTimeStart = DateTime.UtcNow.AddHours(4), ShiftTimeEnd = DateTime.UtcNow.AddHours(10)},
        new {ShiftId = 4, ShiftDate = DateTime.UtcNow, ShiftTimeStart = DateTime.UtcNow.AddHours(4), ShiftTimeEnd = DateTime.UtcNow.AddHours(10)},
        new {ShiftId = 5, ShiftDate = DateTime.UtcNow, ShiftTimeStart = DateTime.UtcNow.AddHours(4), ShiftTimeEnd = DateTime.UtcNow.AddHours(10)},
        new {ShiftId = 6, ShiftDate = DateTime.UtcNow, ShiftTimeStart = DateTime.UtcNow.AddHours(4), ShiftTimeEnd = DateTime.UtcNow.AddHours(10)}
    );

    modelBuilder.Entity<Order>().HasData(
        new {OrderId = 1, ClientName = "Client 1", Payed = false, ShiftId = 1, OrderTime = DateTime.UtcNow },
        new {OrderId = 2, ClientName = "Client 2", Payed = true, ShiftId = 2, OrderTime = DateTime.UtcNow },
        new {OrderId = 3, ClientName = "Client 3", Payed = true, ShiftId = 3, OrderTime = DateTime.UtcNow },
        new {OrderId = 4, ClientName = "Client 4", Payed = true, ShiftId = 4, OrderTime = DateTime.UtcNow },
        new {OrderId = 5, ClientName = "Client 5", Payed = true, ShiftId = 1, OrderTime = DateTime.UtcNow},
        new {OrderId = 6, ClientName = "Client 6", Payed = true, ShiftId = 2, OrderTime = DateTime.UtcNow },
        new {OrderId = 7, ClientName = "Client 7", Payed = true, ShiftId = 3, OrderTime = DateTime.UtcNow },
        new {OrderId = 8, ClientName = "Client 8", Payed = true, ShiftId = 4, OrderTime = DateTime.UtcNow },
        new {OrderId = 9, ClientName = "Client 9", Payed = false, ShiftId = 5, OrderTime = DateTime.UtcNow},
        new {OrderId = 10, ClientName = "Client 10", Payed = false, ShiftId = 6, OrderTime = DateTime.UtcNow }
    );

    modelBuilder.Entity<DishStatus>().HasData(
        new {DishStatusId = 1, DishStatusTitle="Принят"},
        new {DishStatusId = 2, DishStatusTitle="Отказ"},
        new {DishStatusId = 3, DishStatusTitle="Готовится"},
        new {DishStatusId = 4, DishStatusTitle="Приготовлен"}
    );

    modelBuilder.Entity<ShiftAssignment>().HasData(
        new {ShiftAssignmentId = 1, UserId = 2, ShiftId = 1},
        new {ShiftAssignmentId = 2, UserId = 3, ShiftId = 2},
        new {ShiftAssignmentId = 3, UserId = 4, ShiftId = 1},
        new {ShiftAssignmentId = 4, UserId = 5, ShiftId = 2},
        new {ShiftAssignmentId = 5, UserId = 6, ShiftId = 1},
        new {ShiftAssignmentId = 6, UserId = 7, ShiftId = 2},
        new {ShiftAssignmentId = 7, UserId = 2, ShiftId = 1},
        new {ShiftAssignmentId = 8, UserId = 3, ShiftId = 2},
        new {ShiftAssignmentId = 9, UserId = 4, ShiftId = 2},
        new {ShiftAssignmentId = 10, UserId = 5, ShiftId = 1},
        new {ShiftAssignmentId = 11, UserId = 6, ShiftId = 2},
        new {ShiftAssignmentId = 12, UserId = 7, ShiftId = 1},
        new {ShiftAssignmentId = 13, UserId = 8, ShiftId = 2},
        new {ShiftAssignmentId = 14, UserId = 9, ShiftId = 1},
        new {ShiftAssignmentId = 15, UserId = 10, ShiftId = 2},
        new {ShiftAssignmentId = 16, UserId = 11, ShiftId = 1},
        new {ShiftAssignmentId = 17, UserId = 6, ShiftId = 2},
        new {ShiftAssignmentId = 18, UserId = 7, ShiftId = 1},
        new {ShiftAssignmentId = 19, UserId = 8, ShiftId = 2},
        new {ShiftAssignmentId = 20, UserId = 9, ShiftId = 1}
    );

    modelBuilder.Entity<OrderDish>().HasData(
        new {DishId = 1, OrderId = 1, DishStatusId = 1},
        new {DishId = 2, OrderId = 1, DishStatusId = 1},
        new {DishId = 3, OrderId = 1, DishStatusId = 1},
        new {DishId = 4, OrderId = 1, DishStatusId = 1},
        new {DishId = 5, OrderId = 1, DishStatusId = 1},
        new {DishId = 6, OrderId = 1, DishStatusId = 1},
        new {DishId = 7, OrderId = 1, DishStatusId = 1},
        new {DishId = 8, OrderId = 1, DishStatusId = 1},
        new {DishId = 9, OrderId = 1, DishStatusId = 1},
        new {DishId = 10, OrderId = 1, DishStatusId = 1},
        new {DishId = 1, OrderId = 1, DishStatusId = 1},
        new {DishId = 2, OrderId = 1, DishStatusId = 1},
        new {DishId = 3, OrderId = 1, DishStatusId = 1},
        new {DishId = 4, OrderId = 1, DishStatusId = 1},
        new {DishId = 5, OrderId = 1, DishStatusId = 1},
        new {DishId = 6, OrderId = 1, DishStatusId = 1},
        new {DishId = 7, OrderId = 1, DishStatusId = 1},
        new {DishId = 8, OrderId = 1, DishStatusId = 1},
        new {DishId = 9, OrderId = 1, DishStatusId = 1},
        new {DishId = 10, OrderId = 1, DishStatusId = 1},
        new {DishId = 1, OrderId = 1, DishStatusId = 1},
        new {DishId = 2, OrderId = 1, DishStatusId = 1},
        new {DishId = 3, OrderId = 1, DishStatusId = 1},
        new {DishId = 4, OrderId = 1, DishStatusId = 1},
        new {DishId = 5, OrderId = 1, DishStatusId = 1},
        new {DishId = 6, OrderId = 1, DishStatusId = 1},
        new {DishId = 7, OrderId = 1, DishStatusId = 1},
        new {DishId = 8, OrderId = 1, DishStatusId = 1},
        new {DishId = 9, OrderId = 1, DishStatusId = 1},
        new {DishId = 10, OrderId = 1, DishStatusId = 1}
    );
    }

    public DbSet<Role> Roles {get;set;} = null!;
    public DbSet<User> Users {get;set;} = null!;
    public DbSet<Shift> Shift {get;set;} = null!;
    public DbSet<ShiftAssignment> ShiftAssignments {get;set;} = null!;
    public DbSet<Order> Orders {get;set;} = null!;

    public DbSet<DishStatus> DishStatuses {get;set;} = null!;
    public DbSet<Dish> Dishes {get;set;} = null!;
    public DbSet<OrderDish> OrderDishes {get;set;} = null!;

}