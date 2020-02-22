using EmployeeEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeDAL
{
    public class EmployeeRepository
    {
        public static List<Employee> employeeList = new List<Employee>();
        public IEnumerable<Employee> GetEmployeeDetails()
        {
            return employeeList;
        }
        public void AddEmployee(Employee employeeDetails)
        {
            employeeList.Add(employeeDetails);
        }
        public Employee GetEmployeeById(int EmployeeId)
        {
            return employeeList.Find(id => id.EmployeeId == EmployeeId);
        }
        public void DeleteEmployee(int EmployeeId)
        {
            Employee employeeRemove = GetEmployeeById(EmployeeId);
            if (employeeRemove != null)
                employeeList.Remove(employeeRemove);
        }
        public void UpdateEmployee(Employee employeeRemove)
        {
           
            Employee employees = GetEmployeeById(employeeRemove.EmployeeId);
            employees.EmployeeName = employeeRemove.EmployeeName;
            employees.EmployeePhoneNumber = employeeRemove.EmployeePhoneNumber;
        }
    }
}
