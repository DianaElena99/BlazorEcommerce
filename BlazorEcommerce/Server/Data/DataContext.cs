using BlazorEcommerce.Shared.Models;

namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariant>().HasKey(p => new { p.ProductId, p.ProductTypeId});

            modelBuilder.Entity<ProductType>().HasData(
                    new ProductType { Id = 1, Name = "Default" },
                    new ProductType { Id = 2, Name = "Paperback" },
                    new ProductType { Id = 3, Name = "E-Book" },
                    new ProductType { Id = 4, Name = "Audiobook" },
                    new ProductType { Id = 5, Name = "Stream" },
                    new ProductType { Id = 6, Name = "Blu-ray" },
                    new ProductType { Id = 7, Name = "VHS" },
                    new ProductType { Id = 8, Name = "Vynil" },
                    new ProductType { Id = 9, Name = "DVD" },
                    new ProductType { Id = 10, Name = "Xbox" }
                );

            modelBuilder.Entity<ProductVariant>().HasData(
                    new ProductVariant {
                        ProductId = 1,
                        ProductTypeId = 2,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 1,
                        ProductTypeId = 3,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 1,
                        ProductTypeId = 4,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 2,
                        ProductTypeId = 2,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 2,
                        ProductTypeId = 4,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 5,
                        ProductTypeId = 6,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 4,
                        ProductTypeId = 6,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 7,
                        ProductTypeId = 8,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 8,
                        ProductTypeId = 8,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 7,
                        ProductTypeId = 9,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    },
                    new ProductVariant
                    {
                        ProductId = 8,
                        ProductTypeId = 9,
                        Price = 9.99m,
                        OriginalPrice = 19.99m
                    }
                );

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
                CategoryId = 1
            },
            new Product
            {
                Id = 2,
                Name = "Walden",
                Description = "Walden is a book by American transcendentalist writer Henry David Thoreau. The text is a reflection upon the author's simple living in natural surroundings. ",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/25/Walden_Thoreau.jpg/640px-Walden_Thoreau.jpg",
                CategoryId = 1
            },
            new Product
            {
                Id = 3,
                Name = "The Brothers Karamazov",
                Description = "Set in 19th-century Russia, The Brothers Karamazov is a passionate philosophical novel that enters deeply into questions of God, free will, and morality. ",
                ImageURL = "https://upload.wikimedia.org/wikipedia/commons/thumb/2/2d/Dostoevsky-Brothers_Karamazov.jpg/640px-Dostoevsky-Brothers_Karamazov.jpg",
                CategoryId = 1
            },
            new Product
            {
                Id = 4,
                Name = "Behave",
                Description = "Behave: The Biology of Humans at Our Best and Worst is a 2017 non-fiction book by Robert Sapolsky. It describes how various biological processes influence human behavior, on scales ranging from less than a second before an action to thousands of years before.",
                ImageURL = "https://upload.wikimedia.org/wikipedia/en/8/8c/Cover_of_the_book_Behave_by_Robert_Sapolsky.jpg",
                CategoryId = 1
            },
            new Product
            {
                Id = 5,
                CategoryId = 2,
                Name = "The Matrix",
                Description = "The Matrix is a 1999 science fiction action film written and directed by the Wachowskis, and produced by Joel Silver. Starring Keanu Reeves, Laurence Fishburne, Carrie-Anne Moss, Hugo Weaving, and Joe Pantoliano, and as the first installment in the Matrix franchise, it depicts a dystopian future in which humanity is unknowingly trapped inside a simulated reality, the Matrix, which intelligent machines have created to distract humans while using their bodies as an energy source. When computer programmer Thomas Anderson, under the hacker alias \"Neo\", uncovers the truth, he \"is drawn into a rebellion against the machines\" along with other people who have been freed from the Matrix.",
                ImageURL = "https://upload.wikimedia.org/wikipedia/en/c/c1/The_Matrix_Poster.jpg",
            },
            new Product
            {
                Id = 6,
                CategoryId = 2,
                Name = "Back to the Future",
                Description = "Back to the Future is a 1985 American science fiction film directed by Robert Zemeckis. Written by Zemeckis and Bob Gale, it stars Michael J. Fox, Christopher Lloyd, Lea Thompson, Crispin Glover, and Thomas F. Wilson. Set in 1985, the story follows Marty McFly (Fox), a teenager accidentally sent back to 1955 in a time-traveling DeLorean automobile built by his eccentric scientist friend Doctor Emmett \"Doc\" Brown (Lloyd). Trapped in the past, Marty inadvertently prevents his future parents' meeting—threatening his very existence—and is forced to reconcile the pair and somehow get back to the future.",
                ImageURL = "https://upload.wikimedia.org/wikipedia/en/d/d2/Back_to_the_Future.jpg",
            },
            new Product
            {
                Id = 7,
                CategoryId = 3,
                Name = "A Night at the Opera",
                Description = "A Night at the Opera is the fourth studio album by the British rock band Queen, released on 21 November 1975 by EMI Records in the United Kingdom and by Elektra Records in the United States. Produced by Roy Thomas Baker and Queen, it was reportedly the most expensive album ever recorded at the time of its release.",
                ImageURL = "https://upload.wikimedia.org/wikipedia/en/4/4d/Queen_A_Night_At_The_Opera.png",
            },
            new Product
            {
                Id = 8,
                CategoryId = 3,
                Name = "Black Clouds & Silver Linings",
                Description = "Black Clouds & Silver Linings is the tenth studio album by American progressive metal band Dream Theater, released on June 23, 2009 through Roadrunner Records.",
                ImageURL = "https://upload.wikimedia.org/wikipedia/en/7/7d/Dream_Theater_-_Black_Clouds_%26_Silver_Linings.jpg"
            }
            );
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
