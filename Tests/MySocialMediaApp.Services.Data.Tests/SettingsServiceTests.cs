namespace MySocialMediaApp.Services.Data.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Moq;
    using MySocialMediaApp.Data;
    using MySocialMediaApp.Data.Common.Repositories;
    using MySocialMediaApp.Data.Models;
    using MySocialMediaApp.Data.Repositories;
    using Xunit;

    public class SettingsServiceTests
    {
        [Fact]
        public void GetCountShouldReturnCorrectNumber()
        {
            var repository = new Mock<IDeletableEntityRepository<Post>>();
            repository.Setup(r => r.All()).Returns(new List<Post>
                                                        {
                                                            new Post(),
                                                            new Post(),
                                                            new Post(),
                                                        }.AsQueryable());

            repository.Verify(x => x.All(), Times.Once);
        }

        [Fact]
        public async Task GetCountShouldReturnCorrectNumberUsingDbContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "SettingsTestDb").Options;
            using var dbContext = new ApplicationDbContext(options);
            dbContext.Posts.Add(new Post());
            dbContext.Posts.Add(new Post());
            dbContext.Posts.Add(new Post());
            await dbContext.SaveChangesAsync();

            using var repository = new EfDeletableEntityRepository<Post>(dbContext);
        }
    }
}
