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
        public static List<Employee> employee = new List<Employee>();
        static EmployeeRepository()
        {
            employee.Add(new Employee("Priya", 1,6381517883));
            employee.Add(new Employee("Hari", 2,9500706230));
            employee.Add(new Employee("Madhu", 3,9865167230));
        }
        public IEnumerable<Employee> GetEmployeeDetails()
        {
            return employee;
        }
        public void AddEmployee(Employee employeeDetails)
        {
            employee.Add(employeeDetails);
        }
        public Employee GetEmployeeById(int EmployeeId)
        {
            return employee.Find(id => id.EmployeeId == EmployeeId);
        }
        public void DeleteEmployee(int EmployeeId)
        {
            Employee pack = GetEmployeeById(EmployeeId);
            if (pack != null)
                employee.Remove(pack);
        }
        public void UpdateEmployee(Employee pack)
        {
            //PackageDetails packages = package.Find(id => id.PackageId == pack.PackageId);
            Employee employees = GetEmployeeById(pack.EmployeeId);
            employees.EmployeeName = pack.EmployeeName;
            employees.EmployeePhoneNumber = pack.EmployeePhoneNumber;
        }
    }
}
