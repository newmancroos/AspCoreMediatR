using MediatR;
using MediatRSample.Responses;
using System.Collections.Generic;

namespace MediatRSample.Requests
{
    public class GetOrderRequest:IRequest<List<OrderResponse>>
    {
        public int OrderId { get; set; }
    }
}
