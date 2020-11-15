namespace MySocialMediaApp.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    using System.Linq;

    using MySocialMediaApp.Data.Common.Repositories;
    using MySocialMediaApp.Data.Models;
    using MySocialMediaApp.Web.ViewModels.Posts;

    public class PostsService : IPostsService
    {
        private readonly IDeletableEntityRepository<Post> postsRepository;
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;

        public PostsService(
            IDeletableEntityRepository<Post> postsRepository,
            IDeletableEntityRepository<ApplicationUser> usersRepository)
        {
            this.postsRepository = postsRepository;
            this.usersRepository = usersRepository;
        }

        public async Task Create(CreatePostInputModel input, string userName)
        {
            string userId = this.usersRepository.AllAsNoTracking().FirstOrDefault(u => u.UserName == userName).Id;

            var post = new Post
            {
                Content = input.Content,
                CreatedByUserId = userId,
            };

            await this.postsRepository.AddAsync(post);
            await this.postsRepository.SaveChangesAsync();
        }
    }
}
