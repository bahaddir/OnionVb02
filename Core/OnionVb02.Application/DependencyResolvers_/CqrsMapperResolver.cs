using Microsoft.Extensions.DependencyInjection;
using OnionVb02.Application.MappingProfiles;

namespace OnionVb02.Application.DependencyResolvers
{
    public static class CqrsMapperResolver
    {
        public static void AddCqrsMapperService(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CqrsMappingProfile));
        }
    }
}