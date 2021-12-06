using Azure.Identity;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Graph;
using Microsoft.Identity.Web;
using System.IdentityModel.Tokens.Jwt;
using Zippy.Cash.Repository;
using Zippy.Cash.Repository.Abstract;
using Zippy.Cash.Repository.Concrete;
using WebApplication = Microsoft.AspNetCore.Builder.WebApplication;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
JwtSecurityTokenHandler.DefaultMapInboundClaims = false;
// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddApiVersioning(x =>
    {
        x.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
        x.AssumeDefaultVersionWhenUnspecified = true;
        x.ReportApiVersions = true;
    });
builder.Services
       .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
       .AddMicrosoftIdentityWebApi(
            options =>
            {
                builder.Configuration.Bind("AzureAdB2C", options);
                options.TokenValidationParameters.NameClaimType = JwtRegisteredClaimNames.Sub;
            },
            options => builder.Configuration.Bind("AzureAdB2C", options))
       .EnableTokenAcquisitionToCallDownstreamApi(options => { })
       .AddMicrosoftGraph(
                authenticationProvider => new GraphServiceClient(new ClientSecretCredential(
                    tenantId: "d0c1aedf-ff82-46fd-890a-3100c16e14ab",
                    clientId: "0f2b00c3-dc2e-4ce6-ab2b-f4830c77a432",
                    clientSecret: "69u7Q~2JZgVzttFwb2gNgIjDnPBuKwCPg1HMo")),
                Array.Empty<string>())
       .AddInMemoryTokenCaches();

builder.Services.AddDbContext<ZippyDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ZippyDB"), assembly => assembly.MigrationsAssembly(typeof(ZippyDBContext).Assembly.FullName)));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//DI
builder.Services.AddScoped<IRegionRepository, RegionRepository>();

WebApplication app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseApiVersioning();
app.MapControllers();
app.Run();
