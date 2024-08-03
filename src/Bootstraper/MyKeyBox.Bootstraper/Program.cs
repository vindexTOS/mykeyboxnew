using MyKeyBox.Modules.BackOffice.Api;
using MyKeyBox.Shared.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddInfrastructure();
    builder.Services.AddBackOfficeModule();
}
var app = builder.Build();
{
    if (builder.Environment.IsDevelopment())
    {
        app.UseDeveloperExceptionPage();
    }
    app.UseRouting();
    app.MapControllers();
    app.Run();
}




