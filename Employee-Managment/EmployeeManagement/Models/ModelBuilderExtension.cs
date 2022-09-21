using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    Id = 1,
                    Department = Dept.HR,
                    Email = "solution@gmail.com",
                    Name = "Solution",
                    PhotoPath = "images/a.jpg"
                },

                new Employee()
                {
                    Id = 2,
                    Department = Dept.IT,
                    Name = "Parker",
                    Email = "parker@gmail.com",
                    PhotoPath = "images/b.jpg"


                });
        }
    }
}
