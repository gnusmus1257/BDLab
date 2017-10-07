using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebApplication4.Data;

namespace WebApplication4.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170928070439_CreateTables")]
    partial class CreateTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication4.Models.Service", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

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

                    b.Property<int?>("ServiceID");

                    b.Property<int?>("VisitorID");

                    b.HasKey("ID");

                    b.HasIndex("ServiceID");

                    b.HasIndex("VisitorID");

                    b.ToTable("Visit");
                });

            modelBuilder.Entity("WebApplication4.Models.Visits", b =>
                {
                    b.HasOne("WebApplication4.Models.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceID");

                    b.HasOne("WebApplication4.Models.Visitors", "Visitor")
                        .WithMany()
                        .HasForeignKey("VisitorID");
                });
        }
    }
}
