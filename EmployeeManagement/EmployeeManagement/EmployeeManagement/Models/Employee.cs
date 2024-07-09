using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        public string Gender { get; set; }
        [Required]
        public string Mobile { get; set; }
        public string City { get; set; }
        public string Status { get; set; }
        public string Department { get; set; }
    }
}
