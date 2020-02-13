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
        // GET: Employee
        public ActionResult IndexPassing()
        {
            IEnumerable<Employee> employee = EmployeeRepository.GetValue();
            ViewBag.employee = employee;
            ViewData["employee"] = employee;
            TempData["employee"] = employee;
            return View();
        }
    }
}