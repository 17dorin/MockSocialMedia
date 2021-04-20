using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockSocialMedia.Models
{
    public class ProfileViewModel
    {
        public string Id { get; set; }
        public string Username { get; set; }

        public ProfileViewModel()
        {

        }

        public ProfileViewModel(AspNetUser a)
        {
            this.Id = a.Id;
            this.Username = a.NormalizedUserName;
        }
    }
}
