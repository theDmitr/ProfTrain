using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Common.Models;

namespace TaskManager.Common.Dtos
{
    public class EmployeeDto
    {
        public Guid Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string FullName { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public string Position { get; set; }

        public EmployeeDto() { }

        public EmployeeDto(Employee employee)
        {
            if (employee == null)
                return;

            Id = employee.Id;
            Login = employee.Login;
            Password = employee.Password;
            FullName = employee.FullName;
            Email = employee.Email;
            Position = employee.Position;
        }
    }
}
