﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FrontoBack.Migrations
{
    public partial class AlterCheckCheckProductModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3781ccbc-ef5e-4c3f-847e-ea037e602c4d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ee055689-e60d-4267-ac6a-3fb6ebc13511", "1dd6af54-4a48-46d8-9b65-d6aaf31510c5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6e1867e-98cc-4429-8086-40bb3316d6b2", "dfbb73d5-d440-4584-82f2-ec1a1a1ec108" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6e1867e-98cc-4429-8086-40bb3316d6b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ee055689-e60d-4267-ac6a-3fb6ebc13511");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dd6af54-4a48-46d8-9b65-d6aaf31510c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfbb73d5-d440-4584-82f2-ec1a1a1ec108");

            migrationBuilder.RenameColumn(
                name: "OldPrice",
                table: "CheckProducts",
                newName: "Price");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6c5ee0b0-a38b-42de-bda0-0c69b24148d8", "6c5ee0b0-a38b-42de-bda0-0c69b24148d8", "Admin", "ADMIN" },
                    { "81953d2d-699d-45ad-8e30-34b4b3b6af2f", "81953d2d-699d-45ad-8e30-34b4b3b6af2f", "User", "USER" },
                    { "b50f6810-b074-4530-bac1-950b09be4309", "b50f6810-b074-4530-bac1-950b09be4309", "SupperAdmin", "SUPPERADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "7524d688-8c53-4ac1-bcd5-0dae4c8f7fff", 0, "3c15396a-5007-4b5e-8160-c84a50ada35a", "rft.smayilov@mail.ru", false, "RufatConputerScience", false, false, null, "RFT.SMAYILOV@MAIL.RU", "RUFAT8899", "AQAAAAEAACcQAAAAEI6nAXXd7WBtbWk7Z+GV+oE3uXzep0xc6/fOxduSEfxSV/Cwp3oCeiC+kXnN5UNYHw==", null, false, "792fa06c-d3df-47df-8b01-9653f0cbf5f9", false, "Rufat8899" },
                    { "809b0af0-0b0b-44bf-b1c9-7c17003d2901", 0, "a102a61c-88dc-4010-a508-d46160e62bd1", "rufatri@code.edu.az", true, "RufatCode", false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEF1vg3WtJsdAiXep1GzW5PmjUNbqIRx9uFJZNqsS0WIjlN4HdDosi7akl862cqjA6A==", null, false, "cf7ebac7-2a2e-48d3-be7c-0e34100392ce", false, "Rufat123" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b50f6810-b074-4530-bac1-950b09be4309", "7524d688-8c53-4ac1-bcd5-0dae4c8f7fff" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6c5ee0b0-a38b-42de-bda0-0c69b24148d8", "809b0af0-0b0b-44bf-b1c9-7c17003d2901" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81953d2d-699d-45ad-8e30-34b4b3b6af2f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b50f6810-b074-4530-bac1-950b09be4309", "7524d688-8c53-4ac1-bcd5-0dae4c8f7fff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6c5ee0b0-a38b-42de-bda0-0c69b24148d8", "809b0af0-0b0b-44bf-b1c9-7c17003d2901" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c5ee0b0-a38b-42de-bda0-0c69b24148d8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b50f6810-b074-4530-bac1-950b09be4309");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7524d688-8c53-4ac1-bcd5-0dae4c8f7fff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "809b0af0-0b0b-44bf-b1c9-7c17003d2901");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "CheckProducts",
                newName: "OldPrice");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3781ccbc-ef5e-4c3f-847e-ea037e602c4d", "3781ccbc-ef5e-4c3f-847e-ea037e602c4d", "User", "USER" },
                    { "b6e1867e-98cc-4429-8086-40bb3316d6b2", "b6e1867e-98cc-4429-8086-40bb3316d6b2", "SupperAdmin", "SUPPERADMIN" },
                    { "ee055689-e60d-4267-ac6a-3fb6ebc13511", "ee055689-e60d-4267-ac6a-3fb6ebc13511", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "IsActive", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1dd6af54-4a48-46d8-9b65-d6aaf31510c5", 0, "f4a338d3-700a-4240-be2b-06c51b3e546d", "rufatri@code.edu.az", true, "RufatCode", false, false, null, "RUFATRI@CODE.EDU.AZ", "RUFAT123", "AQAAAAEAACcQAAAAEBWK5W5drgKZaTuovosvf1JQpwB14BOpFjJ5RIInTnY1VaNrdE+ZHUzBCmRKLTjyug==", null, false, "9918a319-e4b0-4b2b-908f-123ab432be15", false, "Rufat123" },
                    { "dfbb73d5-d440-4584-82f2-ec1a1a1ec108", 0, "0f47a837-5a4d-4417-8c77-7cb20e5b53c3", "rft.smayilov@mail.ru", false, "RufatConputerScience", false, false, null, "RFT.SMAYILOV@MAIL.RU", "RUFAT8899", "AQAAAAEAACcQAAAAEEf133n7Yh1z/6+K6/jpDq24Jn1256m60IHX2FbCSREgfpCZaRm6T/GqIWLec51vQw==", null, false, "7fd355d7-98c2-4c33-9692-eb0605833120", false, "Rufat8899" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ee055689-e60d-4267-ac6a-3fb6ebc13511", "1dd6af54-4a48-46d8-9b65-d6aaf31510c5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b6e1867e-98cc-4429-8086-40bb3316d6b2", "dfbb73d5-d440-4584-82f2-ec1a1a1ec108" });
        }
    }
}
