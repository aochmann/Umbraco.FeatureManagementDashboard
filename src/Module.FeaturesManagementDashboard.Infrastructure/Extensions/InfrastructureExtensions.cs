﻿using FeaturesManagementDashboard.Application.Commands;
using FeaturesManagementDashboard.Application.Queries;
using FeaturesManagementDashboard.Infrastructure.HandlerDispatchers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.FeatureFilters;
using Shared.Domain;
using Shared.Queries;
using SharedAbstractions.DI;
using Umbraco.Cms.Core.Configuration.Models;
using Umbraco.Cms.Core.DependencyInjection;
using InMemoryQueryDispatcher = FeaturesManagementDashboard.Infrastructure.HandlerDispatchers.InMemoryQueryDispatcher;

namespace FeaturesManagementDashboard.Infrastructure.Extensions
{
#pragma warning disable CS8604 // Possible null reference argument.

    public static class InfrastructureExtensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection registry,
            IUmbracoBuilder umbracoBuilder)
        {
            umbracoBuilder.Services
                .AddSettings()
                .AddProviders();

            _ = umbracoBuilder.Services
                .AddFeatureManagement()
                .AddFeatureFilter<PercentageFilter>()
                .AddFeatureFilter<TimeWindowFilter>();

            _ = umbracoBuilder.AddDashboard();

            return registry.AddInfrastructure(umbracoBuilder.Config);
        }

        internal static IServiceCollection AddInfrastructure(this IServiceCollection registry, IConfiguration configuration)
        {
            _ = registry.AddSingleton<IConfiguration>(configuration);

            _ = registry.AddSingleton<ConnectionStrings>(serviceContext => serviceContext
                    .GetService<IConfiguration>()
                    .GetOptions<ConnectionStrings>(
                        "ConnectionStrings",
                        true));

            _ = registry.AddSingleton<IDependencyResolver, CompositionRoot>();
            _ = registry.AddScoped<ICommandDispatcher, InMemoryCommandDispatcher>();
            _ = registry.AddScoped<IQueryDispatcher, InMemoryQueryDispatcher>();

            _ = registry
                .AddSettings()
                .AddServices()
                .AddRepositories()
                .AddMappers()
                .AddQueries(typeof(IQueryHandler<,>));

            return registry;
        }
    }

#pragma warning restore CS8604 // Possible null reference argument.
}