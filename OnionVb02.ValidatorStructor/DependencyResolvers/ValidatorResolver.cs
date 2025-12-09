using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.AppUserProfileCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.OrderDetailCommands;
using OnionVb02.Application.CqrsAndMediatr.Mediator.Commands.ProductCommands;
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
            

            services.AddTransient<IValidator<CreateProductCommand>, OnionVb02.ValidatorStructor.Validators.MediatrValidators.ProductValidator>();
            services.AddTransient<IValidator<CreateOrderCommand>, OnionVb02.ValidatorStructor.Validators.MediatrValidators.OrderValidator>();
            services.AddTransient<IValidator<CreateOrderDetailCommand>, OnionVb02.ValidatorStructor.Validators.MediatrValidators.OrderDetailValidator>();
            services.AddTransient<IValidator<CreateCategoryCommand>, OnionVb02.ValidatorStructor.Validators.MediatrValidators.CategoryValidator>();
            services.AddTransient<IValidator<CreateAppUserCommand>, OnionVb02.ValidatorStructor.Validators.MediatrValidators.AppUserValidator>();
            services.AddTransient<IValidator<CreateAppUserProfileCommand>, OnionVb02.ValidatorStructor.Validators.MediatrValidators.AppUserProfileValidator>();
        }
    }
}
