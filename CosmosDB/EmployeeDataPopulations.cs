using System;
using System.Collections.Generic;
using System.Text;

namespace CosmosDB
{
    public class EmployeeDataPopulations
    {
        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee()
            {
                EmployeeID = Guid.NewGuid().ToString(),
                EmployeeName = new Name()
                {
                    FirstName = "Sample FirstName",
                    MiddleName ="Sample MiddleName",
                    LastName = "Sample LastName",
                    Suffix = "Sample Suffix"
                },
                EmploymentType = EmploymentType.FullTime,
                PresentAddress = new Address()
                {
                    Address1 ="Sample Address1",
                    Address2 ="Sample Address2",
                    City ="Sample City",
                    State ="Sample State",
                    ZipCode ="Sample ZipCode"
                },
                DateJoined = DateTime.Now.AddYears(-10)
            });

            employees.Add(new Employee()
            {
                EmployeeID = Guid.NewGuid().ToString(),
                EmployeeName = new Name()
                {
                    FirstName = "Example FirstName",
                    MiddleName = "Example MiddleName",
                    LastName = "Example LastName",
                    Suffix = "Example Suffix"
                },
                EmploymentType = EmploymentType.PartTime,
                PresentAddress = new Address()
                {
                    Address1 = "Example Address1",
                    Address2 = "Example Address2",
                    City = "Example City",
                    State = "Example State",
                    ZipCode = "Example ZipCode"
                },
                DateJoined = DateTime.Now.AddYears(-5)
            });

            employees.Add(new Employee()
            {
                EmployeeID = Guid.NewGuid().ToString(),
                EmployeeName = new Name()
                {
                    FirstName = "Test FirstName",
                    MiddleName = "Test MiddleName",
                    LastName = "Test LastName",
                    Suffix = "Test Suffix"
                },
                EmploymentType = EmploymentType.Contrator,
                PresentAddress = new Address()
                {
                    Address1 = "Test Address1",
                    Address2 = "Test Address2",
                    City = "Test City",
                    State = "Test State",
                    ZipCode = "Test ZipCode"
                },
                DateJoined = DateTime.Now.AddYears(-4)
            });

            return employees;
        }
    }
}
