using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientManagement.Models
{
    public class MockEmployeeRespository : IEmployeeRepository
    {

        private List<Employee> _employeeList;

        public MockEmployeeRespository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee(){ Id = 1, Name = "Mary", Department = Dept.HR, Email = "mary@pds.om"},
                new Employee(){ Id = 2, Name = "John", Department = Dept.IT, Email = "john@pds.om"},
                new Employee(){ Id = 3, Name = "Sam", Department = Dept.IT, Email = "sam@pds.om"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee Update(Employee employee)
        {
            _employeeList.Remove(employee);
            _employeeList.Add(employee);
            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == Id);
        }

    }
}
