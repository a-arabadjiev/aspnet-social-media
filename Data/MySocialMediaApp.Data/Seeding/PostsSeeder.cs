namespace MySocialMediaApp.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore.Internal;
    using MySocialMediaApp.Data.Models;

    public class PostsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Posts.Any())
            {
                return;
            }

            //dbContext.Posts.Add(new Post { Content = "Random post" , })
        }
    }
}
