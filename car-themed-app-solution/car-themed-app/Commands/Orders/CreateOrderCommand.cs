using car_themed_app_Repository.Dtos;
using MediatR;
using car_themed_app_Repository.Models;

namespace car_themed_app.Commands.Orders
{
    public class CreateOrderCommand : IRequest<Order>
    {
        public NewOrderDto Order { get; }

        public CreateOrderCommand(NewOrderDto order)
        {
            Order = order;
        }
    }
}
