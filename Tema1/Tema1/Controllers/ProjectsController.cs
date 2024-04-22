using System.Net.NetworkInformation;
using Tema1.Core.Services;
using Tema1.Database.Dtos.Request;
using Tema1.Database.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Tema1.Api.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private OrdersService projectsService { get; set; }

        public ProjectsController(OrdersService projectsService)
        {
            this.projectsService = projectsService;
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddProject([FromBody] AddOrderRequest payload)
        {
            projectsService.AddOrder(payload);

            return Ok("Project has been successfully added");
        }

        [HttpGet]
        [Route("get-details")]
        public IActionResult GetTaskDetails([FromRoute] GetOrderRequest orders)
        {
            var result = projectsService.GetOrders(orders);

            return Ok(result);
        }
    }
}
