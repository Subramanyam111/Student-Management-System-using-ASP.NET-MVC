using EntityAspMvcFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityAspMvcFirst.Controllers
{
    public class LoginController : Controller
    {

        private readonly SubbudbContext context;
        public LoginController(SubbudbContext context)
        {
            this.context = context;
        }

        

        [HttpGet]
        public IActionResult SigninUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SigninUser(string Username, string password)
        {
            var existingUser = context.LoginUsers.FirstOrDefault(x => x.Username == Username && x.Password == password);

            if (existingUser != null)
            {             
                ViewBag.Error = "Username already exists!";
                return View();
            }

            
            LoginUser newUser = new LoginUser
            {
                Username = Username,
                Password = password
            };

            context.LoginUsers.Add(newUser);
            context.SaveChanges();

            
            return RedirectToAction("LoginUser");
        }

        [HttpGet]
        public IActionResult LoginUser()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LoginUser(LoginUser model)
        {
            if (!ModelState.IsValid)
            {
                // This makes asp-validation-for work properly
                return View(model);
            }

            try
            {
                var existingUser = context.LoginUsers
                .FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);

                if (existingUser != null)
                {
                    HttpContext.Session.SetString("role", "user");

                    HttpContext.Session.SetString("username", existingUser.Username);

                    return RedirectToAction("list", "Home");
                }
            }
            catch (Exception e)
            {
                               // Handle potential errors (e.g., database connection issues)
                ViewBag.Error = e.Message;
                return View(model);

            }

            // Login failed → show proper error without breaking the model
            ViewBag.Error = "Invalid username or password!";
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("LoginUser");
        }

    }
}
