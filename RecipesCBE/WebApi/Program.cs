using Domain.Services;
using Domain.Storage;
using Infrastructure.Storage;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder( args );

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Domain
builder.Services.AddScoped<IUserService, UserService>();

// Infrastructure
builder.Services.AddDbContext<ApplicationContext>( opts => opts.UseSqlServer( builder.Configuration.GetConnectionString( "DbConnection" ) ) );
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if ( app.Environment.IsDevelopment() )
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
