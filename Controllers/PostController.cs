using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MockSocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MockSocialMedia.Controllers
{
    public class PostController : Controller
    {
        private readonly MockSocialMediaContext _context;

        public PostController(MockSocialMediaContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            List<Post> userPosts = _context.Posts.Where(x => x.Poster == User.FindFirst(ClaimTypes.NameIdentifier).Value).ToList();

            return View(userPosts);
        }
    }
}
