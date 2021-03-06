using System;
using System.Collections.Generic;

#nullable disable

namespace MockSocialMedia.Models
{
    public partial class AspNetUser
    {
        public AspNetUser()
        {
            AspNetUserClaims = new HashSet<AspNetUserClaim>();
            AspNetUserLogins = new HashSet<AspNetUserLogin>();
            AspNetUserRoles = new HashSet<AspNetUserRole>();
            AspNetUserTokens = new HashSet<AspNetUserToken>();
            FollowedUserFollowingUserNavigations = new HashSet<FollowedUser>();
            FollowedUserUserToFollowNavigations = new HashSet<FollowedUser>();
            LikedPosts = new HashSet<LikedPost>();
            Posts = new HashSet<Post>();
        }

        public string Id { get; set; }
        public string UserName { get; set; }
        public string NormalizedUserName { get; set; }
        public string Email { get; set; }
        public string NormalizedEmail { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string ConcurrencyStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTimeOffset? LockoutEnd { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }

        public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual ICollection<AspNetUserRole> AspNetUserRoles { get; set; }
        public virtual ICollection<AspNetUserToken> AspNetUserTokens { get; set; }
        public virtual ICollection<FollowedUser> FollowedUserFollowingUserNavigations { get; set; }
        public virtual ICollection<FollowedUser> FollowedUserUserToFollowNavigations { get; set; }
        public virtual ICollection<LikedPost> LikedPosts { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
