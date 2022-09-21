using System.Collections;
using System.Reflection.Metadata.Ecma335;
using EmployeeManagement.Models;
using EmployeeManagement.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EmployeeManagement.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IHostEnvironment _iHostEnvironment;
        private readonly ILogger _logger;

        public HomeController(IEmployeeRepository employeeRepository, 
            IHostEnvironment iHostEnvironment,
            ILogger<HomeController> logger)
        {
            _employeeRepository = employeeRepository;
            _iHostEnvironment = iHostEnvironment;
            _logger = logger;
        }

        [AllowAnonymous]
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);
        }

        [AllowAnonymous]
        public ViewResult Details(int? id)
        {
            //throw new Exception("Design exception");
            _logger.LogError("Log Error");
            _logger.LogWarning("Log Warning");
            _logger.LogCritical("Log Critical");
            _logger.LogDebug("Log Debug");
            _logger.LogInformation("Log Information");
            _logger.LogTrace("Log Trace");


            Employee? employee = _employeeRepository.GetEmployee(id.Value);

            if (employee == null)
            {
                Response.StatusCode = 404;
                return View("EmployeeNotFound", id.Value);
            }

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = employee,
                PageTitle = "Employee Details"
            };

            return View(homeDetailsViewModel);
        }

        [HttpGet]
        public ViewResult Create()
        { 
            return View();
        }
        
        [HttpGet]
        public ViewResult Edit(int id)
        {
            Employee employee = _employeeRepository.GetEmployee(id);
            EmployeeEditViewModel employeeEditViewModel = new EmployeeEditViewModel()
            {
                Id = employee.Id,
                Email = employee.Email,
                ExistingPhotoPath = employee.PhotoPath,
                Department = employee.Department,
                Name = employee.Name
            };
            
            return View(employeeEditViewModel);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeEditViewModel model)
        {
            if (ModelState.IsValid)
            {

                var employee = _employeeRepository.GetEmployee(model.Id);
                employee.Name = model.Name;
                employee.Email = model.Email;
                employee.Department = model.Department;

                if (model.ExistingPhotoPath != null)
                {
                    var fileName = Path.Combine(_iHostEnvironment.ContentRootPath, "wwwroot/images",
                        model.ExistingPhotoPath);
                    System.IO.File.Delete(fileName);
                }
                employee.PhotoPath = ProcessUploadFile(model);

                _employeeRepository.UpdateEmployee(employee);
                return RedirectToAction("Index");
            }

            return View(model);
        }

        [HttpPost]
        public IActionResult Create (EmployeeCreateViewModel model)
        {

            string? uniqueFileName = ProcessUploadFile(model);
            
            if (ModelState.IsValid)
            {


                Employee newEmployee = new Employee()
                {
                    Department = model.Department,
                    Name = model.Name,
                    Email = model.Email,
                    PhotoPath = uniqueFileName
                };

                _employeeRepository.AddEmployee(newEmployee);
                return RedirectToAction("Details", new { id = newEmployee.Id });
            }
            return View("Create");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            

            Employee? employee = _employeeRepository.GetEmployee(id);

            if (employee == null)
            {
                Response.StatusCode = 404;
                return View("EmployeeNotFound", id);
            }

            else
            {
                _employeeRepository.DeleteEmployee(id);
                return RedirectToAction("Index");
            }
        } 
            
            
            private string? ProcessUploadFile(EmployeeCreateViewModel model)
        {
            string uniqueFileName = null;
            {
                if (model.Photos != null && model.Photos.Count > 0)
                {
                    foreach (IFormFile photo in model.Photos)
                    {
                        string uploadsFolder = Path.Combine(_iHostEnvironment.ContentRootPath, "wwwroot/images");
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + photo.FileName;
                        string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                        photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    }
                }
            }
            return uniqueFileName;
        }

       
    }
}

