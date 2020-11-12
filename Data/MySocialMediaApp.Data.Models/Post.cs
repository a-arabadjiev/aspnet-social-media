namespace MySocialMediaApp.Data.Models
{
    using System.Collections.Generic;

    using MySocialMediaApp.Data.Common.Models;

    public class Post : BaseDeletableModel<int>
    {
        public Post()
        {
            this.Comments = new HashSet<Comment>();
        }

        public string Content { get; set; }

        public int Likes { get; set; }

        public virtual ApplicationUser CreatedByUser { get; set; }

        public string CreatedByUserId { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
