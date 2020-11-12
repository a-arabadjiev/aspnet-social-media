namespace MySocialMediaApp.Data.Models
{
    using System;
    using System.Collections.Generic;

    using MySocialMediaApp.Data.Common.Models;

    public class Image : BaseDeletableModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public virtual ApplicationUser AddedByUser { get; set; }

        public string AddedByUserId { get; set; }

        public virtual Post Post { get; set; }

        public int? PostId { get; set; }

        public virtual Comment Comment { get; set; }

        public int? CommentId { get; set; }

        public string Extension { get; set; }

        // The content of the image is located in the file system
    }
}
