using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>();
            _employeeList.Add(new Employee()
            {
                ID = 1,
                Name = "Joseph",
                Email = "joseph@gmail.com",
                Department = Dept.HR
            });
            _employeeList.Add(new Employee()
            {
                ID = 2,
                Name = "Tobby",
                Email = "tobby@gmail.com",
                Department = Dept.IT
            });
            _employeeList.Add(new Employee()
            {
                ID = 3,
                Name = "Tosin",
                Email = "tosin@gmail.com",
                Department = Dept.Payroll
            });

        }

        public Employee Add(Employee employee)
        {
            employee.ID = _employeeList.Max(e => e.ID) +1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.ID == id);
            if (employee != null)
            {
                _employeeList.Remove(employee);
            }
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return this._employeeList.FirstOrDefault(e => e.ID == Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.ID == employeeChanges.ID);
            if (employee != null)
            {
                employee.Name = employeeChanges.Name;
                employee.Email = employeeChanges.Email;
                employee.Department = employeeChanges.Department;
            }
            return employee;
        }
    }
}
