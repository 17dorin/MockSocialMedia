using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockSocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MockSocialMedia.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly MockSocialMediaContext _context;

        public HomeController(MockSocialMediaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //Gets current user id
            string currentUser = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            //Gets a list of posts based on the users the current user is following
            List<Post> yourHomeFeed = new List<Post>();
            List<string> followedUserIds = _context.FollowedUsers.Where(x => x.FollowingUser == currentUser).Select(x => x.UserToFollow).ToList();
            yourHomeFeed = _context.Posts.Where(x => followedUserIds.Contains(x.Poster)).ToList();

            return View(yourHomeFeed);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
