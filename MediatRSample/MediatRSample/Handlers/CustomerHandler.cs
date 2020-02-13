using MediatR;
using MediatRSample.Requests;
using MediatRSample.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRSample.Handlers
{
    public class CustomerHandler : IRequestHandler<GetCustomerRequest, CustomerResponse>
    {
        public async Task<CustomerResponse> Handle(GetCustomerRequest request, CancellationToken cancellationToken)
        {
            return new CustomerResponse
            {
                Name = "Baldev"
            };
        }

    }
}
