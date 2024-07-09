﻿using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}

        public DbSet<Employee> Employees { get; set; }
    }
}
