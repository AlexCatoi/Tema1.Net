using System.Net.NetworkInformation;
using Tema1.Core.Services;
using Tema1.Database.Dtos.Request;
using Microsoft.AspNetCore.Authorization;
using Tema1.Database.Entities;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using Tema1.API.Controllers;

namespace Tema1.Api.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : BaseController
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

            return Ok("Order has been successfully added");
        }

        [HttpGet]
        [Route("get-details")]
        [Authorize(Roles ="Admin")]
        public IActionResult GetTaskDetails([FromRoute] GetOrderRequest orders)
        {
            var result = projectsService.GetOrders(orders);

            return Ok(result);
        }
    }
}
