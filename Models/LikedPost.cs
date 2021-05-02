using System;
using System.Collections.Generic;

#nullable disable

namespace MockSocialMedia.Models
{
    public partial class LikedPost
    {
        public int Id { get; set; }
        public string LikingUser { get; set; }
        public int? LikedPost1 { get; set; }

        public virtual Post LikedPost1Navigation { get; set; }
        public virtual AspNetUser LikingUserNavigation { get; set; }
    }
}
