using NotificationService.Extensions;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddServices(builder.Configuration);
builder.Configuration.AddEnvironmentVariables();

var host = builder.Build();

host.Run();
