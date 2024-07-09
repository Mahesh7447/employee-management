using EmployeeManagement.Models;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IService service;

        public EmployeeController(IService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            var employees = service.getAll();
            return View(employees);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                var status=this.service.save(employee);
                if (status)
                {
                    return RedirectToAction("Index", "Employee");
                }
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            var employee = service.GetEmployee(id);
            return View(employee);
        }
        public IActionResult Update(Employee employee)
        {
            if (ModelState.IsValid)
            {   
                service.EditEmployee(employee);
                ViewBag.dis = "Record Updated";
                return RedirectToAction("Index", "Employee");
            }
            return View("Edit");
        }
        public ViewResult Details(int id)
        {
            var employee = service.GetEmployee(id);
            return View(employee);
        }

        public ViewResult Delete(int id)
        {
            var employee = service.GetEmployee(id);
            return View(employee);

        }
        public IActionResult DeleteConfirmed(int id)
        {
            var deleted= service.delete(id);
            if (deleted)
            {
                return RedirectToAction("Index", "Employee");
            }
            return RedirectToAction("Delete", "Employee");
        }
    }
}
