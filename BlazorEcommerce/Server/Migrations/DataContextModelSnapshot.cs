﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Thinking, Fast and Slow is a 2011 book by psychologist Daniel Kahneman. The book's main thesis is a differentiation between two modes of thought: \"System 1\" is fast, instinctive and emotional; \"System 2\" is slower, more deliberative, and more logical.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/c/c1/Thinking%2C_Fast_and_Slow.jpg",
                            Name = "Thinking, Fast and Slow",
                            Price = 9.55m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Walden is a book by American transcendentalist writer Henry David Thoreau. The text is a reflection upon the author's simple living in natural surroundings. ",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Walden_Thoreau.jpg/640px-Walden_Thoreau.jpg",
                            Name = "Walden",
                            Price = 5.55m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Set in 19th-century Russia, The Brothers Karamazov is a passionate philosophical novel that enters deeply into questions of God, free will, and morality. ",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2d/Dostoevsky-Brothers_Karamazov.jpg/640px-Dostoevsky-Brothers_Karamazov.jpg",
                            Name = "The Brothers Karamazov",
                            Price = 8.55m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Behave: The Biology of Humans at Our Best and Worst is a 2017 non-fiction book by Robert Sapolsky. It describes how various biological processes influence human behavior, on scales ranging from less than a second before an action to thousands of years before.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/8/8c/Cover_of_the_book_Behave_by_Robert_Sapolsky.jpg",
                            Name = "Behave",
                            Price = 7.55m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 2,
                            Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
                            Name = "The Matrix",
                            Price = 0m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
                            Name = "Back to the Future",
                            Price = 0m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "A Night at the Opera is the fourth studio album by the British rock band Queen, released on 21 November 1975 by EMI Records in the United Kingdom and by Elektra Records in the United States. Produced by Roy Thomas Baker and Queen, it was reportedly the most expensive album ever recorded at the time of its release.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/4/4d/Queen_A_Night_At_The_Opera.png",
                            Name = "A Night at the Opera",
                            Price = 0m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Black Clouds & Silver Linings is the tenth studio album by American progressive metal band Dream Theater, released on June 23, 2009 through Roadrunner Records.",
                            ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/7d/Dream_Theater_-_Black_Clouds_%26_Silver_Linings.jpg",
                            Name = "Black Clouds & Silver Linings",
                            Price = 0m
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            URL = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movies",
                            URL = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Music",
                            URL = "music"
                        });
                });

            modelBuilder.Entity("BlazorEcommerce.Shared.Models.Product", b =>
                {
                    b.HasOne("BlazorEcommerce.Shared.Models.ProductCategory", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
