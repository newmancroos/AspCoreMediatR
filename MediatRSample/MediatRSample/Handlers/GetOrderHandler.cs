using MediatR;
using MediatRSample.Requests;
using MediatRSample.Responses;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRSample.Handlers
{
    public class GetOrderHandler : IRequestHandler<GetOrderRequest, List<OrderResponse>>
    {

        public async Task<List<OrderResponse>> Handle(GetOrderRequest request, CancellationToken cancellationToken)
        {
            return new List<OrderResponse>();
        }
    }
}
