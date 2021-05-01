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
    [Authorize]
    public class PostController : Controller
    {
        private readonly MockSocialMediaContext _context;

        public PostController(MockSocialMediaContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Post> userPosts = _context.Posts.Where(x => x.Poster == User.FindFirst(ClaimTypes.NameIdentifier).Value).ToList();

            return View(userPosts);
        }

        public IActionResult CreatePost()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePost(string Content)
        {
            Post p = new Post();
            p.Content = Content;
            p.Likes = 0;
            p.Poster = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            p.Date = DateTime.Now;

            _context.Posts.Add(p);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        public IActionResult ConfirmDeletePost(int postToDelete)
        {
            Post p = (Post) _context.Posts.Where(x => x.Id == postToDelete).FirstOrDefault();
            return View(p);
        }

        public async Task<IActionResult> DeletePost(int postToDelete)
        {
            Post p = (Post) _context.Posts.Where(x => x.Id == postToDelete).FirstOrDefault();
            _context.Posts.Remove(p);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
