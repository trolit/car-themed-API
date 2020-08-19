using car_themed_app.Commands.Orders;
using FluentValidation;

namespace car_themed_app.Validation
{
    public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
    {
        public CreateOrderCommandValidator()
        {
            RuleFor(r => r.Order.Components)
                .NotEmpty();

            RuleFor(r => r.Order.DealerId)
                .GreaterThan(15);
        }
    }
}
