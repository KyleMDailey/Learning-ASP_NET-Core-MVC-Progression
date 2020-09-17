using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySecondMVCApp_DaileyKyle08132020.Models
{
    public class EmployeeBusinessLayer
    {

        public Employee GetEmployeeDetails(int EmployeeID)
        {
            Employee employee = new Employee()
            {

                //read (SQL Query)
                //string @EmployeeID = 1;
                //CRUD:  SELECT Name, Gender, City, Salary, Address FROM 
                //Employees
                //WHERE EmployeeID = @EmployeeID

                EmployeeID = 1,
                Name = "Kyle",
                Gender = "Male",
                City = "Fayetteville",
                Salary = 150000,
                Address = "Home"
            };
            return employee;
        }
    }
}
