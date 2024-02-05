using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CustomerDatabase.Server.Data;
using CustomerDatabase.Server.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("CustomerDatabaseServerContextConnection") ?? throw new InvalidOperationException("Connection string 'CustomerDatabaseServerContextConnection' not found.");

builder.Services.AddDbContext<CustomerDatabaseServerContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<CustomerDatabaseServerUser>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<CustomerDatabaseServerContext>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
