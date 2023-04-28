using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class seedProductData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageURL", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Thinking, Fast and Slow is a 2011 book by psychologist Daniel Kahneman. The book's main thesis is a differentiation between two modes of thought: \"System 1\" is fast, instinctive and emotional; \"System 2\" is slower, more deliberative, and more logical.", "https://upload.wikimedia.org/wikipedia/en/c/c1/Thinking%2C_Fast_and_Slow.jpg", "Thinking, Fast and Slow", 9.55m },
                    { 2, "Walden is a book by American transcendentalist writer Henry David Thoreau. The text is a reflection upon the author's simple living in natural surroundings. ", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Walden_Thoreau.jpg/640px-Walden_Thoreau.jpg", "Walden", 5.55m },
                    { 3, "Set in 19th-century Russia, The Brothers Karamazov is a passionate philosophical novel that enters deeply into questions of God, free will, and morality. ", "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2d/Dostoevsky-Brothers_Karamazov.jpg/640px-Dostoevsky-Brothers_Karamazov.jpg", "The Brothers Karamazov", 8.55m },
                    { 4, "Behave: The Biology of Humans at Our Best and Worst is a 2017 non-fiction book by Robert Sapolsky. It describes how various biological processes influence human behavior, on scales ranging from less than a second before an action to thousands of years before.", "https://upload.wikimedia.org/wikipedia/en/8/8c/Cover_of_the_book_Behave_by_Robert_Sapolsky.jpg", "Behave", 7.55m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
