﻿global using System.Collections.Generic;
global using FeaturesManagementDashboard.Domain.Entities.Features;
global using System;
global using Umbraco.Cms.Core.Composing;
global using Umbraco.Cms.Core.Dashboards;
global using FeaturesManagementDashboard.Infrastructure.Services;
global using Umbraco.Cms.Core.DependencyInjection;
global using Umbraco.Cms.Core.Services;
global using Umbraco.Extensions;
global using FeaturesManagementDashboard.Application.Commands;
global using FeaturesManagementDashboard.Application.Queries;
global using FeaturesManagementDashboard.Infrastructure.HandlerDispatchers;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.FeatureManagement;
global using Microsoft.FeatureManagement.FeatureFilters;
global using Shared.Domain;
global using Shared.Queries;
global using SharedAbstractions.DI;
global using Umbraco.Cms.Core.Configuration.Models;
global using InMemoryQueryDispatcher = FeaturesManagementDashboard.Infrastructure.HandlerDispatchers.InMemoryQueryDispatcher;
global using MappersMap = Shared.Mappers;
global using FeaturesManagementDashboard.Infrastructure.Providers;
global using FeaturesManagementDashboard.Infrastructure.Settings;
global using System.Threading.Tasks;
global using System.Linq;
global using FeaturesManagementDashboard.Application.DI;
global using FeaturesManagementDashboard.Domain.Repositories;
global using FeaturesManagementDashboard.Infrastructure.Comparers;
global using FeaturesManagementDashboard.Infrastructure.Extensions;
global using FeaturesManagementDashboard.Infrastructure.Migrations;
global using Umbraco.Cms.Core.Migrations;
global using Umbraco.Cms.Infrastructure.Migrations;
global using Umbraco.Cms.Infrastructure.Migrations.Upgrade;
global using FeaturesManagementDashboard.Application.DTO.Features;
global using SharedAbstractions.Mappers;
global using DapperExtensions.Mapper;
global using FeaturesManagementDashboard.Infrastructure.Constants;
global using FeaturesManagementDashboard.Infrastructure.Mappers;
global using DapperExtensions;
global using System.Data;
global using FeaturesManagementDashboard.Infrastructure.Dashboards;
global using Umbraco.Cms.Core.Models.ContentEditing;
global using Umbraco.Cms.Core.Models.Membership;