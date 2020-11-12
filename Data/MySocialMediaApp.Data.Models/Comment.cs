namespace MySocialMediaApp.Data.Models
{
    using System.Collections.Generic;

    using MySocialMediaApp.Data.Common.Models;

    public class Comment : BaseDeletableModel<int>
    {
        public string Content { get; set; }

        public virtual Post Post { get; set; }

        public int PostId { get; set; }

        public int? ParentId { get; set; }

        public virtual ApplicationUser CommentedByUser { get; set; }

        public string CommentedByUserId { get; set; }
    }
}
