using System;
using System.Collections.Generic;

#nullable disable

namespace MockSocialMedia.Models
{
    public partial class FollowedUser
    {
        public int Id { get; set; }
        public string FollowingUser { get; set; }
        public string UserToFollow { get; set; }

        public virtual AspNetUser FollowingUserNavigation { get; set; }
        public virtual AspNetUser UserToFollowNavigation { get; set; }
    }
}
