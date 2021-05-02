﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MockSocialMedia.Models
{
    public partial class Post
    {
        public Post()
        {
            LikedPosts = new HashSet<LikedPost>();
        }

        public int Id { get; set; }
        public string Content { get; set; }
        public int? Likes { get; set; }
        public string Poster { get; set; }
        public DateTime? Date { get; set; }

        public virtual AspNetUser PosterNavigation { get; set; }
        public virtual ICollection<LikedPost> LikedPosts { get; set; }
    }
}
