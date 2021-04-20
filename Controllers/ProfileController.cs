using Microsoft.AspNetCore.Mvc;
using MockSocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MockSocialMedia.Controllers
{
    public class ProfileController : Controller
    {
        private readonly MockSocialMediaContext _context;

        public ProfileController(MockSocialMediaContext context)
        {
            _context = context;
        }

        //Index view will show other users the current user is following
        public IActionResult Index()
        {
            //Gets a list of all FollowedUser objects in DB created by the logged-in user
            List<FollowedUser> followedUsers = _context.FollowedUsers.Where(x => x.FollowingUser == User.FindFirst(ClaimTypes.NameIdentifier).Value).ToList();
            //Gets a list of the respective AspNetUser objects in the DB
            List<AspNetUser> followedAspNetUsers = _context.AspNetUsers.Where(x => followedUsers.Select(x => x.UserToFollow).Contains(x.Id)).ToList();

            //Converts all AspNetUsers into ProfileViewModels to prevent passing sensitive data into the view
            List<ProfileViewModel> pvms = new List<ProfileViewModel>();
            foreach(AspNetUser a in followedAspNetUsers)
            {
                ProfileViewModel pvm = new ProfileViewModel(a);
                pvms.Add(pvm);
            }

            return View(pvms);
        }

    }
}
