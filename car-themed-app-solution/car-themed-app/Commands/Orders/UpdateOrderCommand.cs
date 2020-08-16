using car_themed_app_Repository.Dtos;
using MediatR;

namespace car_themed_app.Commands.Orders
{
    public class UpdateOrderCommand : IRequest<Unit>
    {
        public UpdateOrderDto Order { get; }

        public UpdateOrderCommand(UpdateOrderDto order)
        {
            Order = order;
        }
    }
}
