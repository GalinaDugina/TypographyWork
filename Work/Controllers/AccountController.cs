using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Work.Models;
using Work.ViewModels;

namespace Work.Controllers
{
    public class AccountController : Controller
    {
        // GET
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public readonly IHostEnvironment _environment;
       // private FileUploadService _fileUpload;
        //private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IHostEnvironment environment, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _environment = environment;
            //_roleManager = roleManager;
        }

        // GET
          [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
               User user = new User
                {
                   UserName = model.Email,
                    Email = model.Email,
                };
                var result = await _userManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                   // IdentityRole role = await _roleManager.FindByNameAsync(model.Role) ;
                    //await _userManager.AddToRoleAsync(user, role.Name);
                   
                    await _signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "User");
                }

                foreach (var error in result.Errors)
                    ModelState.AddModelError(string.Empty, error.Description);
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            return View(new LoginViewModel {ReturnUrl = returnUrl});
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = new User();
                user = await _userManager.FindByNameAsync(model.Login);
               if (user != null)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(
                        user,
                        model.Password,
                        model.RememberMe,
                        true
                    );
                    if (result.Succeeded)
                    {
                        if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                        {
                            return Redirect(model.ReturnUrl);
                        }

                        return RedirectToAction("Index", "User");
                    }
                }

                ModelState.AddModelError("", "Неправильный логин и (или) пароль");
            }

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
      
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }

    }
