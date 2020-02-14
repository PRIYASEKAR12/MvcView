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
        EmployeeRepository employee;
        public EmployeeController()
        {
            employee = new EmployeeRepository();
        }
        public ActionResult Index()
        {
            IEnumerable<Employee> employees = employee.GetEmployeeDetails();
            return View(employees);
        }
        public ActionResult IndexPassing()
        {
            IEnumerable<Employee> employees = employee.GetEmployeeDetails();
            ViewBag.employee = employees;
            ViewData["employees"] = employees;
            return View();
        }
        public ActionResult TempDataCheck()
        {
            IEnumerable<Employee> employeeDetails = employee.GetEmployeeDetails();
            TempData["employees"] = employeeDetails;
            return RedirectToAction("TempDataChecking");
        }
        public ActionResult TempDataChecking()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employeeDetails)
        {
            // if(ModelState.IsValid)
            //{
            employee.AddEmployee(employeeDetails);
            TempData["Message"] = "Employee added";
            return RedirectToAction("Index");
            //}
            //return View(packageDetails);
        }
        public ActionResult Edit(int id)
        {
            Employee pack = employee.GetEmployeeById(id);
            return View(pack);
        }
        public ActionResult Delete(int id)
        {
            employee.DeleteEmployee(id);
            TempData["Message"] = "Employee deleted";
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Update(Employee employeeDetails)
        {
            // if (ModelState.IsValid)
            //{
            employee.UpdateEmployee(employeeDetails);
            TempData["Message"] = "Employee updated";
            return RedirectToAction("Index");
            //}
            //return View("Edit",packageDetails);
        }

    }
}