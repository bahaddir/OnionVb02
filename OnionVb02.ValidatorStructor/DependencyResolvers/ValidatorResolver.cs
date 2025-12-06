using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OnionVb02.Application.DTOClasses;
using OnionVb02.ValidatorStructor.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionVb02.ValidatorStructor.DependencyResolvers
{
    public static class ValidatorResolver
    {
        public static void AddValidatorService(this IServiceCollection services)
        {
            services.AddTransient<IValidator<ProductDto>, ProductValidator>();
            services.AddTransient<IValidator<CategoryDto>, CategoryValidator>();
            services.AddTransient<IValidator<AppUserProfileDto>, AppUserProfileValidator>();
            services.AddTransient<IValidator<AppUserDto>, AppUserValidator>();
            services.AddTransient<IValidator<OrderDetailDto>, OrderDetailValidator>();
            services.AddTransient<IValidator<OrderDto>, OrderValidator>();


        }
    }
}
