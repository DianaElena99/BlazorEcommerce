﻿using BlazorEcommerce.Shared.Models;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductCategory>().HasData(
                    new ProductCategory
                    {
                        Id = 1,
                        Name = "Books",
                        URL = "books"
                    },
                    new ProductCategory
                    {
                        Id = 2,
                        Name = "Movies",
                        URL = "movies"
                    },
                    new ProductCategory
                    {
                        Id = 3,
                        Name = "Music",
                        URL = "music"
                    }
                );

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Thinking, Fast and Slow",
                Description = "Thinking, Fast and Slow is a 2011 book by psychologist Daniel Kahneman. The book's main thesis is a differentiation between two modes of thought: \"System 1\" is fast, instinctive and emotional; \"System 2\" is slower, more deliberative, and more logical.",
                ImageURL = "https://upload.wikimedia.org/wikipedia/en/c/c1/Thinking%2C_Fast_and_Slow.jpg",
                Price = 9.55m,
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Name = "Walden",
                Description = "Walden is a book by American transcendentalist writer Henry David Thoreau. The text is a reflection upon the author's simple living in natural surroundings. ",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Walden_Thoreau.jpg/640px-Walden_Thoreau.jpg",
                Price = 5.55m,
                CategoryId = 1
            },
            new Product
            {
                Id = 3,
                Name = "The Brothers Karamazov",
                Description = "Set in 19th-century Russia, The Brothers Karamazov is a passionate philosophical novel that enters deeply into questions of God, free will, and morality. ",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2d/Dostoevsky-Brothers_Karamazov.jpg/640px-Dostoevsky-Brothers_Karamazov.jpg",
                Price = 8.55m,
                CategoryId = 1
            },
            new Product
            {
                Id = 4,
                Name = "Behave",
                Description = "Behave: The Biology of Humans at Our Best and Worst is a 2017 non-fiction book by Robert Sapolsky. It describes how various biological processes influence human behavior, on scales ranging from less than a second before an action to thousands of years before.",
                ImageURL = "https://upload.wikimedia.org/wikipedia/en/8/8c/Cover_of_the_book_Behave_by_Robert_Sapolsky.jpg",
                Price = 7.55m,
                CategoryId = 1
            });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
    }
}
