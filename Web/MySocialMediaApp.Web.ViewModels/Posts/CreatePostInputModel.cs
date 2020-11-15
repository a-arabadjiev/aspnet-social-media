namespace MySocialMediaApp.Web.ViewModels.Posts
{
    using System.ComponentModel.DataAnnotations;

    public class CreatePostInputModel
    {
        [Required]
        [MaxLength(100)]
        public string Content { get; set; }

        public string CreatedByUserId { get; set; }
    }
}
