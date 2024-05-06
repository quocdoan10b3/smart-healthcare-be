using System.Reflection;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using SmartHealthCare.Application.Common.Configurations;
using SmartHealthCare.Application.Common.Interfaces;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Domain.Entities;
using SmartHealthCare.Domain.Repositories;
using SmartHealthCare.Domain.Repositories.Base;
using SmartHealthCare.Infrastructure.Data;
using SmartHealthCare.Infrastructure.Email;
using SmartHealthCare.Infrastructure.Repositories.Base;
using SmartHealthCare.Services;

namespace SmartHealthCare.Extensions;

public static class ServiceExtension
{
	public static IServiceCollection ConfigureCors(this IServiceCollection services)
	{
		services.AddCors(options =>
		{
			options.AddPolicy("CorsPolicy", builder =>
			{
				builder
					.AllowAnyOrigin()
					.AllowAnyMethod()
					.AllowAnyHeader();
			});
		});
		return services;
	}

	public static IServiceCollection ConfigureDbContext(this IServiceCollection services,
	                                                    IConfiguration configuration)
	{
		services.AddDbContext<AppDbContext>(options =>
		{
			options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
			options.EnableSensitiveDataLogging();
		});
		return services;
	}

	public static IServiceCollection AddRepositories(this IServiceCollection services)
	{
		services.AddScoped(typeof(IRepositoryBase<>), typeof(RepositoryBase<>));
		services.AddScoped<IUnitOfWork, UnitOfWork>();

		services.Scan(scan => scan.FromAssembliesOf(typeof(RepositoryBase<>))
			.AddClasses(c => c.AssignableTo(typeof(RepositoryBase<>)))
			.AsImplementedInterfaces()
			.WithScopedLifetime());

		return services;
	}

	public static IServiceCollection AddServices(this IServiceCollection services)
	{
		services.Scan(scan => scan.FromAssemblyOf<BaseService>()
			.AddClasses(c => c.AssignableTo<BaseService>())
			.AsSelf()
			.WithScopedLifetime());
		return services;
	}

	public static IServiceCollection ConfigureIdentity(this IServiceCollection services)
	{
		services.AddIdentity<User, IdentityRole<int>>(options =>
			{
				options.Password.RequiredLength = 8;
				options.Password.RequireDigit = true;
				options.Password.RequireUppercase = true;
				options.Password.RequireLowercase = true;
				options.Password.RequireDigit = true;
				options.Password.RequireNonAlphanumeric = true;

				options.User.RequireUniqueEmail = true;
			})
			.AddEntityFrameworkStores<AppDbContext>()
			.AddDefaultTokenProviders();
		return services;
	}

	public static IServiceCollection AddCurrentUser(this IServiceCollection services)
	{
		services.AddScoped<ICurrentUser, CurrentUser>();
		services.AddHttpContextAccessor();
		return services;
	}

	public static void ConfigureLogging(this WebApplicationBuilder builder)
	{
		builder.Host.UseSerilog((ctx,
		                         lc) =>
			lc.ReadFrom.Configuration(ctx.Configuration));
	}

	public static void AddSettings(this WebApplicationBuilder builder)
	{
		// var environment = builder.Environment.EnvironmentName.ToLower();
		// builder.Configuration.AddSystemsManager($"/{environment}", TimeSpan.FromMinutes(5));

		builder.Services.Configure<TokenSettings>(builder.Configuration.GetSection("TokenSettings"));
	}

	public static IServiceCollection AddAuthentication(this IServiceCollection services,
	                                                   IConfiguration configuration)
	{
		services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddJwtBearer(options =>
			{
				options.TokenValidationParameters = new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					ValidateLifetime = true,
					IssuerSigningKey =
						new SymmetricSecurityKey(
							Encoding.UTF8.GetBytes(configuration.GetSection("TokenSettings:Key").Value!)),
				};
			});
		return services;
	}

	public static IServiceCollection AddSwagger(this IServiceCollection services, string applicationName, string version = "v1")
	{
		services.AddEndpointsApiExplorer();

		services.AddSwaggerGen(config =>
		{
			config.SwaggerDoc(version, new OpenApiInfo
			{
				Title = applicationName,
				Version = version
			});

			config.AddSecurityDefinition(JwtBearerDefaults.AuthenticationScheme, new OpenApiSecurityScheme
			{
				In = ParameterLocation.Header,
				Description = "Please insert JWT with Bearer into field",
				Name = "Authorization",
				BearerFormat = "JWT",
				Type = SecuritySchemeType.ApiKey,
				Scheme = JwtBearerDefaults.AuthenticationScheme
			});

			config.AddSecurityRequirement(new OpenApiSecurityRequirement
			{
				{
					new OpenApiSecurityScheme
					{
						Reference = new OpenApiReference
						{
							Type = ReferenceType.SecurityScheme,
							Id = JwtBearerDefaults.AuthenticationScheme
						}
					},
					Array.Empty<string>()
				}
			});
			// var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
			// config.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
		});

		return services;
	}
	
	public static IServiceCollection AddEmailSender(this IServiceCollection services)
    {
        services.AddScoped<IEmailSender, EmailSender>();
        return services;
    }
}