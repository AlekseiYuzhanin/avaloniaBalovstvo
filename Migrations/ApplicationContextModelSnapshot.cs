﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyAppAvalonia.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DishId"));

                    b.Property<double>("DishPrice")
                        .HasColumnType("double precision");

                    b.Property<string>("DishTitle")
                        .HasColumnType("text");

                    b.HasKey("DishId");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            DishPrice = 200.0,
                            DishTitle = "Картошка"
                        },
                        new
                        {
                            DishId = 2,
                            DishPrice = 200.0,
                            DishTitle = "Котлета"
                        },
                        new
                        {
                            DishId = 3,
                            DishPrice = 200.0,
                            DishTitle = "Кола"
                        },
                        new
                        {
                            DishId = 4,
                            DishPrice = 200.0,
                            DishTitle = "Квас"
                        },
                        new
                        {
                            DishId = 5,
                            DishPrice = 200.0,
                            DishTitle = "Морс"
                        },
                        new
                        {
                            DishId = 6,
                            DishPrice = 200.0,
                            DishTitle = "Плов"
                        },
                        new
                        {
                            DishId = 7,
                            DishPrice = 200.0,
                            DishTitle = "Пицца"
                        },
                        new
                        {
                            DishId = 8,
                            DishPrice = 200.0,
                            DishTitle = "Доширак"
                        },
                        new
                        {
                            DishId = 9,
                            DishPrice = 200.0,
                            DishTitle = "Ролтон"
                        },
                        new
                        {
                            DishId = 10,
                            DishPrice = 200.0,
                            DishTitle = "Пепси"
                        });
                });

            modelBuilder.Entity("DishStatus", b =>
                {
                    b.Property<int>("DishStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DishStatusId"));

                    b.Property<string>("StatusTitle")
                        .HasColumnType("text");

                    b.HasKey("DishStatusId");

                    b.ToTable("DishStatuses");

                    b.HasData(
                        new
                        {
                            DishStatusId = 1
                        },
                        new
                        {
                            DishStatusId = 2
                        },
                        new
                        {
                            DishStatusId = 3
                        },
                        new
                        {
                            DishStatusId = 4
                        });
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderId"));

                    b.Property<string>("ClientName")
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("Payed")
                        .HasColumnType("boolean");

                    b.Property<int>("ShiftId")
                        .HasColumnType("integer");

                    b.HasKey("OrderId");

                    b.HasIndex("ShiftId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            ClientName = "Client 1",
                            OrderTime = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3224),
                            Payed = false,
                            ShiftId = 1
                        },
                        new
                        {
                            OrderId = 2,
                            ClientName = "Client 2",
                            OrderTime = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3226),
                            Payed = true,
                            ShiftId = 2
                        },
                        new
                        {
                            OrderId = 3,
                            ClientName = "Client 3",
                            OrderTime = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3227),
                            Payed = true,
                            ShiftId = 3
                        },
                        new
                        {
                            OrderId = 4,
                            ClientName = "Client 4",
                            OrderTime = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3228),
                            Payed = true,
                            ShiftId = 4
                        },
                        new
                        {
                            OrderId = 5,
                            ClientName = "Client 5",
                            OrderTime = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3228),
                            Payed = true,
                            ShiftId = 1
                        },
                        new
                        {
                            OrderId = 6,
                            ClientName = "Client 6",
                            OrderTime = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3229),
                            Payed = true,
                            ShiftId = 2
                        },
                        new
                        {
                            OrderId = 7,
                            ClientName = "Client 7",
                            OrderTime = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3230),
                            Payed = true,
                            ShiftId = 3
                        },
                        new
                        {
                            OrderId = 8,
                            ClientName = "Client 8",
                            OrderTime = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3230),
                            Payed = true,
                            ShiftId = 4
                        },
                        new
                        {
                            OrderId = 9,
                            ClientName = "Client 9",
                            OrderTime = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3231),
                            Payed = false,
                            ShiftId = 5
                        },
                        new
                        {
                            OrderId = 10,
                            ClientName = "Client 10",
                            OrderTime = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3232),
                            Payed = false,
                            ShiftId = 6
                        });
                });

            modelBuilder.Entity("OrderDish", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("DishId")
                        .HasColumnType("integer");

                    b.Property<int>("DishStatusId")
                        .HasColumnType("integer");

                    b.HasKey("OrderId", "DishId");

                    b.HasIndex("DishId");

                    b.HasIndex("DishStatusId");

                    b.ToTable("OrderDishes");
                });

            modelBuilder.Entity("Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("RoleTitle")
                        .HasColumnType("text");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleTitle = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleTitle = "Cooker"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleTitle = "Waiter"
                        });
                });

            modelBuilder.Entity("Shift", b =>
                {
                    b.Property<int>("ShiftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ShiftId"));

                    b.Property<DateTime>("ShiftDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ShiftTimeEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ShiftTimeStart")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("ShiftId");

                    b.ToTable("Shift");

                    b.HasData(
                        new
                        {
                            ShiftId = 1,
                            ShiftDate = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3173),
                            ShiftTimeEnd = new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3179),
                            ShiftTimeStart = new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3174)
                        },
                        new
                        {
                            ShiftId = 2,
                            ShiftDate = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3181),
                            ShiftTimeEnd = new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3181),
                            ShiftTimeStart = new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3181)
                        },
                        new
                        {
                            ShiftId = 3,
                            ShiftDate = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3182),
                            ShiftTimeEnd = new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3183),
                            ShiftTimeStart = new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3182)
                        },
                        new
                        {
                            ShiftId = 4,
                            ShiftDate = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3184),
                            ShiftTimeEnd = new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3184),
                            ShiftTimeStart = new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3184)
                        },
                        new
                        {
                            ShiftId = 5,
                            ShiftDate = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3185),
                            ShiftTimeEnd = new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3186),
                            ShiftTimeStart = new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3185)
                        },
                        new
                        {
                            ShiftId = 6,
                            ShiftDate = new DateTime(2023, 12, 17, 21, 8, 26, 244, DateTimeKind.Utc).AddTicks(3187),
                            ShiftTimeEnd = new DateTime(2023, 12, 18, 7, 8, 26, 244, DateTimeKind.Utc).AddTicks(3187),
                            ShiftTimeStart = new DateTime(2023, 12, 18, 1, 8, 26, 244, DateTimeKind.Utc).AddTicks(3187)
                        });
                });

            modelBuilder.Entity("ShiftAssignment", b =>
                {
                    b.Property<int>("ShiftAssignmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ShiftAssignmentId"));

                    b.Property<int>("ShiftId")
                        .HasColumnType("integer");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("ShiftAssignmentId");

                    b.HasIndex("ShiftId");

                    b.HasIndex("UserId");

                    b.ToTable("ShiftAssignments");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<bool>("Fired")
                        .HasColumnType("boolean");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.Property<string>("UserLogin")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasColumnType("text");

                    b.Property<string>("UserPassword")
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Fired = false,
                            RoleId = 1,
                            UserLogin = "LoginTom",
                            UserName = "Tom",
                            UserPassword = "PasswordTom"
                        },
                        new
                        {
                            UserId = 2,
                            Fired = false,
                            RoleId = 2,
                            UserLogin = "JohnTom",
                            UserName = "John",
                            UserPassword = "PasswordJohn"
                        },
                        new
                        {
                            UserId = 3,
                            Fired = false,
                            RoleId = 2,
                            UserLogin = "LoginPeter",
                            UserName = "Peter",
                            UserPassword = "PasswordPeter"
                        },
                        new
                        {
                            UserId = 4,
                            Fired = false,
                            RoleId = 2,
                            UserLogin = "LoginSam",
                            UserName = "Sam",
                            UserPassword = "PasswordSam"
                        },
                        new
                        {
                            UserId = 5,
                            Fired = false,
                            RoleId = 2,
                            UserLogin = "LoginMarry",
                            UserName = "Marry",
                            UserPassword = "PasswordMarry"
                        },
                        new
                        {
                            UserId = 6,
                            Fired = false,
                            RoleId = 2,
                            UserLogin = "LoginSue",
                            UserName = "Sue",
                            UserPassword = "PasswordSue"
                        },
                        new
                        {
                            UserId = 7,
                            Fired = false,
                            RoleId = 3,
                            UserLogin = "LoginJessy",
                            UserName = "Jessy",
                            UserPassword = "PasswordJessy"
                        },
                        new
                        {
                            UserId = 8,
                            Fired = false,
                            RoleId = 3,
                            UserLogin = "LoginDominic",
                            UserName = "Dominic",
                            UserPassword = "PasswordDominic"
                        },
                        new
                        {
                            UserId = 9,
                            Fired = false,
                            RoleId = 3,
                            UserLogin = "LoginKennedy",
                            UserName = "Kennedy",
                            UserPassword = "PasswordKennedy"
                        },
                        new
                        {
                            UserId = 10,
                            Fired = false,
                            RoleId = 3,
                            UserLogin = "LoginVitya",
                            UserName = "Vitya",
                            UserPassword = "PasswordVitya"
                        },
                        new
                        {
                            UserId = 11,
                            Fired = true,
                            RoleId = 3,
                            UserLogin = "LoginDaniel",
                            UserName = "Daniel",
                            UserPassword = "PasswordDaniel"
                        });
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.HasOne("Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shift");
                });

            modelBuilder.Entity("OrderDish", b =>
                {
                    b.HasOne("Dish", "Dish")
                        .WithMany("OrderDishes")
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DishStatus", "DishStatus")
                        .WithMany()
                        .HasForeignKey("DishStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Order", "Order")
                        .WithMany("OrderDishes")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dish");

                    b.Navigation("DishStatus");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("ShiftAssignment", b =>
                {
                    b.HasOne("Shift", "Shift")
                        .WithMany()
                        .HasForeignKey("ShiftId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shift");

                    b.Navigation("User");
                });

            modelBuilder.Entity("User", b =>
                {
                    b.HasOne("Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Dish", b =>
                {
                    b.Navigation("OrderDishes");
                });

            modelBuilder.Entity("Order", b =>
                {
                    b.Navigation("OrderDishes");
                });
#pragma warning restore 612, 618
        }
    }
}
