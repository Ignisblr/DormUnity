using Microsoft.EntityFrameworkCore;
using RequestService.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Custom services
builder.Services.AddDbContext<AppDbContext>(opts => opts.UseInMemoryDatabase("InMem"));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();

app.UseRouting();

app.UseEndpoints(endpoints => {
            _ = endpoints.MapControllers();
});

DbPrepare.PrepareData(app);

app.Run();
