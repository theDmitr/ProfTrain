using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.Api.Context;
using TaskManager.Api.Controllers.Base;
using TaskManager.Common.Dtos;

namespace TaskManager.Api.Controllers
{
    [ApiController]
    [Route("api/task-status")]
    public class TaskStatusController(DataContext context) : BaseController(context)
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskStatusDto>>> Get()
        {
            return await Context.TaskStatuses.Select(s => new TaskStatusDto(s)).ToListAsync();
        }
    }
}
