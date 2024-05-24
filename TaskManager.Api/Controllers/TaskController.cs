using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using TaskManager.Api.Context;
using TaskManager.Api.Controllers.Base;
using TaskManager.Common.Dtos;
using TaskManager.Common.Models;

namespace TaskManager.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController(DataContext context) : BaseController(context)
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskDto>>> Get()
        {
            return await Context.Tasks
                .Include(t => t.Creator)
                .Include(t => t.Executor)
                .Include(t => t.TaskStatus)
                .Select(t => new TaskDto(t))
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TaskDto>> Get(Guid id)
        {
            var task = await Context.Tasks
                .Include(t => t.Creator)
                .Include(t => t.Executor)
                .Include(t => t.TaskStatus)
                .SingleOrDefaultAsync(t => t.Id == id);

            return task == null ? NotFound() : new TaskDto(task);
        }

        [HttpPost]
        public async Task<ActionResult<TaskDto>> Create(TaskDto taskDto)
        {
            if (taskDto.Executor == null || taskDto.Creator == null 
                || taskDto.TaskStatus == null)
                return NotFound();

            Employee creator = await Context.Employees.SingleOrDefaultAsync(e => e.Id == taskDto.Creator.Id);
            Employee executor = await Context.Employees.SingleOrDefaultAsync(e => e.Id == taskDto.Executor.Id);
            Common.Models.TaskStatus taskStatus = await Context.TaskStatuses.SingleOrDefaultAsync(s => s.Id == taskDto.TaskStatus.Id);

            if (executor == null || creator == null || taskStatus == null)
                return NotFound();

            Common.Models.Task toCreate = new()
            {
                Previous = taskDto.Previous == null ? null : await Context.Tasks.SingleOrDefaultAsync(t => t.Id == taskDto.Previous.Id),
                TaskStatus = taskStatus,
                Executor = executor,
                Creator = creator,
                FullTitle = taskDto.FullTitle,
                DeadLine = taskDto.DeadLine,
                DeletedTime = taskDto.DeletedTime,
                Description = taskDto.Description,
                FinishTime = taskDto.FinishTime,
                ShortTitle = taskDto.ShortTitle,
                StartTime = taskDto.StartTime,
                UpdatedTime = taskDto.UpdatedTime,
            };

            await Context.Tasks.AddAsync(toCreate);
            await Context.SaveChangesAsync();

            return new TaskDto(toCreate);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var task = await Context.Tasks.SingleOrDefaultAsync(t => t.Id == id);

            if (task == null)
                return NoContent();

            Context.Tasks.Remove(task);
            await Context.SaveChangesAsync();

            return Ok();
        }

        [HttpPatch]
        public async Task<IActionResult> Update(TaskDto taskDto)
        {
            if (taskDto == null)
                return NoContent();

            var alive = await Context.Tasks.SingleOrDefaultAsync(t => t.Id == taskDto.Id);

            if (alive == null)
                return NoContent();

            if (taskDto.Executor == null || taskDto.Creator == null
                || taskDto.TaskStatus == null)
                return NotFound();

            Employee creator = await Context.Employees.SingleOrDefaultAsync(e => e.Id == taskDto.Creator.Id);
            Employee executor = await Context.Employees.SingleOrDefaultAsync(e => e.Id == taskDto.Executor.Id);
            Common.Models.TaskStatus taskStatus = await Context.TaskStatuses.SingleOrDefaultAsync(s => s.Id == taskDto.TaskStatus.Id);

            if (executor == null || creator == null || taskStatus == null)
                return NotFound();

            alive.Previous = taskDto.Previous == null ? null : await Context.Tasks.SingleOrDefaultAsync(t => t.Id == taskDto.Previous.Id);
            alive.TaskStatus = taskStatus;
            alive.Executor = executor;
            alive.Creator = creator;
            alive.FullTitle = taskDto.FullTitle;
            alive.DeadLine = taskDto.DeadLine;
            alive.DeletedTime = taskDto.DeletedTime;
            alive.Description = taskDto.Description;
            alive.FinishTime = taskDto.FinishTime;
            alive.ShortTitle = taskDto.ShortTitle;
            alive.StartTime = taskDto.StartTime;
            alive.UpdatedTime = taskDto.UpdatedTime;

            await Context.SaveChangesAsync();

            return Ok();
        }
    }
}
