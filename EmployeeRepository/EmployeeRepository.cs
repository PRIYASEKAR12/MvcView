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
            employee.Add(new Employee { EmployeeName = "Priya", EmployeeId = 2341, EmployeePhoneNumber = 9865167230 });
            employee.Add(new Employee { EmployeeName = "Hari", EmployeeId = 7865, EmployeePhoneNumber = 9500706230 });
            employee.Add(new Employee { EmployeeName = "Madhu", EmployeeId = 8765, EmployeePhoneNumber = 6381517883 });
        }
        public static IEnumerable<Employee> GetValue()
        {
            return employee;
        }
    }
}
