using Microsoft.EntityFrameworkCore.Migrations;

namespace COV19MK.Migrations
{
    public partial class gendercorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sex",
                table: "Patients");

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Patients",
                maxLength: 50,
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Patients");

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "Patients",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);
        }
    }
}
