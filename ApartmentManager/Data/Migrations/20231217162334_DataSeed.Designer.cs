﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AparmentDbContext))]
    [Migration("20231217162334_DataSeed")]
    partial class DataSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Entity.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Acc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Account");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Acc = "admin",
                            Pass = "admin"
                        });
                });

            modelBuilder.Entity("Data.Entity.Bill", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Active")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("ElectricQuantity")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("IDRTC")
                        .HasColumnType("int");

                    b.Property<DateTime>("PayDate")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalMoney")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("IDRTC");

                    b.ToTable("Bill", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Active = 1,
                            ElectricQuantity = 150,
                            IDRTC = 1,
                            PayDate = new DateTime(2023, 12, 17, 23, 23, 34, 211, DateTimeKind.Local).AddTicks(6342),
                            TotalMoney = 1000000.0
                        });
                });

            modelBuilder.Entity("Data.Entity.DepositsContract", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepositsDate")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<int>("IDLeader")
                        .HasColumnType("int");

                    b.Property<int>("IDRoom")
                        .HasColumnType("int");

                    b.Property<int>("Money")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceiveDate")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("IDLeader");

                    b.HasIndex("IDRoom");

                    b.ToTable("DepositsContract", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CheckOutDate = new DateTime(2023, 12, 17, 23, 23, 34, 211, DateTimeKind.Local).AddTicks(6370),
                            DepositsDate = new DateTime(2023, 12, 17, 23, 23, 34, 211, DateTimeKind.Local).AddTicks(6368),
                            IDLeader = 1,
                            IDRoom = 1,
                            Money = 10000,
                            ReceiveDate = new DateTime(2023, 12, 17, 23, 23, 34, 211, DateTimeKind.Local).AddTicks(6369)
                        });
                });

            modelBuilder.Entity("Data.Entity.Furniture", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Furniture", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Chair"
                        });
                });

            modelBuilder.Entity("Data.Entity.PaymentExtension", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("Days")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 12, 17, 23, 23, 34, 208, DateTimeKind.Local).AddTicks(6887));

                    b.Property<int>("IDBill")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDBill");

                    b.ToTable("PaymentExtension", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Days = new DateTime(2023, 12, 17, 23, 23, 34, 211, DateTimeKind.Local).AddTicks(6393),
                            IDBill = 1
                        });
                });

            modelBuilder.Entity("Data.Entity.People", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Birthday")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IDCard")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Sex")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("ID");

                    b.ToTable("People", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Vietnam",
                            Birthday = new DateTime(2023, 12, 17, 23, 23, 34, 211, DateTimeKind.Local).AddTicks(6408),
                            Email = "thanh@gmail.com",
                            IDCard = "1234123",
                            Name = "Jonhny Deep",
                            PhoneNumber = "1234",
                            Sex = 0
                        },
                        new
                        {
                            ID = 2,
                            Address = "USA",
                            Birthday = new DateTime(1995, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "emily@gmail.com",
                            IDCard = "56781234",
                            Name = "Emily Stone",
                            PhoneNumber = "5678",
                            Sex = 0
                        },
                        new
                        {
                            ID = 3,
                            Address = "Canada",
                            Birthday = new DateTime(1996, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "robert@gmail.com",
                            IDCard = "910111213",
                            Name = "Robert Smith",
                            PhoneNumber = "91011",
                            Sex = 0
                        },
                        new
                        {
                            ID = 4,
                            Address = "Australia",
                            Birthday = new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "anna@gmail.com",
                            IDCard = "14151617",
                            Name = "Anna Johnson",
                            PhoneNumber = "1415",
                            Sex = 0
                        },
                        new
                        {
                            ID = 5,
                            Address = "UK",
                            Birthday = new DateTime(1998, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "michael@gmail.com",
                            IDCard = "18192021",
                            Name = "Michael Brown",
                            PhoneNumber = "1819",
                            Sex = 0
                        });
                });

            modelBuilder.Entity("Data.Entity.RentalContract", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Active")
                        .HasColumnType("int");

                    b.Property<DateTime>("CheckOutDate")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<int>("ElectricMoney")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("IDroom")
                        .HasColumnType("int");

                    b.Property<int?>("PeopleID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceiveDate")
                        .HasMaxLength(50)
                        .HasColumnType("datetime2");

                    b.Property<int>("RoomMoney")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("ServiceMoney")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("WaterMoney")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDroom");

                    b.HasIndex("PeopleID");

                    b.ToTable("RentalContract", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Active = 1,
                            CheckOutDate = new DateTime(2023, 12, 17, 23, 23, 34, 211, DateTimeKind.Local).AddTicks(6549),
                            ElectricMoney = 100,
                            IDroom = 1,
                            ReceiveDate = new DateTime(2023, 12, 17, 23, 23, 34, 211, DateTimeKind.Local).AddTicks(6548),
                            RoomMoney = 100,
                            ServiceMoney = 100,
                            WaterMoney = 100
                        },
                        new
                        {
                            ID = 2,
                            Active = 1,
                            CheckOutDate = new DateTime(2023, 12, 17, 23, 23, 34, 211, DateTimeKind.Local).AddTicks(6555),
                            ElectricMoney = 100,
                            IDroom = 2,
                            ReceiveDate = new DateTime(2023, 12, 17, 23, 23, 34, 211, DateTimeKind.Local).AddTicks(6554),
                            RoomMoney = 100,
                            ServiceMoney = 100,
                            WaterMoney = 100
                        });
                });

            modelBuilder.Entity("Data.Entity.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Staked")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Room", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "A201",
                            Quantity = 4,
                            Staked = 0
                        },
                        new
                        {
                            ID = 2,
                            Name = "A202",
                            Quantity = 5,
                            Staked = 0
                        },
                        new
                        {
                            ID = 3,
                            Name = "A203",
                            Quantity = 3,
                            Staked = 0
                        },
                        new
                        {
                            ID = 4,
                            Name = "A240",
                            Quantity = 3,
                            Staked = 0
                        });
                });

            modelBuilder.Entity("Data.Entity.RoomImage", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("IDroom")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("ID");

                    b.HasIndex("IDroom");

                    b.ToTable("RoomImage", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IDroom = 1,
                            Name = "A1 Image",
                            Url = "D:jett.png"
                        },
                        new
                        {
                            ID = 2,
                            IDroom = 1,
                            Name = "A2 Image",
                            Url = "D:home.png"
                        });
                });

            modelBuilder.Entity("Data.Entity.Statistics", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("ElectricMoneyOfGovernment")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("Month")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("ServiceOfGovernment")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("WaterMoneyOfGovernment")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Statistics", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            ElectricMoneyOfGovernment = 90,
                            Month = 10,
                            ServiceOfGovernment = 90,
                            WaterMoneyOfGovernment = 90,
                            Year = 2023
                        });
                });

            modelBuilder.Entity("Data.Relationships.PeopleRental", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("IDPeople")
                        .HasColumnType("int");

                    b.Property<int>("IDRental")
                        .HasColumnType("int");

                    b.Property<int>("Membership")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDPeople");

                    b.HasIndex("IDRental");

                    b.ToTable("PeopleRental", (string)null);

                    b.HasData(
                        new
                        {
                            ID = 1,
                            IDPeople = 2,
                            IDRental = 1,
                            Membership = 0
                        },
                        new
                        {
                            ID = 2,
                            IDPeople = 3,
                            IDRental = 1,
                            Membership = 1
                        },
                        new
                        {
                            ID = 3,
                            IDPeople = 4,
                            IDRental = 1,
                            Membership = 1
                        },
                        new
                        {
                            ID = 4,
                            IDPeople = 5,
                            IDRental = 2,
                            Membership = 0
                        });
                });

            modelBuilder.Entity("Data.Relationships.RoomDetails", b =>
                {
                    b.Property<int>("IDFur")
                        .HasColumnType("int");

                    b.Property<int>("IDRoom")
                        .HasColumnType("int");

                    b.HasKey("IDFur", "IDRoom");

                    b.HasIndex("IDRoom");

                    b.ToTable("RoomDetails", (string)null);
                });

            modelBuilder.Entity("Data.Entity.Bill", b =>
                {
                    b.HasOne("Data.Entity.RentalContract", "RentalContract")
                        .WithMany("Bills")
                        .HasForeignKey("IDRTC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RentalContract");
                });

            modelBuilder.Entity("Data.Entity.DepositsContract", b =>
                {
                    b.HasOne("Data.Entity.People", "People")
                        .WithMany("DepositsContracts")
                        .HasForeignKey("IDLeader")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entity.Room", "Room")
                        .WithMany("DepositsContracts")
                        .HasForeignKey("IDRoom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("People");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Data.Entity.PaymentExtension", b =>
                {
                    b.HasOne("Data.Entity.Bill", "Bill")
                        .WithMany("PaymentExtensions")
                        .HasForeignKey("IDBill")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bill");
                });

            modelBuilder.Entity("Data.Entity.RentalContract", b =>
                {
                    b.HasOne("Data.Entity.Room", "Room")
                        .WithMany("RentalContracts")
                        .HasForeignKey("IDroom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entity.People", "People")
                        .WithMany("RentalContracts")
                        .HasForeignKey("PeopleID");

                    b.Navigation("People");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Data.Entity.RoomImage", b =>
                {
                    b.HasOne("Data.Entity.Room", "Room")
                        .WithMany("RoomImage")
                        .HasForeignKey("IDroom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Data.Relationships.PeopleRental", b =>
                {
                    b.HasOne("Data.Entity.People", "People")
                        .WithMany("PeopleRental")
                        .HasForeignKey("IDPeople")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entity.RentalContract", "RentalContract")
                        .WithMany("PeopleRental")
                        .HasForeignKey("IDRental")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("People");

                    b.Navigation("RentalContract");
                });

            modelBuilder.Entity("Data.Relationships.RoomDetails", b =>
                {
                    b.HasOne("Data.Entity.Furniture", "Furniture")
                        .WithMany("RoomDeltails")
                        .HasForeignKey("IDFur")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entity.Room", "Room")
                        .WithMany("RoomDeltails")
                        .HasForeignKey("IDRoom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Furniture");

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Data.Entity.Bill", b =>
                {
                    b.Navigation("PaymentExtensions");
                });

            modelBuilder.Entity("Data.Entity.Furniture", b =>
                {
                    b.Navigation("RoomDeltails");
                });

            modelBuilder.Entity("Data.Entity.People", b =>
                {
                    b.Navigation("DepositsContracts");

                    b.Navigation("PeopleRental");

                    b.Navigation("RentalContracts");
                });

            modelBuilder.Entity("Data.Entity.RentalContract", b =>
                {
                    b.Navigation("Bills");

                    b.Navigation("PeopleRental");
                });

            modelBuilder.Entity("Data.Entity.Room", b =>
                {
                    b.Navigation("DepositsContracts");

                    b.Navigation("RentalContracts");

                    b.Navigation("RoomDeltails");

                    b.Navigation("RoomImage");
                });
#pragma warning restore 612, 618
        }
    }
}
