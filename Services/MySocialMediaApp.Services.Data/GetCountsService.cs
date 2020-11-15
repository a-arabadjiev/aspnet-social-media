namespace MySocialMediaApp.Services.Data
{
    using System.Linq;

    using MySocialMediaApp.Data.Common.Repositories;
    using MySocialMediaApp.Data.Models;
    using MySocialMediaApp.Web.ViewModels.Home;

    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<ApplicationUser> usersRepository;
        private readonly IDeletableEntityRepository<Post> postsRepository;
        private readonly IDeletableEntityRepository<Image> imagesRepository;

        public GetCountsService(
            IDeletableEntityRepository<ApplicationUser> usersRepository,
            IDeletableEntityRepository<Post> postsRepository,
            IDeletableEntityRepository<Image> imagesRepository)
        {
            this.usersRepository = usersRepository;
            this.postsRepository = postsRepository;
            this.imagesRepository = imagesRepository;
        }

        public IndexViewModel GetCounts()
        {
            var viewmodel = new IndexViewModel
            {
                UsersCount = this.usersRepository.All().Count(),
                PostsCount = this.postsRepository.All().Count(),
                ImagesCount = this.imagesRepository.All().Count(),
            };

            return viewmodel;
        }
    }
}
