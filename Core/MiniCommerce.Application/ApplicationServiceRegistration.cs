using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MiniCommerce.Application.Behaviors;
using MiniCommerce.Application.Behaviors.ValidationBehavior;
using MiniCommerce.Application.Mapping;
using System.Reflection;

namespace MiniCommerce.Application
{
    public static class ApplicationServiceRegistration
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));

            return services;
        }
    }
}