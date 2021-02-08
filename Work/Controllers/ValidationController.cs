using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Work.Models;
using Work.Models.Data;

namespace Work.Controllers
{
    public class ValidationController : Controller
    {
        // GET
        private WorkContext _db;
        private readonly UserManager<User> _userManager;

        public ValidationController(WorkContext db, UserManager<User> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public bool CheckEmail(string email)
        {
            return !_db.Users.Any(u => u.Email == email);
        }
    }
}