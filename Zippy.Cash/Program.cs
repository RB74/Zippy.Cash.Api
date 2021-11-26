using Microsoft.EntityFrameworkCore;
using Zippy.Cash.Repository;
using Zippy.Cash.Repository.Abstract;
using Zippy.Cash.Repository.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<ZippyDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ZippyDB"), assembly => assembly.MigrationsAssembly(typeof(ZippyDBContext).Assembly.FullName)));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//DI
builder.Services.AddScoped<IRegionRepository, RegionRepository>();

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
