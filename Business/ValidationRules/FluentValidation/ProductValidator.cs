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
            
            RuleFor(p => p.Title).NotEmpty();
            RuleFor(p => p.Title).Must(StartWithX);
        }

        private bool StartWithX(string arg)
        {
            return arg.StartsWith("x");
        }
    }
}