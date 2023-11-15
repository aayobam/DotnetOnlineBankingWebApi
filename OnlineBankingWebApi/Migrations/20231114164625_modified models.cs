using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineBankingWebApi.Migrations
{
    /// <inheritdoc />
    public partial class modifiedmodels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ExpiryPeriod",
                table: "VerificationOtps",
                newName: "Expiry");

            migrationBuilder.AlterColumn<string>(
                name: "Code",
                table: "VerificationOtps",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Expiry",
                table: "VerificationOtps",
                newName: "ExpiryPeriod");

            migrationBuilder.AlterColumn<int>(
                name: "Code",
                table: "VerificationOtps",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
