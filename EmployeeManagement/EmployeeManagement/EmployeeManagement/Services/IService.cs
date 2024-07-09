using EmployeeManagement.Models;

namespace EmployeeManagement.Services
{
    public interface IService
    {
        public IEnumerable<Employee> getAll();
        public Employee GetEmployee(int id);
        public Boolean delete(int id);
        public Boolean save(Employee employee);
        public void EditEmployee(Employee employee);

    }
}
