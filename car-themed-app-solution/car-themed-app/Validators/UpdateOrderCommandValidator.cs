using car_themed_app.Commands.Orders;
using car_themed_app_Repository.Interfaces;
using FluentValidation;

namespace car_themed_app.Validators
{
    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator(IDealersRepository dealersRepository)
        {
            RuleFor(r => r.Order.Components).ComponentValidation();

            RuleFor(r => r.Order.OrderDate).DateValidation();

            RuleFor(r => r.Order.DealerId)
                .NotEmpty()
                .WithMessage("DealerId cannot be empty.")
                .GreaterThan(0)
                .WithMessage("DealerId must be greater than 1.")
                .MustAsync(async (dealerId, cancellation) => await dealersRepository.CheckIfDealerExists(dealerId))
                .WithMessage("Dealer not exists!");
        }
    }
}
