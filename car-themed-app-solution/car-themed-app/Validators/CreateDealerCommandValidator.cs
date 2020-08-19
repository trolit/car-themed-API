﻿using car_themed_app.Commands.Dealers;
using FluentValidation;

namespace car_themed_app.Validators
{
    public class CreateDealerCommandValidator : AbstractValidator<CreateDealerCommand>
    {
        public CreateDealerCommandValidator()
        {
            RuleFor(r => r.Dealer.Name).TextFieldValidation(5, 60);

            RuleFor(r => r.Dealer.Address).TextFieldValidation(2, 30);

            RuleFor(r => r.Dealer.PostalCode).TextFieldValidation(2, 15);

            RuleFor(r => r.Dealer.Country).TextFieldValidation(2, 20);
        }
    }
}
