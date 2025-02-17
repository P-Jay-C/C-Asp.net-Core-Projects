﻿using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50,ErrorMessage = "Name shouldn't exceed 50 characters.")]
        public string? Name { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-z0-9_.]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9.]+$",ErrorMessage = "Invalid Email Format")]
        [Display(Name = "Office Email")]
        public string Email { get; set; }

        [Required]
        public Dept Department { get; set; }

        public string? PhotoPath { get; set; }


    }
}
