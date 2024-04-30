using Domain.Entities;

namespace Infrastructure.SeedData
{
    public static class DBInitializerSeedData
    {
        public static void InitializeDatabase(BlogDbContext blogDbContext)
        {
            //if (blogDbContext.Blogs.Any())
            //{
            //    return;
            //}

            if (!blogDbContext.Blogs.Any())
            {
                Blog[] blogs = new Blog[]
                {
                    new() {
                        Name = "Architec",
                        Description = "The Microsoft ..."
                    },
                    new() {
                        Name = "Blazor",
                        Description = "Blazor feature ..."
                    },
                };

                _ = blogDbContext.Blogs.AddRangeAsync(blogs);
                _ = blogDbContext.SaveChanges();
            }

            if (!blogDbContext.Authors.Any())
            {
                Author[] authors = new Author[]
                {
                    new() {
                        Name = "Jhone",
                        Email = "Jhon@gmail.com"
                    },
                    new() {
                        Name = "kartik",
                        Email = "kartik@gmail.com"
                    },
                    new() {
                        Name = "Kkp",
                        Email = "Kkp@gmail.com"
                    },
                };

                _ = blogDbContext.Authors.AddRangeAsync(authors);
                _ = blogDbContext.SaveChanges();
            }
        }
    }
}
