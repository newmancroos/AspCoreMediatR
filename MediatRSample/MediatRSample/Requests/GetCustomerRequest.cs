using MediatR;
using MediatRSample.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatRSample.Requests
{
    public class GetCustomerRequest:IRequest<CustomerResponse>
    {
        public int Id { get; set; }
    }
}
