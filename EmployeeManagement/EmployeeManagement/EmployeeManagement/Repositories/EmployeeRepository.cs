using EmployeeManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public bool deleteEmployee(int id)
        {
            var employee = dbContext.Employees.FirstOrDefault(emp => emp.EmpId == id);
            if (employee != null)
            {
                dbContext.Employees.Remove(employee);
                dbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public void EditEmployee(Employee employee)
        {
            dbContext.Entry(employee).State = EntityState.Modified; 
            dbContext.SaveChanges();
        }

        public Employee GetEmployee(int id)
        {
            return dbContext.Employees.FirstOrDefault(emp => emp.EmpId == id);
        }

        public IEnumerable<Employee> GetEmployees()
        {
            return dbContext.Employees.ToList();
        }

        public Employee saveEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return employee;
        }
    }
}
