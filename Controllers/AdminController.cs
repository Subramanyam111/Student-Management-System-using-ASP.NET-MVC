using EntityAspMvcFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace EntityAspMvcFirst.Controllers
{
    public class AdminController : Controller
    {
        private readonly SubbudbContext context;
        public AdminController(SubbudbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult AdminSignup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminSignup(Admins model)
        {
            if (!ModelState.IsValid)
            {
                // return view with validation messages
                return View(model);
            }

            // Check by username OR admin code to prevent duplicates
            var existingUser = context.Admins
                .FirstOrDefault(x => x.Username == model.Username);

            if (existingUser != null)
            {
                ViewBag.Error = "Admin already exists!";
                return View(model);
            }

            try
            {
                // Model already contains AdminCode, Username, Password
                context.Admins.Add(model);
                context.SaveChanges();

                return RedirectToAction("AdminLogin");
            }
            catch (Exception ex)
            {
                // Avoid leaking internals, but keep message for debugging
                ModelState.AddModelError("", "Unable to create admin: " + ex.Message);
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(Admins model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var existingUser = context.Admins
                .FirstOrDefault(x => x.Username == model.Username && x.Password == model.Password);

            if (existingUser != null)
            {
                HttpContext.Session.SetString("role", "admin");
                HttpContext.Session.SetString("username", existingUser.Username);
                return RedirectToAction("list", "Home");
            }

            ViewBag.Error = "Invalid username or password!";
            return View(model);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("AdminLogin");
        }
    }
}
