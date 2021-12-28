using Employee.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Net;

namespace Employee.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseController : Controller
    {
        protected readonly INotification Notification;
        
        public BaseController(INotification notification)
        {
            Notification = notification;
        }

        protected IActionResult CreateResponse(object data, HttpStatusCode statusCode = HttpStatusCode.OK)
        {
            bool success = IsOperationValid();

            var response = new
            {
                Success = success,
                Response = data,
                Messages = Notification.Notifications.ToArray()
            };

            if (!success)
            {
                if (statusCode == HttpStatusCode.OK) statusCode = HttpStatusCode.BadRequest;

                return StatusCode((int)statusCode, response);
            }

            return new ObjectResult(response) { StatusCode = (int)statusCode };
        }

        protected bool IsOperationValid() => !Notification.HasNotification();
    }
}
