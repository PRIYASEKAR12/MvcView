using EmployeeDAL;
using EmployeeEntity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcView.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Package
        EmployeeRepository employeeRepository;
        public EmployeeController()
        {
            employeeRepository = new EmployeeRepository();
        }
        public ActionResult Index()
        {
            IEnumerable<Employee> employees = employeeRepository.GetEmployeeDetails();
            return View(employees);
        }
        public ActionResult IndexPassing()
        {
            IEnumerable<Employee> employees = employeeRepository.GetEmployeeDetails();
            ViewBag.employee = employees;
            ViewData["employees"] = employees;
            return View();
        }
        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Create")]                                     
        public ActionResult Create_Post([Bind(Exclude = "EmployeePhoneNumber")] Employee employee)
        {          
            employeeRepository.AddEmployee(employee);
            TempData["Message"] = "Employee added";
            return RedirectToAction("Index");
        }

        
        public ActionResult Edit(int id)
        {
            Employee pack = employeeRepository.GetEmployeeById(id);
            return View(pack);
        }
        public ActionResult Delete(int id)
        {
            employeeRepository.DeleteEmployee(id);
            TempData["Message"] = "Employee deleted";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update([Bind(Include = "EmployeeId,EmployeeName,Gender")] Employee employee)                           
        {
            employeeRepository.UpdateEmployee(employee);
            TempData["Message"] = "Employee updated";
            return RedirectToAction("Index");
        }

    }
}