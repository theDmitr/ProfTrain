using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Api.Context;
using TaskManager.Api.Controllers.Base;
using TaskManager.Common.Dtos;

namespace TaskManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController(DataContext context) : BaseController(context)
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectDto>>> Get()
        {
            return await Context.Projects
                .Include(p => p.ResponsibleEmployee)
                .Include(p => p.CreatorEmployee)
                .Select(p => new ProjectDto(p))
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectDto>> Get(Guid id)
        {
            var project = await Context.Projects
                .Include(p => p.ResponsibleEmployee)
                .Include(p => p.CreatorEmployee)
                .SingleOrDefaultAsync(p => p.Id == id);
            return project == null ? NoContent() : new ProjectDto(project);
        }

        [HttpPost]
        public async Task<ActionResult<ProjectDto>> Create(ProjectDto projectDto)
        {
            if (projectDto.ResponsibleEmployee == null || projectDto.CreatorEmployee == null)
                return NotFound();

            Common.Models.Employee responsible = await Context.Employees.SingleOrDefaultAsync(e => e.Id == projectDto.ResponsibleEmployee.Id);
            Common.Models.Employee creator = await Context.Employees.SingleOrDefaultAsync(e => e.Id == projectDto.CreatorEmployee.Id);

            if (responsible == null || creator == null)
                return NotFound();

            Common.Models.Project toCreate = new()
            {
                DeletedTime = projectDto.DeletedTime,
                Description = projectDto.Description,
                FinishScheduledTime = projectDto.FinishScheduledTime,
                ResponsibleEmployee = responsible,
                CreatorEmployee = creator,
                ShortTitle = projectDto.ShortTitle,
                FullTitle = projectDto.FullTitle,
                StartScheduledTime = projectDto.StartScheduledTime,
            };

            await Context.Projects.AddAsync(toCreate);

            return new ProjectDto(toCreate);
        }
    }
}
