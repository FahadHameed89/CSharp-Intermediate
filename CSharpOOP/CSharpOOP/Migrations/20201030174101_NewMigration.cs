using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpOOP.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "manufacturer",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("MySql:Collation", "utf8mb4_general_ci");

            migrationBuilder.InsertData(
                table: "manufacturer",
                columns: new[] { "ID", "Name" },
                values: new object[] { -1, "Ford" });

            migrationBuilder.InsertData(
                table: "manufacturer",
                columns: new[] { "ID", "Name" },
                values: new object[] { -2, "Chevrolet" });

            migrationBuilder.InsertData(
                table: "manufacturer",
                columns: new[] { "ID", "Name" },
                values: new object[] { -3, "Dodge" });

            migrationBuilder.InsertData(
                table: "vehicle",
                columns: new[] { "ID", "Colour", "ManufacturerID", "Model", "ModelYear" },
                values: new object[,]
                {
                    { -1, "Cyan", -1, "Furiosa", 1992 },
                    { -2, "Gold", -2, "Cyro", 1993 },
                    { -3, "Silver", -3, "Capitus", 2020 },
                    { -4, "Red", -3, "Uniborn", 2021 },
                    { -5, "Black", -3, "Virgil", 2023 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "vehicle",
                keyColumn: "ID",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "vehicle",
                keyColumn: "ID",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "vehicle",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "vehicle",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "vehicle",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "manufacturer",
                keyColumn: "ID",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "manufacturer",
                keyColumn: "ID",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "manufacturer",
                keyColumn: "ID",
                keyValue: -1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "manufacturer",
                type: "varchar(30)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldNullable: true)
                .OldAnnotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:Collation", "utf8mb4_general_ci");
        }
    }
}
