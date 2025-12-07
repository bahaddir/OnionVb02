using Microsoft.Extensions.DependencyInjection;
using OnionVb02.Application.Behaviors; 
using System.Reflection;

namespace OnionVb02.Application.DependencyResolvers
{
    public static class HandlerResolver
    {
        public static void AddHandlerService(this IServiceCollection services)
        {
            
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
                cfg.AddOpenBehavior(typeof(ValidationBehavior<,>));
            });
        }
    }
}