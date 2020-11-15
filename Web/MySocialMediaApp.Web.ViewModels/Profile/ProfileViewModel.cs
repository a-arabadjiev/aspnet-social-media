using MySocialMediaApp.Web.ViewModels.Posts;
using System.Collections.Generic;

namespace MySocialMediaApp.Web.ViewModels.Profile
{
    public class ProfileViewModel
    {
        public string Username { get; set; }

        public ICollection<PostViewModel> Posts { get; set; }
    }
}
