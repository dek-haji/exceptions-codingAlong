using System.Collections.Generic;
namespace TryCatch
{
    public class Company
    {
        private List<Employee> _employees = new List<Employee>();
        public string Name { get; set; }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public Employee GetEmployeeById(int id)
        {
            return _employees[id];
        }
    }

}