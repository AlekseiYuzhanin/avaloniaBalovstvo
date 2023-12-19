﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyAppAvalonia.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231219104227_AddProfilePictureToUser")]
    partial class AddProfilePictureToUser
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            OrderTime = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2055),
                            Payed = false,
                            ShiftId = 1
                        },
                        new
                        {
                            OrderId = 2,
                            ClientName = "Client 2",
                            OrderTime = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2057),
                            Payed = true,
                            ShiftId = 2
                        },
                        new
                        {
                            OrderId = 3,
                            ClientName = "Client 3",
                            OrderTime = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2058),
                            Payed = true,
                            ShiftId = 3
                        },
                        new
                        {
                            OrderId = 4,
                            ClientName = "Client 4",
                            OrderTime = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2059),
                            Payed = true,
                            ShiftId = 4
                        },
                        new
                        {
                            OrderId = 5,
                            ClientName = "Client 5",
                            OrderTime = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2059),
                            Payed = true,
                            ShiftId = 1
                        },
                        new
                        {
                            OrderId = 6,
                            ClientName = "Client 6",
                            OrderTime = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2060),
                            Payed = true,
                            ShiftId = 2
                        },
                        new
                        {
                            OrderId = 7,
                            ClientName = "Client 7",
                            OrderTime = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2061),
                            Payed = true,
                            ShiftId = 3
                        },
                        new
                        {
                            OrderId = 8,
                            ClientName = "Client 8",
                            OrderTime = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2062),
                            Payed = true,
                            ShiftId = 4
                        },
                        new
                        {
                            OrderId = 9,
                            ClientName = "Client 9",
                            OrderTime = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2063),
                            Payed = false,
                            ShiftId = 5
                        },
                        new
                        {
                            OrderId = 10,
                            ClientName = "Client 10",
                            OrderTime = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2063),
                            Payed = false,
                            ShiftId = 6
                        });
                });

            modelBuilder.Entity("OrderDish", b =>
                {
                    b.Property<int>("OrderDishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderDishId"));

                    b.Property<int>("DishId")
                        .HasColumnType("integer");

                    b.Property<int>("DishStatusId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.HasKey("OrderDishId");

                    b.HasIndex("DishId");

                    b.HasIndex("DishStatusId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDishes");

                    b.HasData(
                        new
                        {
                            OrderDishId = 1,
                            DishId = 1,
                            DishStatusId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            OrderDishId = 2,
                            DishId = 2,
                            DishStatusId = 1,
                            OrderId = 2
                        },
                        new
                        {
                            OrderDishId = 3,
                            DishId = 3,
                            DishStatusId = 1,
                            OrderId = 3
                        },
                        new
                        {
                            OrderDishId = 4,
                            DishId = 4,
                            DishStatusId = 1,
                            OrderId = 4
                        },
                        new
                        {
                            OrderDishId = 5,
                            DishId = 5,
                            DishStatusId = 1,
                            OrderId = 5
                        },
                        new
                        {
                            OrderDishId = 6,
                            DishId = 6,
                            DishStatusId = 1,
                            OrderId = 6
                        },
                        new
                        {
                            OrderDishId = 7,
                            DishId = 7,
                            DishStatusId = 1,
                            OrderId = 7
                        },
                        new
                        {
                            OrderDishId = 8,
                            DishId = 8,
                            DishStatusId = 1,
                            OrderId = 8
                        },
                        new
                        {
                            OrderDishId = 9,
                            DishId = 9,
                            DishStatusId = 1,
                            OrderId = 9
                        },
                        new
                        {
                            OrderDishId = 10,
                            DishId = 10,
                            DishStatusId = 1,
                            OrderId = 10
                        },
                        new
                        {
                            OrderDishId = 11,
                            DishId = 1,
                            DishStatusId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            OrderDishId = 12,
                            DishId = 2,
                            DishStatusId = 1,
                            OrderId = 2
                        },
                        new
                        {
                            OrderDishId = 13,
                            DishId = 3,
                            DishStatusId = 1,
                            OrderId = 3
                        },
                        new
                        {
                            OrderDishId = 14,
                            DishId = 4,
                            DishStatusId = 1,
                            OrderId = 4
                        },
                        new
                        {
                            OrderDishId = 15,
                            DishId = 5,
                            DishStatusId = 1,
                            OrderId = 5
                        },
                        new
                        {
                            OrderDishId = 16,
                            DishId = 6,
                            DishStatusId = 1,
                            OrderId = 6
                        },
                        new
                        {
                            OrderDishId = 17,
                            DishId = 7,
                            DishStatusId = 1,
                            OrderId = 7
                        },
                        new
                        {
                            OrderDishId = 18,
                            DishId = 8,
                            DishStatusId = 1,
                            OrderId = 8
                        },
                        new
                        {
                            OrderDishId = 19,
                            DishId = 9,
                            DishStatusId = 1,
                            OrderId = 9
                        },
                        new
                        {
                            OrderDishId = 20,
                            DishId = 10,
                            DishStatusId = 1,
                            OrderId = 10
                        },
                        new
                        {
                            OrderDishId = 21,
                            DishId = 1,
                            DishStatusId = 1,
                            OrderId = 1
                        },
                        new
                        {
                            OrderDishId = 22,
                            DishId = 2,
                            DishStatusId = 1,
                            OrderId = 2
                        },
                        new
                        {
                            OrderDishId = 23,
                            DishId = 3,
                            DishStatusId = 1,
                            OrderId = 3
                        },
                        new
                        {
                            OrderDishId = 24,
                            DishId = 4,
                            DishStatusId = 1,
                            OrderId = 4
                        },
                        new
                        {
                            OrderDishId = 25,
                            DishId = 5,
                            DishStatusId = 1,
                            OrderId = 5
                        },
                        new
                        {
                            OrderDishId = 26,
                            DishId = 6,
                            DishStatusId = 1,
                            OrderId = 6
                        },
                        new
                        {
                            OrderDishId = 27,
                            DishId = 7,
                            DishStatusId = 1,
                            OrderId = 7
                        },
                        new
                        {
                            OrderDishId = 28,
                            DishId = 8,
                            DishStatusId = 1,
                            OrderId = 8
                        },
                        new
                        {
                            OrderDishId = 29,
                            DishId = 9,
                            DishStatusId = 1,
                            OrderId = 9
                        },
                        new
                        {
                            OrderDishId = 30,
                            DishId = 10,
                            DishStatusId = 1,
                            OrderId = 10
                        });
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
                            ShiftDate = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(1994),
                            ShiftTimeEnd = new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2002),
                            ShiftTimeStart = new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(1995)
                        },
                        new
                        {
                            ShiftId = 2,
                            ShiftDate = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2003),
                            ShiftTimeEnd = new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2004),
                            ShiftTimeStart = new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(2004)
                        },
                        new
                        {
                            ShiftId = 3,
                            ShiftDate = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2005),
                            ShiftTimeEnd = new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2006),
                            ShiftTimeStart = new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(2005)
                        },
                        new
                        {
                            ShiftId = 4,
                            ShiftDate = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2007),
                            ShiftTimeEnd = new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2007),
                            ShiftTimeStart = new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(2007)
                        },
                        new
                        {
                            ShiftId = 5,
                            ShiftDate = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2008),
                            ShiftTimeEnd = new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2009),
                            ShiftTimeStart = new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(2009)
                        },
                        new
                        {
                            ShiftId = 6,
                            ShiftDate = new DateTime(2023, 12, 19, 10, 42, 26, 737, DateTimeKind.Utc).AddTicks(2010),
                            ShiftTimeEnd = new DateTime(2023, 12, 19, 20, 42, 26, 737, DateTimeKind.Utc).AddTicks(2011),
                            ShiftTimeStart = new DateTime(2023, 12, 19, 14, 42, 26, 737, DateTimeKind.Utc).AddTicks(2010)
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

                    b.HasData(
                        new
                        {
                            ShiftAssignmentId = 1,
                            ShiftId = 1,
                            UserId = 2
                        },
                        new
                        {
                            ShiftAssignmentId = 2,
                            ShiftId = 2,
                            UserId = 3
                        },
                        new
                        {
                            ShiftAssignmentId = 3,
                            ShiftId = 1,
                            UserId = 4
                        },
                        new
                        {
                            ShiftAssignmentId = 4,
                            ShiftId = 2,
                            UserId = 5
                        },
                        new
                        {
                            ShiftAssignmentId = 5,
                            ShiftId = 1,
                            UserId = 6
                        },
                        new
                        {
                            ShiftAssignmentId = 6,
                            ShiftId = 2,
                            UserId = 7
                        },
                        new
                        {
                            ShiftAssignmentId = 7,
                            ShiftId = 1,
                            UserId = 2
                        },
                        new
                        {
                            ShiftAssignmentId = 8,
                            ShiftId = 2,
                            UserId = 3
                        },
                        new
                        {
                            ShiftAssignmentId = 9,
                            ShiftId = 2,
                            UserId = 4
                        },
                        new
                        {
                            ShiftAssignmentId = 10,
                            ShiftId = 1,
                            UserId = 5
                        },
                        new
                        {
                            ShiftAssignmentId = 11,
                            ShiftId = 2,
                            UserId = 6
                        },
                        new
                        {
                            ShiftAssignmentId = 12,
                            ShiftId = 1,
                            UserId = 7
                        },
                        new
                        {
                            ShiftAssignmentId = 13,
                            ShiftId = 2,
                            UserId = 8
                        },
                        new
                        {
                            ShiftAssignmentId = 14,
                            ShiftId = 1,
                            UserId = 9
                        },
                        new
                        {
                            ShiftAssignmentId = 15,
                            ShiftId = 2,
                            UserId = 10
                        },
                        new
                        {
                            ShiftAssignmentId = 16,
                            ShiftId = 1,
                            UserId = 11
                        },
                        new
                        {
                            ShiftAssignmentId = 17,
                            ShiftId = 2,
                            UserId = 6
                        },
                        new
                        {
                            ShiftAssignmentId = 18,
                            ShiftId = 1,
                            UserId = 7
                        },
                        new
                        {
                            ShiftAssignmentId = 19,
                            ShiftId = 2,
                            UserId = 8
                        },
                        new
                        {
                            ShiftAssignmentId = 20,
                            ShiftId = 1,
                            UserId = 9
                        });
                });

            modelBuilder.Entity("User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<byte[]>("ContractPicture")
                        .HasColumnType("bytea");

                    b.Property<bool>("Fired")
                        .HasColumnType("boolean");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("bytea");

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
