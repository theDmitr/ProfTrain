using Microsoft.AspNetCore.Mvc;
using TaskManager.Api.Context;

namespace TaskManager.Api.Controllers.Base
{
    public abstract class BaseController : Controller
    {
        protected DataContext Context { get; init; }

        public BaseController(DataContext context)
        {
            Context = context;
        }
    }
}
