using car_themed_app_Repository.Dtos;
using MediatR;
using System.Collections.Generic;

namespace car_themed_app.Queries.Orders
{
    public class GetAllOrdersQuery : IRequest<List<OrderDto>>
    {

    }
}
