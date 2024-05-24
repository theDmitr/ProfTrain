using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Api.Context;
using TaskManager.Api.Controllers.Base;
using TaskManager.Common.Dtos;
using TaskManager.Common.Models;

namespace TaskManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController(DataContext context) : BaseController(context)
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmployeeDto>>> Get()
        {
            return await Context.Employees
                .Select(e => new EmployeeDto(e))
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EmployeeDto>> Get(Guid id)
        {
            var employee = await Context.Employees.SingleOrDefaultAsync(e => e.Id == id);
            return employee == null ? NoContent() : new EmployeeDto(employee);
        }

        [HttpGet("{login}/{password}")]
        public async Task<ActionResult<EmployeeDto>> Get(string login, string password)
        {
            var employee = await Context.Employees.SingleOrDefaultAsync(e => e.Login.Equals(login) && e.Password.Equals(password));
            return employee == null ? NoContent() : new EmployeeDto(employee);
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeDto>> Create(EmployeeDto employeeDto)
        {
            Employee toCreate = new()
            {
                Email = employeeDto.Email,
                FullName = employeeDto.FullName,
                Login = employeeDto.Login,
                Password = employeeDto.Password,
                Position = employeeDto.Position
            };

            await Context.AddAsync(toCreate);

            return new EmployeeDto(toCreate);
        }
    }
}
