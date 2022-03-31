using Microsoft.AspNetCore.Mvc;
using JustADevBlog.Api.Exceptions;

namespace JustADevBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpGet("")]
        public IAsyncResult Get()
        {
            throw new AlgoComputeException("Algo Compute Exception Message", new AlgoComputeErrorDetails("data1", 1));
        }
    }
}
