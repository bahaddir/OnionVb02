using FluentValidation;
using OnionVb02.Application.DTOClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.ValidatorStructor.Validators
{
    public class ProductValidator : AbstractValidator<ProductDto>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş olamaz.");
            RuleFor(x => x.UnitPrice).GreaterThan("0").WithMessage("Fiyat 0'dan büyük olmalıdır."); // UnitPrice string ise dönüşüm gerekebilir, DTO'da string tanımlanmış, decimal olmalıydı.
        }
    }

}
