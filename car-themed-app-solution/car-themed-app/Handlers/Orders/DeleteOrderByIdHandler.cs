using car_themed_app.Commands.Orders;
using car_themed_app_Repository.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace car_themed_app.Handlers.Orders
{
    public class DeleteOrderByIdHandler : IRequestHandler<DeleteOrderByIdCommand>
    {
        private readonly IOrdersRepository _ordersRepository;

        public DeleteOrderByIdHandler(IOrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public Task<Unit> Handle(DeleteOrderByIdCommand request, CancellationToken cancellationToken)
        {
            _ordersRepository.DeleteOrder(request.Id);
            return Task.FromResult(Unit.Value);
        }
    }
}
