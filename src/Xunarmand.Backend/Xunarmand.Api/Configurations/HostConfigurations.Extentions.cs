﻿using System.Reflection;
using System.Text;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Xunarmand.Api.Data;
using Xunarmand.Application.Common.Settings;
using Xunarmand.Application.User.Queries;
using Xunarmand.Infrastructure.User.Services;
using Xunarmand.Persistence.DataContext;
using Xunarmand.Persistence.Repositories;
using Xunarmand.Persistence.Repositories.Interface;

namespace Xunarmand.Api.Configurations;

public static partial class  HostConfigurations
{
    private static readonly ICollection<Assembly> Assemblies;

    static HostConfigurations()
    {
        Assemblies = Assembly.GetExecutingAssembly().GetReferencedAssemblies().Select(Assembly.Load).ToList();
        Assemblies.Add(Assembly.GetExecutingAssembly());
    }
    
    private static WebApplicationBuilder AddMappers(this WebApplicationBuilder builder)
    {
        builder.Services.AddAutoMapper(Assemblies);
        return builder;
    }

    private static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
    {
        builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString")));
        return builder;
    }
    private static async ValueTask<WebApplication> SeedDataAsync(this WebApplication app)
    {
        var serviceScope = app.Services.CreateScope();
        await serviceScope.ServiceProvider.InitializeSeedAsync();

        return app;
    }

    private static WebApplicationBuilder AddIdentityInfrastructure(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IUserRepository, UserRepository>();
        builder.Services.AddScoped<IUserService, UserService>();

        return builder;

    }
    private static WebApplicationBuilder AddMediator(this WebApplicationBuilder builder)
    {
        builder.Services.AddMediatR(conf => {conf.RegisterServicesFromAssemblies(Assemblies.ToArray());});
        
        return builder;
    }

    private static WebApplicationBuilder AddDevTools(this WebApplicationBuilder builder)
    {
        builder.Services.AddSwaggerGen();
        builder.Services.AddEndpointsApiExplorer();
        
        return builder;
    }

    private static WebApplicationBuilder AddExposers(this WebApplicationBuilder builder)
    {
        builder.Services.AddRouting(options => options.LowercaseUrls = true);
        builder.Services.AddControllers();
        
        return builder;
    }
    
    private static WebApplication UseDevtools(this WebApplication app)
    {
        app.UseSwagger();
        app.UseSwaggerUI();
        
        return app;
    }
    private static WebApplicationBuilder AddValidators(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<ValidationSettings>(builder.Configuration.GetSection(nameof(ValidationSettings)));

        builder.Services.AddValidatorsFromAssemblies(Assemblies).AddFluentValidationAutoValidation();        
        return builder;
    }


    private static WebApplication UseExposers(this WebApplication app)
    {
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();
        
        return app;
    }
}

