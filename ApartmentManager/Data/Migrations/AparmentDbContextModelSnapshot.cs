﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(AparmentDbContext))]
    partial class AparmentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Data.Entity.Account", b =>
                {
                    b.Property<string>("Acc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Pass")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.ToTable("Account", (string)null);
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 9, 22, 58, 19, 698, DateTimeKind.Local).AddTicks(7552));

                    b.Property<int>("TotalMoney")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDRTC");

                    b.ToTable("Bill", (string)null);
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 9, 22, 58, 19, 699, DateTimeKind.Local).AddTicks(8345));

                    b.Property<int>("IDRoom")
                        .HasColumnType("int");

                    b.Property<int>("Money")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceiveDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 9, 22, 58, 19, 699, DateTimeKind.Local).AddTicks(9152));

                    b.HasKey("ID");

                    b.HasIndex("IDRoom");

                    b.ToTable("DepositsContract", (string)null);
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
                        .HasDefaultValue(new DateTime(2023, 7, 9, 22, 58, 19, 700, DateTimeKind.Local).AddTicks(6439));

                    b.Property<int>("IDBill")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDBill");

                    b.ToTable("PaymentExtension", (string)null);
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 9, 22, 58, 19, 701, DateTimeKind.Local).AddTicks(527));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("IDCard")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("IDroom")
                        .HasColumnType("int");

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

                    b.HasIndex("IDroom");

                    b.ToTable("People", (string)null);
                });

            modelBuilder.Entity("Data.Entity.RentalContract", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("CheckOutDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 9, 22, 58, 19, 701, DateTimeKind.Local).AddTicks(5011));

                    b.Property<int>("ElectricMoney")
                        .HasMaxLength(50)
                        .HasColumnType("int");

                    b.Property<int>("IDLeader")
                        .HasColumnType("int");

                    b.Property<int>("IDroom")
                        .HasColumnType("int");

                    b.Property<int?>("PeopleID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReceiveDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2023, 7, 9, 22, 58, 19, 701, DateTimeKind.Local).AddTicks(4671));

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
                });

            modelBuilder.Entity("Data.Entity.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("IDLeader")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Room", (string)null);
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
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("IDroom");

                    b.ToTable("RoomImage", (string)null);
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
                    b.HasOne("Data.Entity.Room", "Room")
                        .WithMany("DepositsContracts")
                        .HasForeignKey("IDRoom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

            modelBuilder.Entity("Data.Entity.People", b =>
                {
                    b.HasOne("Data.Entity.Room", "Room")
                        .WithMany("People")
                        .HasForeignKey("IDroom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");
                });

            modelBuilder.Entity("Data.Entity.RentalContract", b =>
                {
                    b.HasOne("Data.Entity.Room", "Room")
                        .WithMany("RentalContracts")
                        .HasForeignKey("IDroom")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.Entity.People", null)
                        .WithMany("RentalContracts")
                        .HasForeignKey("PeopleID");

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
                    b.Navigation("RentalContracts");
                });

            modelBuilder.Entity("Data.Entity.RentalContract", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Data.Entity.Room", b =>
                {
                    b.Navigation("DepositsContracts");

                    b.Navigation("People");

                    b.Navigation("RentalContracts");

                    b.Navigation("RoomDeltails");

                    b.Navigation("RoomImage");
                });
#pragma warning restore 612, 618
        }
    }
}
