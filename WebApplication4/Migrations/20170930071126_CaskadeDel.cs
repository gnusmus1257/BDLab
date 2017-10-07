using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication4.Migrations
{
    public partial class CaskadeDel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Service_ServiceID",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Visitor_VisitorID",
                table: "Visit");

            migrationBuilder.AlterColumn<int>(
                name: "VisitorID",
                table: "Visit",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ServiceID",
                table: "Visit",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "ServiceViewModel",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ServiceID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceViewModel", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ServiceViewModel_Service_ServiceID",
                        column: x => x.ServiceID,
                        principalTable: "Service",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ServiceViewModel_ServiceID",
                table: "ServiceViewModel",
                column: "ServiceID");

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Service_ServiceID",
                table: "Visit",
                column: "ServiceID",
                principalTable: "Service",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Visitor_VisitorID",
                table: "Visit",
                column: "VisitorID",
                principalTable: "Visitor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Service_ServiceID",
                table: "Visit");

            migrationBuilder.DropForeignKey(
                name: "FK_Visit_Visitor_VisitorID",
                table: "Visit");

            migrationBuilder.DropTable(
                name: "ServiceViewModel");

            migrationBuilder.AlterColumn<int>(
                name: "VisitorID",
                table: "Visit",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ServiceID",
                table: "Visit",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Service_ServiceID",
                table: "Visit",
                column: "ServiceID",
                principalTable: "Service",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Visit_Visitor_VisitorID",
                table: "Visit",
                column: "VisitorID",
                principalTable: "Visitor",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
