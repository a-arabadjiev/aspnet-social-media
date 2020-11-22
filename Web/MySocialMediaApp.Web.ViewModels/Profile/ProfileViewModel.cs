namespace MySocialMediaApp.Web.ViewModels.Profile
{
    using System.Collections.Generic;

    using MySocialMediaApp.Web.ViewModels.Posts;

    public class ProfileViewModel
    {
        public string Username { get; set; }

        public ICollection<PostViewModel> Posts { get; set; }
    }
}
