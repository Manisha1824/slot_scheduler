using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace slot_scheduler.Migrations
{
    /// <inheritdoc />
    public partial class l : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_loginDetails_registerDetails_RegisterId",
                table: "loginDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_registerDetails",
                table: "registerDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_loginDetails",
                table: "loginDetails");

            migrationBuilder.DropIndex(
                name: "IX_loginDetails_RegisterId",
                table: "loginDetails");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "loginDetails");

            migrationBuilder.DropColumn(
                name: "RegisterId",
                table: "loginDetails");

            migrationBuilder.DropColumn(
                name: "Username",
                table: "loginDetails");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "registerDetails",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "registerDetails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "loginDetails",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_registerDetails",
                table: "registerDetails",
                column: "Email");

            migrationBuilder.AddPrimaryKey(
                name: "PK_loginDetails",
                table: "loginDetails",
                column: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_registerDetails",
                table: "registerDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_loginDetails",
                table: "loginDetails");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "loginDetails");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "registerDetails",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "registerDetails",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "loginDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0)
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "RegisterId",
                table: "loginDetails",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "loginDetails",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_registerDetails",
                table: "registerDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_loginDetails",
                table: "loginDetails",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_loginDetails_RegisterId",
                table: "loginDetails",
                column: "RegisterId");

            migrationBuilder.AddForeignKey(
                name: "FK_loginDetails_registerDetails_RegisterId",
                table: "loginDetails",
                column: "RegisterId",
                principalTable: "registerDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
