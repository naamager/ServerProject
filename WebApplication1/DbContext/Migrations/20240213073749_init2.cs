using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBContext.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Recipes_ResponseOnRecipeId",
                table: "Responses");

            migrationBuilder.RenameColumn(
                name: "ResponseOnRecipeId",
                table: "Responses",
                newName: "RecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Responses_ResponseOnRecipeId",
                table: "Responses",
                newName: "IX_Responses_RecipeId");

            migrationBuilder.RenameColumn(
                name: "TheRecipe",
                table: "Recipes",
                newName: "RecipeDescription");

            migrationBuilder.AddColumn<int>(
                name: "AnswerOnResponse",
                table: "Responses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ingredients",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Pictures",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Preparation",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "UploadDate",
                table: "Recipes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Recipes_RecipeId",
                table: "Responses",
                column: "RecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Responses_Recipes_RecipeId",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "AnswerOnResponse",
                table: "Responses");

            migrationBuilder.DropColumn(
                name: "Ingredients",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Pictures",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "Preparation",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "UploadDate",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "RecipeId",
                table: "Responses",
                newName: "ResponseOnRecipeId");

            migrationBuilder.RenameIndex(
                name: "IX_Responses_RecipeId",
                table: "Responses",
                newName: "IX_Responses_ResponseOnRecipeId");

            migrationBuilder.RenameColumn(
                name: "RecipeDescription",
                table: "Recipes",
                newName: "TheRecipe");

            migrationBuilder.AddForeignKey(
                name: "FK_Responses_Recipes_ResponseOnRecipeId",
                table: "Responses",
                column: "ResponseOnRecipeId",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
