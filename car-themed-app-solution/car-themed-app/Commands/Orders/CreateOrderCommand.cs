using car_themed_app_Repository.Dtos;
using car_themed_app_Repository.Models;
using MediatR;

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
