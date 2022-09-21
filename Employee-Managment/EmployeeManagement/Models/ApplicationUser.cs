using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace EmployeeManagement.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string City { get; set; }
    }
}
