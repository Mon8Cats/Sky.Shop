using Discount.Grpc.HostedServices;
using Discount.Grpc.Repositories;
using Discount.Grpc.Services;
using Discount.Grpc.Settings;
using Microsoft.AspNetCore.Server.Kestrel.Core;

var builder = WebApplication.CreateBuilder(args);


builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenLocalhost(5503, 
        o => o.Protocols = HttpProtocols.Http2);
});


// Additional configuration is required to successfully run gRPC on macOS.
// For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

// Add services to the container.
builder.Services.Configure<NpgsqlSettings>(builder.Configuration.GetSection(nameof(NpgsqlSettings)));

builder.Services.AddScoped<IDiscountRepository, DiscountRepository>();


builder.Services.AddGrpc();

builder.Services.AddHostedService<CouponMigrationHostedService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<DiscountService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
