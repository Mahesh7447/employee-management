using EmployeeManagement.Models;
using EmployeeManagement.Repositories;

namespace EmployeeManagement.Services
{
    public class EmployeeService : IService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public bool delete(int id)
        {
            return employeeRepository.deleteEmployee(id);  
        }

        public void EditEmployee(Employee employee)
        {
            employeeRepository.EditEmployee(employee);
        }

        public IEnumerable<Employee> getAll()
        {
           return employeeRepository.GetEmployees();
        }

        public Employee GetEmployee(int id)
        {
            return employeeRepository.GetEmployee(id);  
        }

        public bool save(Employee employee)
        {
            Employee emp=employeeRepository.saveEmployee(employee);
            if (emp != null)
            {
                return true;
            }
            return false;
        }
    }
}
