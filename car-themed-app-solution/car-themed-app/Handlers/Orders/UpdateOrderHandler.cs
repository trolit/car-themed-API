using AutoMapper;
using car_themed_app.Commands.Orders;
using car_themed_app_Repository.Interfaces;
using car_themed_app_Repository.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace car_themed_app.Handlers.Orders
{
    public class UpdateOrderHandler : IRequestHandler<UpdateOrderCommand>
    {
        private readonly IOrdersRepository _ordersRepository;
        private readonly IMapper _mapper;

        public UpdateOrderHandler(IOrdersRepository ordersRepository, IMapper mapper)
        {
            _ordersRepository = ordersRepository;
            _mapper = mapper;
        }

        public Task<Unit> Handle(UpdateOrderCommand request, CancellationToken cancellationToken)
        {
            var mappedOrder = _mapper.Map<Order>(request.Order);
            _ordersRepository.UpdateOrder(mappedOrder);
            return Task.FromResult(Unit.Value);
        }
    }
}
