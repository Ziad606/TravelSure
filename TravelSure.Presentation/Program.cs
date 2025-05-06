using TravelSure.Business;
using TravelSure.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddScoped<IPackageRepo, PackageRepo>();
builder.Services.AddScoped<IPackageService, PackageService>();

// Active Model State
builder.Services.AddControllers().ConfigureApiBehaviorOptions(
    options => options.SuppressModelStateInvalidFilter = true
);


var app = builder.Build();

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
