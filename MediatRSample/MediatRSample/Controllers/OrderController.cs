using MediatR;
using MediatRSample.Requests;
using MediatRSample.Responses;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("getorder/{OrderId}")]
        public async  Task<IActionResult> GetOrder([FromRoute]GetOrderRequest request)
        {
            var id = RouteData.Values["OrderId"];
            return Ok(await _mediator.Send<List<OrderResponse>>(request));
        }

        [HttpGet("getcustomer")]
        public async Task<IActionResult> GetCustomer(GetCustomerRequest request)
        {
            
            return Ok(await _mediator.Send<CustomerResponse>(request));
        }
    }
}
 