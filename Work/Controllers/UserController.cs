using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Work.Models;
using Work.Models.Data;

namespace Work.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private WorkContext _db;

        public readonly IHostEnvironment _environment;
        public IActionResult Index(string? userId )
        {
            if (userId == null)
            {
                userId = _userManager.GetUserId(User);
            }
            User user = _db.Users.FirstOrDefault(u => u.Id == userId);
       
        
            return View(user);
        }
    }
}