using MediatR;

namespace car_themed_app.Commands.Orders
{
    public class DeleteOrderByIdCommand : IRequest<Unit>
    {
        public int Id { get; }

        public DeleteOrderByIdCommand(int id)
        {
            Id = id;
        }
    }
}
