using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication4.Migrations
{
    public partial class AddCascade : Migration
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
