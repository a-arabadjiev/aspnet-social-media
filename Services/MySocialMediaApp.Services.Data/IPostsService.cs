namespace MySocialMediaApp.Services.Data
{
    using System.Threading.Tasks;

    using MySocialMediaApp.Web.ViewModels.Posts;

    public interface IPostsService
    {
        Task Create(CreatePostInputModel input);
    }
}
