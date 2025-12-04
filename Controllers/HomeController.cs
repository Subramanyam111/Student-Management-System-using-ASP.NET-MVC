using System.Diagnostics;
using EntityAspMvcFirst.Models;
using Microsoft.AspNetCore.Mvc;

namespace EntityAspMvcFirst.Controllers
{
    public class HomeController : Controller
    {
        private readonly SubbudbContext context;
        public HomeController(SubbudbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult list(int? id)
        {
            List<Student> student;
            if (id != null)
            {
                student = context.Students.Where(e => e.StudentId == id).ToList();           
            }
            else
            {
                student = context.Students.ToList();
            }
            return View(student);
        }

        public IActionResult Details(int? id)
        {
            
                Student? student = context.Students.FirstOrDefault(e => e.StudentId == id);
                
                 return View(student);           
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student stu)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    context.Students.Add(stu);
                    context.SaveChanges();
                    TempData["insert"] = "Student created successfully";
                    return RedirectToAction("list");
                }
                catch (Exception)
                {
                    TempData["createerror"] = "provide a valid data.....";
                    return View();
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            
                Student? student = context.Students.FirstOrDefault(e => e.StudentId == id);

                return View(student);                                          
            
        }

        [HttpPost]
        public IActionResult Edit(Student stu)
        {
            if (ModelState.IsValid)
            {
                
                    context.Students.Update(stu);
                    context.SaveChanges();
                    TempData["insert"] = "Student successfully Updated.....";
                    return RedirectToAction("list");
                
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {          
              Student? student = context.Students.FirstOrDefault(e => e.StudentId == id);
                
              return View(student);              
        }

        // POST handler changed: accept id, load entity, delete.
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var student = context.Students.Find(id);
            if (student == null)
            {
                TempData["message"] = id + " student not found";
                return RedirectToAction("list");
            }

            context.Students.Remove(student);
            context.SaveChanges();

            TempData["insert"] = "Student successfully Deleted.....";
            return RedirectToAction("list");
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
