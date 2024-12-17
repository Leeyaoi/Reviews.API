using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Reviews.API.Migrations
{
    /// <inheritdoc />
    public partial class FixModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Reviews_ReviewId",
                table: "Reviews");

            migrationBuilder.DropIndex(
                name: "IX_Reviews_ReviewId",
                table: "Reviews");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("0b80896d-963b-4b87-994f-7a5ba605c799"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("1942be3b-705b-45c4-8666-1ac57997ce97"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("3dc66893-798e-4393-b5e1-3c4b7012a4f6"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("9d6f7db3-a65b-4936-ae60-32967457bac4"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("f6feb8bf-e782-4323-96d0-38fbd7035cf6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("13d976a8-545f-4d36-be47-98dc2b852ed3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2661c629-c863-44b0-8683-71ee4d8489ef"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5417e813-dfa8-442f-ab45-6a3294c5b454"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("578cd159-5e23-4993-ae1a-bacf03ea76ac"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("7880ed85-5c93-4cab-9928-327d95262d2e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8ed12f10-e70f-470a-8bad-62901f05a8ec"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ac2bcaac-dd3c-4848-9358-3bff2137bce0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("cd644f03-10d4-4020-bc76-6e569cf5a7a3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("dbe0a322-c5a1-4af3-ac35-6d90731fe7b4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("f5e26ee3-05d4-4bac-8241-1880d8db6f78"));

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Reviews");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedAt", "FilmId", "Mark", "Text", "Type", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("30cb817f-b245-41d7-877a-9b6d996c19e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), 5, "Absolutely fantastic! A must-watch.", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d67e36c7-1d12-4583-9513-967d7d9e0784") },
                    { new Guid("3bdc8564-7886-4004-b465-ed686b62a87d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eb7c3fae-7008-43c7-bb9a-d2d37458b6e2"), 4, "Great performances and stunning visuals!", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d822e19-19c8-4b25-9e73-a33c8c53d1e8") },
                    { new Guid("70e37ddc-a8a3-4597-bbaa-218b6708df20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42d3f71b-04bc-4b16-8d7f-4955de68bd19"), 2, "I didn't enjoy it as much as I hoped.", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd22c8ef-e58c-4b79-b8e0-df707f9c793c") },
                    { new Guid("992fdd16-dda3-45c4-8411-da8c0a953bfd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), 1, "Good", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("38d0309d-c534-4cda-bcb8-0d0e1f62c3f9") },
                    { new Guid("bf448d1c-e590-4167-b4d7-9949e620149d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"), 3, "It was okay, nothing special.", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc88c297-6c3c-46af-83d6-be1ed99902b2") }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ActorId", "CreatedAt", "FilmId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("09a86ae2-4693-413a-99ad-040aef492c1c"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42d3f71b-04bc-4b16-8d7f-4955de68bd19"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20143fa0-1131-4a70-8e7a-41becc26a6e2"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2dcaafe0-7c8a-4768-a398-ce4b8bfc993d"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3133bdba-090b-45e3-b9f0-15efc7e602b1"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3c2eafd8-7188-462f-90ea-0486b4680af8"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4cfe1a20-1236-4119-8bb3-24f22bd11023"), new Guid("b645ec84-e4bf-4d4f-b6ae-372b1f12329f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("580c15bf-287f-48d6-9ca5-9af70b68de21"), new Guid("b645ec84-e4bf-4d4f-b6ae-372b1f12329f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5816fd9c-3c24-4d6c-ac91-6658074a1ce6"), new Guid("4f13e67b-285f-4e30-9a54-154fa8ea1af2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b38f1e1e-21f6-475a-95c1-1a4e517ef3e7"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eb7c3fae-7008-43c7-bb9a-d2d37458b6e2"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fa42b029-c47b-43da-946d-91f28f6d9a00"), new Guid("9802d4e7-1248-4a3c-be68-cc5196ae5a5b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("30cb817f-b245-41d7-877a-9b6d996c19e5"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("3bdc8564-7886-4004-b465-ed686b62a87d"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("70e37ddc-a8a3-4597-bbaa-218b6708df20"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("992fdd16-dda3-45c4-8411-da8c0a953bfd"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("bf448d1c-e590-4167-b4d7-9949e620149d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("09a86ae2-4693-413a-99ad-040aef492c1c"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("20143fa0-1131-4a70-8e7a-41becc26a6e2"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2dcaafe0-7c8a-4768-a398-ce4b8bfc993d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3133bdba-090b-45e3-b9f0-15efc7e602b1"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3c2eafd8-7188-462f-90ea-0486b4680af8"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("4cfe1a20-1236-4119-8bb3-24f22bd11023"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("580c15bf-287f-48d6-9ca5-9af70b68de21"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("5816fd9c-3c24-4d6c-ac91-6658074a1ce6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b38f1e1e-21f6-475a-95c1-1a4e517ef3e7"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fa42b029-c47b-43da-946d-91f28f6d9a00"));

            migrationBuilder.AddColumn<Guid>(
                name: "ReviewId",
                table: "Reviews",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedAt", "FilmId", "Mark", "ReviewId", "Text", "Type", "UpdatedAt", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b80896d-963b-4b87-994f-7a5ba605c799"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"), 3, null, "It was okay, nothing special.", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc88c297-6c3c-46af-83d6-be1ed99902b2") },
                    { new Guid("1942be3b-705b-45c4-8666-1ac57997ce97"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), 1, null, "Good", 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("38d0309d-c534-4cda-bcb8-0d0e1f62c3f9") },
                    { new Guid("3dc66893-798e-4393-b5e1-3c4b7012a4f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42d3f71b-04bc-4b16-8d7f-4955de68bd19"), 2, null, "I didn't enjoy it as much as I hoped.", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("cd22c8ef-e58c-4b79-b8e0-df707f9c793c") },
                    { new Guid("9d6f7db3-a65b-4936-ae60-32967457bac4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eb7c3fae-7008-43c7-bb9a-d2d37458b6e2"), 4, null, "Great performances and stunning visuals!", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d822e19-19c8-4b25-9e73-a33c8c53d1e8") },
                    { new Guid("f6feb8bf-e782-4323-96d0-38fbd7035cf6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), 5, null, "Absolutely fantastic! A must-watch.", 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d67e36c7-1d12-4583-9513-967d7d9e0784") }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ActorId", "CreatedAt", "FilmId", "Title", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("13d976a8-545f-4d36-be47-98dc2b852ed3"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2661c629-c863-44b0-8683-71ee4d8489ef"), new Guid("4f13e67b-285f-4e30-9a54-154fa8ea1af2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5417e813-dfa8-442f-ab45-6a3294c5b454"), new Guid("9802d4e7-1248-4a3c-be68-cc5196ae5a5b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("578cd159-5e23-4993-ae1a-bacf03ea76ac"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7880ed85-5c93-4cab-9928-327d95262d2e"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4ad3bfab-9b78-4df0-9b40-b6acb5b04d7f"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8ed12f10-e70f-470a-8bad-62901f05a8ec"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("42d3f71b-04bc-4b16-8d7f-4955de68bd19"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac2bcaac-dd3c-4848-9358-3bff2137bce0"), new Guid("b645ec84-e4bf-4d4f-b6ae-372b1f12329f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cd644f03-10d4-4020-bc76-6e569cf5a7a3"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("eb7c3fae-7008-43c7-bb9a-d2d37458b6e2"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dbe0a322-c5a1-4af3-ac35-6d90731fe7b4"), new Guid("b645ec84-e4bf-4d4f-b6ae-372b1f12329f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a6c7d04f-f6dc-4b43-8b58-b7b1d5e0816e"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5e26ee3-05d4-4bac-8241-1880d8db6f78"), new Guid("512e6c92-f3b3-43f4-bb99-085e5cf1abbf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e3c0b4e4-7768-4143-b8d9-b218e9d77444"), "1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ReviewId",
                table: "Reviews",
                column: "ReviewId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Reviews_ReviewId",
                table: "Reviews",
                column: "ReviewId",
                principalTable: "Reviews",
                principalColumn: "Id");
        }
    }
}
