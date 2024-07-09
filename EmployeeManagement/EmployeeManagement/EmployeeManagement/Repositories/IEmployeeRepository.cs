using EmployeeManagement.Models;

namespace EmployeeManagement.Repositories
{
    public interface IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployees();
        public Employee GetEmployee(int id);
        public Employee saveEmployee(Employee employee);    
        public Boolean deleteEmployee(int id);
        public void EditEmployee(Employee employee);

    }
}
