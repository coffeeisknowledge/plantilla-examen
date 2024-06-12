using si730pc2u20201b380.API.Profiles.Application.Internal.CommandServices;
using si730pc2u20201b380.API.Profiles.Application.Internal.QueryServices;
using si730pc2u20201b380.API.Profiles.Domain.Repositories;
using si730pc2u20201b380.API.Profiles.Domain.Services;
using si730pc2u20201b380.API.Profiles.Infrastructure.Persistence.EFC.Repositories;
using si730pc2u20201b380.API.Profiles.Interfaces.ACL;
using si730pc2u20201b380.API.Profiles.Interfaces.ACL.Services;
using si730pc2u20201b380.API.Publishing.Application.Internal.CommandServices;
using si730pc2u20201b380.API.Publishing.Application.Internal.QueryServices;
using si730pc2u20201b380.API.Publishing.Domain.Repositories;
using si730pc2u20201b380.API.Publishing.Domain.Services;
using si730pc2u20201b380.API.Publishing.Infrastructure.Persistence.EFC.Repositories;
using si730pc2u20201b380.API.Shared.Domain.Repositories;
using si730pc2u20201b380.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using si730pc2u20201b380.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using si730pc2u20201b380.API.Shared.Interfaces.ASP.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using si730pc2u20201b380.API.Subscriptions.Application.Internal.CommandServices;
using si730pc2u20201b380.API.Subscriptions.Application.Internal.QueryServices;
using si730pc2u20201b380.API.Subscriptions.Domain.Repositories;
using si730pc2u20201b380.API.Subscriptions.Domain.Services;
using si730pc2u20201b380.API.Subscriptions.Infrastructure.Persistence.EFC.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers(options => options.Conventions.Add(new KebabCaseRouteNamingConvention()));

// Add Database Connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Configure Database Context and Logging Levels

builder.Services.AddDbContext<AppDbContext>(
    options =>
    {
        if (connectionString != null)
            if (builder.Environment.IsDevelopment())
                options.UseMySQL(connectionString)
                    .LogTo(Console.WriteLine, LogLevel.Information)
                    .EnableSensitiveDataLogging()
                    .EnableDetailedErrors();
            else if (builder.Environment.IsProduction())
                options.UseMySQL(connectionString)
                    .LogTo(Console.WriteLine, LogLevel.Error)
                    .EnableDetailedErrors();    
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(
    c =>
    {
        c.SwaggerDoc("v1",
            new OpenApiInfo
            {
                Title = "si730pc2u20201b380.API",
                Version = "v1",
                Description = "SI730 [Name] Platform API",
                TermsOfService = new Uri("https://acme-learning.com/tos"),
                Contact = new OpenApiContact
                {
                    Name = "Abel Angel Ortega Huaraca",
                    Email = "u20201b380@upc.edu.pe"
                },
                License = new OpenApiLicense
                {
                    Name = "Apache 2.0",
                    Url = new Uri("https://www.apache.org/licenses/LICENSE-2.0.html")
                }
            });
        c.EnableAnnotations();
    });


// Configure Lowercase URLs
builder.Services.AddRouting(options => options.LowercaseUrls = true);

// Configure Dependency Injection

// Shared Bounded Context Injection Configuration
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// Publishing Bounded Context Injection Configuration
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryCommandService, CategoryCommandService>();
builder.Services.AddScoped<ICategoryQueryService, CategoryQueryService>();
builder.Services.AddScoped<ITutorialRepository, TutorialRepository>();
builder.Services.AddScoped<ITutorialCommandService, TutorialCommandService>();
builder.Services.AddScoped<ITutorialQueryService, TutorialQueryService>();

// Profiles Bounded Context Injection Configuration
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();
builder.Services.AddScoped<IProfileCommandService, ProfileCommandService>();
builder.Services.AddScoped<IProfileQueryService, ProfileQueryService>();
builder.Services.AddScoped<IProfilesContextFacade, ProfilesContextFacade>();

// Subscriptions Bounded Context Injection Configuration
builder.Services.AddScoped<IPlanRepository, PlanRepository>();
builder.Services.AddScoped<IPlanCommandService, PlanCommandService>();
builder.Services.AddScoped<IPlanQueryService, PlanQueryService>();

var app = builder.Build();

// Verify Database Objects are created
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<AppDbContext>();
    context.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();