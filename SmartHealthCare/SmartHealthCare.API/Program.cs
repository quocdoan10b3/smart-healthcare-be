using System.Text.Json.Serialization;
using FluentValidation;
using Minio;
using Serilog;
using SmartHealthCare.Application.Services;
using SmartHealthCare.Extensions;
using SmartHealthCare.Middlewares;
using IRequest = SmartHealthCare.Application.ViewModels.IRequest;

var builder = WebApplication.CreateBuilder(args);

builder.ConfigureLogging();
builder.AddSettings();
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
    }
);

builder.Services
    .ConfigureCors()
    .ConfigureIdentity()
    .ConfigureDbContext(builder.Configuration)
    .AddSwagger("SmartHealthCare API v1")
    .AddRepositories()
    .AddServices()
    .AddCurrentUser()
    .AddQuartz()
    .AddAutoMapper(typeof(BaseService).Assembly)
    .AddProblemDetails()
    .AddExceptionHandler<GlobalExceptionHandler>()
    .AddAuthentication(builder.Configuration)
    .AddMinio(builder.Configuration)
    .AddValidatorsFromAssemblyContaining<IRequest>(ServiceLifetime.Singleton);

var app = builder.Build();

await app.MigrateDatabaseAsync();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI(c =>
    {
        c.ConfigObject.AdditionalItems.Add("persistAuthorization","true");
    });
}

app.UseSerilogRequestLogging();
app.UseExceptionHandler();
app.UseCors("CorsPolicy");

app.UseAuthentication();
app.UseAuthorization();
// app.UseHttpsRedirection();

app.MapControllers();

app.Run();