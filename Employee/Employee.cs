using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeEntity
{

    public class Employee
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; }
        public long EmployeePhoneNumber { get; set; }
        public short Age { get; set; }
        public string Gender { get; set;}
        public Employee(string EmployeeName,int EmployeeId,long EmployeePhoneNumber,short Age,string Gender)
        {
            this.EmployeeName = EmployeeName;
            this.EmployeeId = EmployeeId;
            this.EmployeePhoneNumber = EmployeePhoneNumber;
            this.Gender = Gender;
        }
        public Employee() { }
    }
   
}
