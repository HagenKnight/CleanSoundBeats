﻿using MediatR;
using Microsoft.Extensions.DependencyInjection;
using SoundBeats.Application.Behaviors;
using System.Reflection;
using FluentValidation;

namespace SoundBeats.Application.ServiceCollection
{
    public static class ServiceExtension
    {
        public static void AddApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        }
    }
}
