using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplication4.Data;

namespace WebApplication4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171026090523_CreateTables")]
    partial class CreateTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication4.Models.Menu", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Category");

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<byte[]>("Photo");

                    b.Property<int>("Price");

                    b.Property<double>("Weight");

                    b.HasKey("ID");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("WebApplication4.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("FIO");

                    b.Property<int>("TableNumber");

                    b.HasKey("ID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("WebApplication4.Models.OrderContent", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<int?>("DishID");

                    b.Property<int?>("OrderID");

                    b.Property<int>("Value");

                    b.HasKey("ID");

                    b.HasIndex("DishID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderContent");
                });

            modelBuilder.Entity("WebApplication4.Models.Service", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Count");

                    b.Property<byte[]>("Photo");

                    b.Property<string>("description");

                    b.Property<string>("name");

                    b.Property<int>("value");

                    b.HasKey("ID");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("WebApplication4.Models.Visitors", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Discount");

                    b.Property<string>("FIO");

                    b.Property<int>("PhoneNumber");

                    b.HasKey("ID");

                    b.ToTable("Visitor");
                });

            modelBuilder.Entity("WebApplication4.Models.Visits", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Master");

                    b.Property<int>("ServiceID");

                    b.Property<int>("VisitorID");

                    b.HasKey("ID");

                    b.HasIndex("ServiceID");

                    b.HasIndex("VisitorID");

                    b.ToTable("Visit");
                });

            modelBuilder.Entity("WebApplication4.Models.OrderContent", b =>
                {
                    b.HasOne("WebApplication4.Models.Menu", "Dish")
                        .WithMany()
                        .HasForeignKey("DishID");

                    b.HasOne("WebApplication4.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID");
                });

            modelBuilder.Entity("WebApplication4.Models.Visits", b =>
                {
                    b.HasOne("WebApplication4.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WebApplication4.Models.Visitors", "Visitor")
                        .WithMany()
                        .HasForeignKey("VisitorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
