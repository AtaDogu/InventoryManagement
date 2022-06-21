using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).Must(NotStartWithX);
        }

        private bool NotStartWithX(string arg)
        {
            return (!arg.StartsWith("X"));
        }
    }
}