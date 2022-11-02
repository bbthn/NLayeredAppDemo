using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.CategoryId).NotEmpty();


            RuleFor(p => p.UnitPrice).GreaterThan(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo(Convert.ToInt16(0));
            RuleFor(P => P.UnitPrice).GreaterThan(100).When(p => p.CategoryId == 2);

            RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("Urun adi A ile baslamalii!!");



        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
