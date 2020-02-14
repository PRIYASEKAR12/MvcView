﻿using System;
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
        public Employee(string EmployeeName,int EmployeeId,long EmployeePhoneNumber)
        {
            this.EmployeeName = EmployeeName;
            this.EmployeeId = EmployeeId;
            this.EmployeePhoneNumber = EmployeePhoneNumber;
        }
        public Employee() { }
    }
   
}
